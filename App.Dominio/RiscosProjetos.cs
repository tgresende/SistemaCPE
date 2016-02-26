using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dominio
{
    public class RiscosProjetos : BasicClass
    {
        public int RiscoId { get; set; }
        public int ProjetosId { get; set; }
        public string Descricao { get; set; }
        public string Observacao { get; set; }
        public double Score { get; set; }
        public double Impacto { get; set; }
        public double Probabilidade { get; set; }
        public int Previsto { get; set; }


        // ISSO TEM QUE FICAR PARA MOSTRAR QUE PROJETOS É PAI
        public virtual Projetos Projetos { get; set; }


        public virtual Riscos Riscos { get; set; }
    }
}
