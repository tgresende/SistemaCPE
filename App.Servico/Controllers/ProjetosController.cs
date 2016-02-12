using App.Dominio;
using App.InfraEstrutura;
using App.Infrastructura;
using App.Infrastructure;
using App.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Web.Http;

namespace App.Service.Controllers
{
    public class ProjetosController : ApiController
    {
        private string _mensagem = "";

        [HttpGet]
        public IEnumerable<Projetos> Filtrar(string condicao)
        {
            return new ProjetosRepositorio().Filtrar(condicao).ToList();
        }

        [HttpGet]
        public IEnumerable<Projetos> SelecionarTodos()
        {
            return new ProjetosRepositorio().SelecionarTodos().ToList();
        }

        [HttpGet]
        public Projetos Selecionar(int id)
        {
            return new ProjetosRepositorio().Selecionar(id);
        }

        [HttpPost]
        public string Excluir(Projetos entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                _mensagem = new ProjetosRepositorio(contexto).Excluir(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

        [HttpPost]
        public string Salvar(Projetos entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                if (entity.Id == 0)
                    _mensagem = new ProjetosRepositorio(contexto).Incluir(entity);
                else
                    _mensagem = new ProjetosRepositorio(contexto).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

    }
}
