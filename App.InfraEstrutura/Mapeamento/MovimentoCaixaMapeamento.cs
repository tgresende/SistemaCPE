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
    public class MovimentoCaixaMapeamento : EntityTypeConfiguration<MovimentoCaixa>
    {
        public MovimentoCaixaMapeamento()
        {
           
            ToTable("MovimentoCaixa");
            HasKey(c => c.Id).Property(c => c.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.ContaId).IsRequired();
            Property(c => c.Valor).IsRequired();
            Property(c => c.Data).IsRequired();
            
        }
    }
}

