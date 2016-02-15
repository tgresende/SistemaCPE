using App.Dominio;
using App.DTO;
using App.InfraEstrutura.Configuracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Repositorio
{
    public class GastosProjetosRepositorio : IPadraoRepositorio<GastosProjetos>
    {
        private IRepositorio<GastosProjetos> _Repositorio;

        public GastosProjetosRepositorio(AppContext context = null)
        {
            _Repositorio = new Repositorio<GastosProjetos>(context == null ? new AppContext() : context);
        }
        public ICollection<GastosProjetosProjetos>(string filtro)
        {
            from q in _Repositorio.
        }


        public string Incluir(GastosProjetos entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(GastosProjetos entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(GastosProjetos entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Delete(entity.Id);
            }
            return mensagem;
        }

        public GastosProjetos Selecionar(int id)
        {
            return _Repositorio.GetById(id);
        }

        public IQueryable<GastosProjetos> SelecionarTodos()
        {
            return _Repositorio.GetAll();
        }

        public IQueryable<GastosProjetos> Filtrar(string condicao)
        {
            return _Repositorio.Filter(condicao);
        }

        public string ValidarDados(GastosProjetos entity)
        {
            return "";
        }

        public string ValidarExclusao(GastosProjetos entity)
        {
            return "";
        }
    }
}
