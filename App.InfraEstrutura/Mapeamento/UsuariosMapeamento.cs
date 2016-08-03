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
    public class UsuariosMapeamento : EntityTypeConfiguration<Usuarios>
    {
        public UsuariosMapeamento()
        {
            ToTable("Usuarios");
            HasKey(c => c.Id).Property(c => c.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.PessoaId).IsRequired();
            Property(c => c.Senha).HasMaxLength(20).IsRequired();
        }
    }
}