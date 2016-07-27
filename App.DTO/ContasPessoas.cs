using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DTO
{
    public class ContasPessoas
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public DateTime DataVencimento { get; set; } 
        public int ContaId { get; set; }
        public string Nome { get; set; } //nome do cliente
        public string PagarReceber { get; set; } // P  ou R
        public string DescricaoConta { get; set; }
    }
}
