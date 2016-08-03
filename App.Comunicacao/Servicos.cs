using App.Servico.Controllers;
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
        public static ProdutosInsumosController ProdutosInsumosServico = new ProdutosInsumosController();
        public static ClientesController ClientesServico = new ClientesController();
        public static FornecedoresController FornecedoresServico = new FornecedoresController();
        public static FuncionariosController FuncionariosServico = new FuncionariosController();
        public static UsuariosController UsuariosServico = new UsuariosController();
        public static UsuarioAcessoController UsuarioAcessoServico = new UsuarioAcessoController();
        public static RotinasController RotinasServico = new RotinasController();
        public static PedidosController PedidosServico = new PedidosController();
        public static PedidoItemController PedidoItemServico = new PedidoItemController();
        public static UnidadesController UnidadesServico = new UnidadesController();
        public static TipoContaController TipoContaServico = new TipoContaController();
    }
}
