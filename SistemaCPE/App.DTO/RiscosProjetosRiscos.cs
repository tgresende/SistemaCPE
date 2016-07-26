using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DTO
{
    public class RiscosProjetosRiscos
    {
        public int Id { get; set; } // id do riscosprojeto
        public int RiscoId { get; set; }
        public int ProjetosId { get; set; }
        public string Descricao { get; set; }
        public string Observacao { get; set; }
        public double Score { get; set; }
        public double Impacto { get; set; }
        public double Probabilidade { get; set; }
        public int Previsto { get; set; }
        public string Nome { get; set; }
        public string DescricaoRiscos { get; set; }
        public string MedidaPreventiva { get; set; }
        public string PlanoContigencia { get; set; }
    }
}
