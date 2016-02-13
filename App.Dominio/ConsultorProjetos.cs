using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dominio
{
    class ConsultorProjetos
    {
        public string NomeProjeto { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; } // DateTime? = aceita nulo
        public int ResponsavelId { get; set; }
    }
}
