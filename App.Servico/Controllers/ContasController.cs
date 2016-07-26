using App.Dominio;
using App.InfraEstrutura.Configuracao;
using App.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Web.Http;

namespace App.Service.Controllers
{
    public class ContasController : ApiController
    {
        private string _mensagem = "";

        [HttpGet]
        public IEnumerable<Contas> Filtrar(string condicao)
        {
            return new ContasRepositorio().Filtrar(condicao).ToList();
        }

        [HttpGet]
        public IEnumerable<Contas> SelecionarTodos()
        {
            return new ContasRepositorio().SelecionarTodos().ToList();
        }

        [HttpGet]
        public Contas Selecionar(int id)
        {
            return new ContasRepositorio().Selecionar(id);
        }

        [HttpPost]
        public string Excluir(Contas entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                _mensagem = new ContasRepositorio(contexto).Excluir(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

        [HttpPost]
        public string Salvar(Contas entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                if (entity.Id == 0)
                    _mensagem = new ContasRepositorio(contexto).Incluir(entity);
                else
                    _mensagem = new ContasRepositorio(contexto).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

    }
}
