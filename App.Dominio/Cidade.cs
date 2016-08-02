using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dominio
{
    public class Cidade : BasicClass
    {
        public string Nome { get; set; }
        public string Estado { get; set; }
        public string SiglaEstado { get; set; }
        public string CodigoIgbe { get; set; }

        public virtual ICollection<Pessoas> Pessoas { get; set; }//fk Pessoa para Cidade
    }
}
