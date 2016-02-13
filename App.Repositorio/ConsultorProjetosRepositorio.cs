using App.Dominio;
using App.InfraEstrutura.Configuracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Repositorio
{
    public class ConsultorProjetosRepositorio : IPadraoRepositorio<ConsultorProjetos>
    {
        private IRepositorio<ConsultorProjetos> _Repositorio;

        public ConsultorProjetosRepositorio(AppContext context = null)
        {
            _Repositorio = new Repositorio<ConsultorProjetos>(context == null ? new AppContext() : context);
        }

        public string Incluir(ConsultorProjetos entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(ConsultorProjetos entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(ConsultorProjetos entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Delete(entity.Id);
            }
            return mensagem;
        }

        public ConsultorProjetos Selecionar(int id)
        {
            return _Repositorio.GetById(id);
        }

        public IQueryable<ConsultorProjetos> SelecionarTodos()
        {
            return _Repositorio.GetAll();
        }

        public IQueryable<ConsultorProjetos> Filtrar(string condicao)
        {
            return _Repositorio.Filter(condicao);
        }

        public string ValidarDados(ConsultorProjetos entity)
        {
            return "";
        }

        public string ValidarExclusao(ConsultorProjetos entity)
        {
            return "";
        }
    }
}
