﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Dominio;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.InfraEstrutura.Mapeamento
{
    public class UnidadesMapeamento : EntityTypeConfiguration<Unidades>
    {
        public UnidadesMapeamento()
        {
            ToTable("Unidades");
            HasKey(c => c.Id).Property(c => c.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Nome).HasMaxLength(50).IsRequired();
            Property(c => c.Sigla).HasMaxLength(5).IsRequired();
        }
    }
}