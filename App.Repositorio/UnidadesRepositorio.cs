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
    public class UnidadesRepositorio : IPadraoRepositorio<Unidades>
    {
        private IRepositorio<Unidades> _Repositorio;

        private AppContext _db = new AppContext();

        public UnidadesRepositorio(AppContext context = null)
        {
            _Repositorio = new Repositorio<Unidades>(context == null ? new AppContext() : context);
        }

        public string Incluir(Unidades entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(Unidades entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(Unidades entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Delete(entity.Id);
            }
            return mensagem;
        }

        public Unidades Selecionar(int id)
        {
            return _Repositorio.GetById(id);
        }


        public IQueryable<Unidades> SelecionarTodos()
        {
            return _Repositorio.GetAll();
        }

        public IQueryable<Unidades> Filtrar(string condicao)
        {
            return _Repositorio.Filter(condicao);
        }

        public string ValidarDados(Unidades entity)
        {
            //verificacao de dados
            if (string.IsNullOrWhiteSpace(entity.Nome))
                return "Favor informar o nome.";
            if (string.IsNullOrWhiteSpace(entity.Sigla))
                return "Favor informar a sigla.";
            else
                return "";
        }

        public string ValidarExclusao(Unidades entity)
        {
            //    from q in _db.Pessoas where q.Unidades = en
            return "";
        }
    }
}
