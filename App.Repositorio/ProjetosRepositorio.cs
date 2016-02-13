using App.Dominio;
using App.InfraEstrutura.Configuracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Repositorio
{
    public class ProjetosRepositorio : IPadraoRepositorio<Projetos>
    {
        private IRepositorio<Projetos> _Repositorio;

        public ProjetosRepositorio(AppContext context = null)
        {
            _Repositorio = new Repositorio<Projetos>(context == null ? new AppContext() : context);
        }

        public string Incluir(Projetos entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(Projetos entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(Projetos entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Delete(entity.Id);
            }
            return mensagem;
        }

        public Projetos Selecionar(int id)
        {
            return _Repositorio.GetById(id);
        }

        public IQueryable<Projetos> SelecionarTodos()
        {
            return _Repositorio.GetAll();
        }

        public IQueryable<Projetos> Filtrar(string condicao)
        {
            return _Repositorio.Filter(condicao);
        }

        public string ValidarDados(Projetos entity)
        {
            return "";
        }

        public string ValidarExclusao(Projetos entity)
        {
            return "";
        }
    }
}
