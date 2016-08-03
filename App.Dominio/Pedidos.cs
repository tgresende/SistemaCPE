using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dominio
{
    public class Pedidos : BasicClass
    {
        public int PessoaId { get; set; }  // filho de clientes
        public DateTime DataEmissao { get; set; }
        public DateTime DataPagamento { get; set; }
        public double Valor { get; set; }
        public double Desconto { get; set; }
        public double Acrescimo { get; set; }
        public CompraVendaPedido CompraVenda { get; set; }
    }
}
