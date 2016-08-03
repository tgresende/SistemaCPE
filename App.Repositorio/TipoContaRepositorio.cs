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
    public class TipoContaRepositorio : IPadraoRepositorio<TipoConta>
    {
        private IRepositorio<TipoConta> _Repositorio;

        private AppContext _db = new AppContext();

        public TipoContaRepositorio(AppContext context = null)
        {
            _Repositorio = new Repositorio<TipoConta>(context == null ? new AppContext() : context);
        }

        public string Incluir(TipoConta entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(TipoConta entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(TipoConta entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Delete(entity.Id);
            }
            return mensagem;
        }

        public TipoConta Selecionar(int id)
        {
            return _Repositorio.GetById(id);
        }


        public IQueryable<TipoConta> SelecionarTodos()
        {
            return _Repositorio.GetAll();
        }

        public IQueryable<TipoConta> Filtrar(string condicao)
        {
            return _Repositorio.Filter(condicao);
        }

        public string ValidarDados(TipoConta entity)
        {
            //verificacao de dados
            if (string.IsNullOrWhiteSpace(entity.Descricao))
                return "Favor informar a descricao.";
            else if (entity.PagarReceber == PagarReceber.Nulo)
                return "Favor informar se o tipo de conta é à pagar ou à receber.";
            else
                return "";
        }

        public string ValidarExclusao(TipoConta entity)
        {
            //    from q in _db.Pessoas where q.TipoConta = en
            return "";
        }
    }
}
