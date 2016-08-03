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
    public class SaldoCaixaController : ApiController
    {
        private string _mensagem = "";

        [HttpGet]
        public IEnumerable<SaldoCaixa> Filtrar(string condicao)
        {
            return new SaldoCaixaRepositorio().Filtrar(condicao).ToList();
        }

        [HttpGet]
        public IEnumerable<SaldoCaixa> SelecionarTodos()
        {
            return new SaldoCaixaRepositorio().SelecionarTodos().ToList();
        }

        [HttpGet]
        public SaldoCaixa Selecionar(int id)
        {
            return new SaldoCaixaRepositorio().Selecionar(id);
        }

        [HttpPost]
        public string Excluir(SaldoCaixa entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                _mensagem = new SaldoCaixaRepositorio(contexto).Excluir(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

        [HttpPost]
        public string Salvar(SaldoCaixa entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                if (entity.Id == 0)
                    _mensagem = new SaldoCaixaRepositorio(contexto).Incluir(entity);
                else
                    _mensagem = new SaldoCaixaRepositorio(contexto).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

    }
}
