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
    public class PedidoItemMapeamento : EntityTypeConfiguration<PedidoItem>
    {
        public PedidoItemMapeamento()
        {
            ToTable("PedidoItem");
            HasKey(c => c.Id).Property(c => c.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.PedidoId).IsRequired();
            Property(c => c.ProdutoId).IsRequired();
            Property(c => c.ValorTotal).IsRequired();
            Property(c => c.ValorUnitario).IsRequired();
            Property(c => c.Quantidade).IsRequired();
            Property(c => c.DescontoTotal).IsRequired();
            Property(c => c.AcrescimoTotal).IsRequired();
        }
    }
}