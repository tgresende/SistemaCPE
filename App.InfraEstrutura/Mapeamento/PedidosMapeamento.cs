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
    public class PedidosMapeamento : EntityTypeConfiguration<Pedidos>
    {
        public PedidosMapeamento()
        {
            ToTable("Pedidos");
            HasKey(c => c.Id).Property(c => c.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.PessoaId).IsRequired();
            Property(c => c.DataEmissao).IsRequired();
            Property(c => c.DataPagamento);
            Property(c => c.DataEmissao).IsRequired();
            Property(c => c.Valor).IsRequired();
            Property(c => c.Desconto).IsRequired();
            Property(c => c.Acrescimo).IsRequired();
            Property(c => c.CompraVenda).IsRequired();
        }
    }
}

