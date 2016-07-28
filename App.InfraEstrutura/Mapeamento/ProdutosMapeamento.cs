using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Dominio;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.InfraEstrutura.Mapeamento
{
    public class ProdutosMapeamento : EntityTypeConfiguration<Produtos>
    {
        public ProdutosMapeamento()
        {
            ToTable("Produtos");
            HasKey(c => c.Id).Property(c => c.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Nome).HasMaxLength(100).IsRequired();
            Property(c => c.Peso).IsRequired();
            Property(c => c.Descricao).HasMaxLength(100).IsRequired();
            Property(c => c.Unidade).HasMaxLength(100).IsRequired();



            //chave estrangeira
            //HasRequired(p => p.Projetos).WithMany(b => b.GastosProjetos).HasForeignKey(p => p.ProjetosId);

        }
    }
}

