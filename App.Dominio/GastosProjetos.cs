﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dominio
{
    public class GastosProjetos : BasicClass
    {
        public int GastoId { get; set; }
        public int ProjetosId { get; set; }
        public string Observacao { get; set; }
        public double QuantidadePrevista { get; set; }
        public double ValorUnitarioPrevisto { get; set; }
        public double? QuantidadeReal { get; set; }
        public double? ValorUnitarioReal { get; set; }


        public virtual Projetos Projetos { get; set; }
    }
}
