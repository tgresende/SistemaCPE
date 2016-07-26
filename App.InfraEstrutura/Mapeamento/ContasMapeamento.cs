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
    public class ContasMapeamento : EntityTypeConfiguration<Contas>
    {
        public ContasMapeamento()
        {
            ToTable("Contas");
            HasKey(c => c.Id).Property(c => c.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.PagarReceber).HasMaxLength(1).IsRequired();
            Property(c => c.Valor).IsRequired();
            Property(c => c.Juros).IsRequired();
            Property(c => c.DataEmissao).IsRequired();
            Property(c => c.DataVencimento).IsRequired();
            Property(c => c.PessoaId).IsRequired();
        }
    }
}
