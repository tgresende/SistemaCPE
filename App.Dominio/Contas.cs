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
        public double Acrescimo { get; set; }
        public double Desconto { get; set; }
        public PagarReceber PagarReceber { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVencimento { get; set; } // DateTime? = aceita nulo
        public DateTime DataPagamento { get; set; }
        public int TipoContaId { get; set; } //filho do TipoConta
        public int PessoaId { get; set; }
        public string Descricao { get; set; }
        public bool Pago { get; set; } 
    }



}
