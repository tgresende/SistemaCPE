using App.Service.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace App.Comunicacao
{
    public static class Servicos
    {
        public static MovimentoCaixaController MovimentoCaixaServico = new MovimentoCaixaController();
        public static PessoasController PessoasServico = new PessoasController();
        public static ContasController ContasServico = new ContasController();
        public static SaldoCaixaController SaldoCaixaServico = new SaldoCaixaController();
        public static ProdutosController ProdutosServico = new ProdutosController();
        public static InsumosController InsumosServico = new InsumosController();
        public static ProdutosInsumosController ProdutosInsumosServico = new ProdutosInsumosController();

    }
}
