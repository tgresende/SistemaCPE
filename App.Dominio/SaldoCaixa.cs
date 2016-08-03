using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dominio
{
    public class SaldoCaixa : BasicClass
    {
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public double ValorAbertura { get; set; }
        public bool Fechado { get; set; }
    }
}
