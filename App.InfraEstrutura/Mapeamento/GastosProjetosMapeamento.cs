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
    public class GastosProjetosMapeamento : EntityTypeConfiguration<GastosProjetos>
    {
        public GastosProjetosMapeamento()
        {
            ToTable("GastosProjetos");
            HasKey(c => c.Id).Property(c => c.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.GastoId).IsRequired();
            Property(c => c.ProjetosId).IsRequired();
            Property(c => c.Observacao).HasMaxLength(500);
            Property(c => c.QuantidadePrevista).IsRequired();
            Property(c => c.ValorUnitarioPrevisto).IsRequired();
            Property(c => c.QuantidadeReal);
            Property(c => c.ValorUnitarioReal);

            HasRequired(p => p.Projetos).WithMany(b => b.GastosProjetos).HasForeignKey(p => p.ProjetosId);
        }
    }
}

