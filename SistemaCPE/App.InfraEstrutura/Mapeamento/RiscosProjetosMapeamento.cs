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
    public class RiscosProjetosMapeamento : EntityTypeConfiguration<RiscosProjetos>
    {
        public RiscosProjetosMapeamento()
        {
            ToTable("RiscosProjetos");
            HasKey(c => c.Id).Property(c => c.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Descricao).IsRequired();
            Property(c => c.ProjetosId).IsRequired();
            Property(c => c.Observacao).HasMaxLength(500);
            Property(c => c.Impacto).IsRequired();
            Property(c => c.Previsto).IsRequired();
            Property(c => c.Probabilidade);
            Property(c => c.RiscoId);
            Property(c => c.Score);

            //HasRequired(p => p.Projetos).WithMany(b => b.RiscosProjetos).HasForeignKey(p => p.ProjetosId);
        }
    }
}

