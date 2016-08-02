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
    public class CidadeRepositorio : IPadraoRepositorio<Cidade>
    {
        private IRepositorio<Cidade> _Repositorio;

        private AppContext _db = new AppContext();

        public CidadeRepositorio(AppContext context = null)
        {
            _Repositorio = new Repositorio<Cidade>(context == null ? new AppContext() : context);
        }

        public string Incluir(Cidade entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(Cidade entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(Cidade entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Delete(entity.Id);
            }
            return mensagem;
        }

        public Cidade Selecionar(int id)
        {
            return _Repositorio.GetById(id);
        }


        public IQueryable<Cidade> SelecionarTodos()
        {
            return _Repositorio.GetAll();
        }

        public IQueryable<Cidade> Filtrar(string condicao)
        {
            return _Repositorio.Filter(condicao);
        }

        public string ValidarDados(Cidade entity)
        {
            //verificacao de dados
            if (string.IsNullOrWhiteSpace(entity.Nome))
                return "Favor informar o nome.";
            else if (string.IsNullOrWhiteSpace(entity.Estado))
                return "Favor informar o estado.";
            else if (string.IsNullOrWhiteSpace(entity.SiglaEstado))
                return "Favor informar a sigla.";
            else if (string.IsNullOrWhiteSpace(entity.CodigoIgbe))
                return "Favor informar o estado.";
            else
                return "";
        }

        public string ValidarExclusao(Cidade entity)
        {
            from q in _db.Pessoas where q.Cidade = en
            return "";
        }
    }
}
