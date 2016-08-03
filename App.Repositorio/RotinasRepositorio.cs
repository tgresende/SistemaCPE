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
    public class RotinasRepositorio : IPadraoRepositorio<Rotinas>
    {
        private IRepositorio<Rotinas> _Repositorio;

        private AppContext _db = new AppContext();

        public RotinasRepositorio(AppContext context = null)
        {
            _Repositorio = new Repositorio<Rotinas>(context == null ? new AppContext() : context);
        }

        public string Incluir(Rotinas entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(Rotinas entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(Rotinas entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Delete(entity.Id);
            }
            return mensagem;
        }

        public Rotinas Selecionar(int id)
        {
            return _Repositorio.GetById(id);
        }


        public IQueryable<Rotinas> SelecionarTodos()
        {
            return _Repositorio.GetAll();
        }

        public IQueryable<Rotinas> Filtrar(string condicao)
        {
            return _Repositorio.Filter(condicao);
        }

        public string ValidarDados(Rotinas entity)
        {
            //verificacao de dados
            if (string.IsNullOrWhiteSpace(entity.Nome))
                return "Favor informar o nome.";
            else
                return "";
        }

        public string ValidarExclusao(Rotinas entity)
        {
            //    from q in _db.Pessoas where q.Rotinas = en
            return "";
        }
    }
}
