using App.Dominio;
using App.DTO;
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
    public class MovimentoCaixaController : ApiController
    {
        private string _mensagem = "";

        [HttpGet]
        public IEnumerable<MovimentoCaixa> Filtrar(string condicao)
        {
            return new MovimentoCaixaRepositorio().Filtrar(condicao).ToList();
        }

        [HttpGet]
        public IEnumerable<MovimentoCaixa> SelecionarTodos()
        {
            return new MovimentoCaixaRepositorio().SelecionarTodos().ToList();
        }

        [HttpGet]
        public MovimentoCaixa Selecionar(int id)
        {
            return new MovimentoCaixaRepositorio().Selecionar(id);
        }

        [HttpGet]
        public IEnumerable<MovimentoCaixaContasPessoas> SelecionarMovimento(string filtro)
        {
            return new MovimentoCaixaRepositorio().SelecionarMovimento(filtro).ToList();
        }


        [HttpPost]
        public string Excluir(MovimentoCaixa entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                _mensagem = new MovimentoCaixaRepositorio(contexto).Excluir(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

        [HttpPost]
        public string Salvar(MovimentoCaixa entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                if (entity.Id == 0)
                    _mensagem = new MovimentoCaixaRepositorio(contexto).Incluir(entity);
                else
                    _mensagem = new MovimentoCaixaRepositorio(contexto).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

    }
}
