using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DTO
{
    public class RiscosProjetosProjetos
    {
        public int Id { get; set; }
        public int RiscoId { get; set; }
        public int ProjetosId { get; set; }
        public string Descricao { get; set; }
        public string Observacao { get; set; }
        public double Score { get; set; }
        public double Impacto { get; set; }
        public double Probabilidade { get; set; }
        public int Previsto { get; set; }
    }
}
