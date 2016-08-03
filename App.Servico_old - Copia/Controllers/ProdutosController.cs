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
    public class ProdutosController : ApiController
    {
        private string _mensagem = "";

        [HttpGet]
        public IEnumerable<Produtos> Filtrar(string condicao)
        {
            return new ProdutosRepositorio().Filtrar(condicao).ToList();
        }

        [HttpGet]
        public IEnumerable<Produtos> SelecionarTodos()
        {
            return new ProdutosRepositorio().SelecionarTodos().ToList();
        }

        [HttpGet]
        public Produtos Selecionar(int id)
        {
            return new ProdutosRepositorio().Selecionar(id);
        }



        [HttpGet]
        public IEnumerable<Produtos> SelecionarProduto(string filtro)
        {
            return new ProdutosRepositorio().SelecionarProduto(filtro).ToList();
        }


        [HttpPost]
        public string Excluir(Produtos entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                _mensagem = new ProdutosRepositorio(contexto).Excluir(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

        [HttpPost]
        public string Salvar(Produtos entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                if (entity.Id == 0)
                    _mensagem = new ProdutosRepositorio(contexto).Incluir(entity);
                else
                    _mensagem = new ProdutosRepositorio(contexto).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

    }
}
