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
    public class ConsultorProjetosMapeamento : EntityTypeConfiguration<ConsultorProjetos>
    {
        public ConsultorProjetosMapeamento()
        {
            ToTable("ConsultorProjetos");
            HasKey(c => c.Id).Property(c => c.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.HorasSemanais).IsRequired();
            Property(c => c.ProjetoId).IsRequired();
            Property(c => c.QuantidadeSemanas).IsRequired();
            Property(c => c.ValorHora).IsRequired();
            Property(c => c.ConsultorId).IsRequired();
        }
    }
}

