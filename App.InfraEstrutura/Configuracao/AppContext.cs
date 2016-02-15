using App.Dominio;
using MySql.Data.MySqlClient;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations.History;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace App.InfraEstrutura.Configuracao
{
    public class AppContext : DbContext
    {
        public AppContext()
            : base("AppConnectionString")
        {
            //System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //Database.Connection.ConnectionString = config.ConnectionStrings.ConnectionStrings["ProjetosConnectionString"].ConnectionString;

            if (Database.Connection is MySqlConnection)
            {
                Database.SetInitializer<AppContext>(new DropCreateDatabaseAlways<AppContext>());  //  descomentar caso queira dropar
                //Database.SetInitializer<AppContext>(new CreateDatabaseIfNotExists<AppContext>());
            }
            else
                Database.SetInitializer<AppContext>(null);


            Configuration.ProxyCreationEnabled = false;
            //Configuration.LazyLoadingEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            if (!(Database.Connection is SqlConnection))
            {
                var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                                .Where(type => !String.IsNullOrEmpty(type.Namespace))
                                .Where(type => type.BaseType != null && type.BaseType.IsGenericType && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
                foreach (var type in typesToRegister)
                {
                    dynamic configurationInstance = Activator.CreateInstance(type);
                    modelBuilder.Configurations.Add(configurationInstance);
                }
            }

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Projetos> Projetos { get; set; }
        public DbSet<GastosProjetos> GastosProjetos { get; set; }
       
        

    }
}
