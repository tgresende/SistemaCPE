using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dominio
{
    public class ConsultorProjetos : BasicClass
    {
        public int ConsultorId { get; set; }
        public int ProjetoId { get; set; }
        public double ValorHora { get; set; }
        public double HorasSemanais { get; set; }
        public double QuantidadeSemanas { get; set; }          
    }
}
