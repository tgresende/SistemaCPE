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
    public class CidadeMapeamento : EntityTypeConfiguration<Cidade>
    {
        public CidadeMapeamento()
        {
            ToTable("Cidade");
            HasKey(c => c.Id).Property(c => c.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Nome).HasMaxLength(100).IsRequired();
            Property(c => c.Estado);
            Property(c => c.SiglaEstado);
            Property(c => c.CodigoIgbe);            

        }
    }
}

