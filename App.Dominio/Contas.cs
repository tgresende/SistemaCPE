using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dominio
{
    public class Contas : BasicClass
    {
        public double Valor { get; set; }
        public double Juros { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVencimento { get; set; } // DateTime? = aceita nulo
        public DateTime DataPagamento { get; set; }
        public string PagarReceber { get; set; } // P OU R
        public int PessoaId { get; set; }
        public string Descricao { get; set; }
    }



}
