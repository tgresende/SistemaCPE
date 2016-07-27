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
        public double Saldo { get; set; }
        public string Fechado { get; set; }
    }
}
