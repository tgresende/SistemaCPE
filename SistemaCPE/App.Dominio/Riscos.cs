using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dominio
{
    public class Riscos : BasicClass
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string MedidaPreventiva { get; set; }
        public string PlanoContigencia { get; set; }

        // para mostrar que Riscos é pai
        public virtual ICollection<RiscosProjetos> RiscosProjetos { get; set; }

        public Riscos()
        {
            this.RiscosProjetos = new HashSet<RiscosProjetos>();
        }
    }
}
