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
    public class RiscosMapeamento : EntityTypeConfiguration<Riscos>
    {
        public RiscosMapeamento()
        {
            ToTable("Riscos");
            HasKey(c => c.Id).Property(c => c.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            Property(c => c.Descricao).HasMaxLength(500);
            Property(c => c.MedidaPreventiva).HasMaxLength(500);
            Property(c => c.PlanoContigencia).HasMaxLength(500);
        }
    }
}