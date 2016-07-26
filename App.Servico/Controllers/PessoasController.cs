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
    public class PessoasController : ApiController
    {
        private string _mensagem = "";

        [HttpGet]
        public IEnumerable<Pessoas> Filtrar(string condicao)
        {
            return new PessoasRepositorio().Filtrar(condicao).ToList();
        }

        [HttpGet]
        public IEnumerable<Pessoas> SelecionarTodos()
        {
            return new PessoasRepositorio().SelecionarTodos().ToList();
        }

        [HttpGet]
        public Pessoas Selecionar(int id)
        {
            return new PessoasRepositorio().Selecionar(id);
        }

        [HttpPost]
        public string Excluir(Pessoas entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                _mensagem = new PessoasRepositorio(contexto).Excluir(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

        [HttpPost]
        public string Salvar(Pessoas entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                if (entity.Id == 0)
                    _mensagem = new PessoasRepositorio(contexto).Incluir(entity);
                else
                    _mensagem = new PessoasRepositorio(contexto).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

    }
}
