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
        public DateTime Data { get; set; }
        public int ContaId { get; set; }
    }



}
