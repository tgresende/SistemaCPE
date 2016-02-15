using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dominio
{
    public class Projetos : BasicClass
    {       
        public string NomeProjeto { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; } // DateTime? = aceita nulo
        public int ResponsavelId { get; set; }

        public virtual ICollection<GastosProjetos> GastosProjetos { get; set; }

        public Projetos()
        {
           this.GastosProjetos = new HashSet<GastosProjetos>();
        }
    }

   
       
}
