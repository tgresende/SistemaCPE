using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dominio
{
    public class PedidoItem : BasicClass
    {
        public int PedidoId { get; set; } // filho de pedido
        public int ProdutoId { get; set; } //filho de produto
        public double Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        public double ValorTotal { get; set; }
        public double AcrescimoTotal { get; set; }
        public double DescontoTotal { get; set; }
    }
}
