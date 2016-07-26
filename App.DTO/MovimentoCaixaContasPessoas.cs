using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DTO
{
    public class MovimentoCaixaContasPessoas
    {
        public int Id { get; set;}
        public double Valor { get; set; }
        public DateTime Data { get; set; }
        public int ContaId { get; set;}
        public string Nome { get; set; } //nome do cliente
        public string PagarReceber { get; set; } // P  ou R
    }
}
