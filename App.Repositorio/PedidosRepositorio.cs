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
    public class PedidosRepositorio : IPadraoRepositorio<Pedidos>
    {
        private IRepositorio<Pedidos> _Repositorio;

        private AppContext _db = new AppContext();

        public PedidosRepositorio(AppContext context = null)
        {
            _Repositorio = new Repositorio<Pedidos>(context == null ? new AppContext() : context);
        }

        public string Incluir(Pedidos entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(Pedidos entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(Pedidos entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Delete(entity.Id);
            }
            return mensagem;
        }

        public Pedidos Selecionar(int id)
        {
            return _Repositorio.GetById(id);
        }


        public IQueryable<Pedidos> SelecionarTodos()
        {
            return _Repositorio.GetAll();
        }

        public IQueryable<Pedidos> Filtrar(string condicao)
        {
            return _Repositorio.Filter(condicao);
        }

        public string ValidarDados(Pedidos entity)
        {
            //verificacao de dados
            if (entity.PessoaId == 0)
                return "Favor informar a Pessoa.";
            else if (entity.DataEmissao == DateTime.MinValue)
                return "Favor informar a data de emissão.";
            else if (entity.Valor == 0)
                return "Favor informar o valor.";
            else if (entity.Acrescimo == 0)
                return "Favor informar o acrescimo.";
            else if (entity.Desconto == 0)
                return "Favor informar o desconto.";
            else if ((entity.CompraVenda != CompraVendaPedido.Compra) && (entity.CompraVenda != CompraVendaPedido.Venda))
                return "Favor informar se é compra ou venda.";
            else
                return "";
        }

        public string ValidarExclusao(Pedidos entity)
        {
            //    from q in _db.Pessoas where q.Pedidos = en
            return "";
        }
    }
}
