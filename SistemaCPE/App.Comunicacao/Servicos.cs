﻿using App.Service.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace App.Comunicacao
{
    public static class Servicos
    {
        public static ProjetosController projetosServico = new ProjetosController();
        public static GastosProjetosController gastosprojetosServico = new GastosProjetosController();
        public static GastosController gastosServico = new GastosController();
        public static RiscosProjetosController riscosprojetosServico = new RiscosProjetosController();
        public static RiscosController riscosServico = new RiscosController();
    }
}
