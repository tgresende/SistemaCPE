using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dominio
{
    public class MovimentoCaixa : BasicClass
    {
        public double Valor { get; set; }
        public double Desconto { get; set; }
        public double Acrescimo { get; set; }
        public string Descricao { get; set; }
        public CreditoDebito CreditoDebito { get; set; }
        public DateTime Data { get; set; }
    }



}
