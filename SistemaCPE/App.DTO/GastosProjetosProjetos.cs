using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DTO
{
    public class GastosProjetosProjetos
    {
        public int Id { get; set; }
        public int GastoId { get; set; }
        public int ProjetosId { get; set; }
        public string Observacao { get; set; }
        public double QuantidadePrevista { get; set; }
        public double ValorUnitarioPrevisto { get; set; }
        public double? QuantidadeReal { get; set; }
        public double? ValorUnitarioReal { get; set; }
        public string NomeProjeto { get; set; }
        public int ResponsavelId { get; set; }

    }
}
