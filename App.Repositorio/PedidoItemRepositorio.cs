using App.Dominio;
using App.DTO;
using App.InfraEstrutura.Configuracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Text;

namespace App.Repositorio
{
    public class PedidoItemRepositorio : IPadraoRepositorio<PedidoItem>
    {
        private IRepositorio<PedidoItem> _Repositorio;

        private AppContext _db = new AppContext();

        public PedidoItemRepositorio(AppContext context = null)
        {
            _Repositorio = new Repositorio<PedidoItem>(context == null ? new AppContext() : context);
        }

        public string Incluir(PedidoItem entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(PedidoItem entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(PedidoItem entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Delete(entity.Id);
            }
            return mensagem;
        }

        public PedidoItem Selecionar(int id)
        {
            return _Repositorio.GetById(id);
        }


        public IQueryable<PedidoItem> SelecionarTodos()
        {
            return _Repositorio.GetAll();
        }

        public IQueryable<PedidoItem> Filtrar(string condicao)
        {
            return _Repositorio.Filter(condicao);
        }

        public string ValidarDados(PedidoItem entity)
        {
            //verificacao de dados
            if (entity.PedidoId == 0)
                return "Favor informar a Pedido.";
            if (entity.ProdutoId == 0)
                return "Favor informar a Produto.";
            if (entity.Quantidade == 0)
                return "Favor informar a Quantidade.";
            if (entity.ValorTotal == 0)
                return "Favor informar o valor total.";
            if (entity.ValorUnitario == 0)
                return "Favor informar a valor unitario.";
            if (entity.DescontoTotal == 0)
                return "Favor informar o desconto total.";
            if (entity.AcrescimoTotal == 0)
                return "Favor informar o acrescimo total.";
            else
                return "";
        }

        public string ValidarExclusao(PedidoItem entity)
        {
            //    from q in _db.Pessoas where q.PedidoItem = en
            return "";
        }
    }
}
