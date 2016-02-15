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
            int i;
            //verificacao de dados
            if (string.IsNullOrWhiteSpace(entity.NomeProjeto))
                return "Nome do projeto não informado!";
            else if (DateTime.MinValue == entity.DataInicio)
                return "Data de início não informada!";
            if (string.IsNullOrWhiteSpace(entity.ResponsavelId.ToString()))
                return "Responsável não informado!";
            else if (!int.TryParse(entity.ResponsavelId.ToString(), out i))
                return "O responsável deve ser um número!";
            else
                return "";

           
        }

        public string ValidarExclusao(Projetos entity)
        {
            return "";
        }
    }
}
