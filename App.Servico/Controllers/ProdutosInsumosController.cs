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
    public class ProdutosInsumosController : ApiController
    {
        private string _mensagem = "";

        [HttpGet]
        public IEnumerable<ProdutosInsumos> Filtrar(string condicao)
        {
            return new ProdutosInsumosRepositorio().Filtrar(condicao).ToList();
        }

        [HttpGet]
        public IEnumerable<ProdutosInsumos> SelecionarTodos()
        {
            return new ProdutosInsumosRepositorio().SelecionarTodos().ToList();
        }

        [HttpGet]
        public ProdutosInsumos Selecionar(int id)
        {
            return new ProdutosInsumosRepositorio().Selecionar(id);
        }

      
       


        [HttpPost]
        public string Excluir(ProdutosInsumos entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                _mensagem = new ProdutosInsumosRepositorio(contexto).Excluir(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

        [HttpPost]
        public string Salvar(ProdutosInsumos entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                if (entity.Id == 0)
                    _mensagem = new ProdutosInsumosRepositorio(contexto).Incluir(entity);
                else
                    _mensagem = new ProdutosInsumosRepositorio(contexto).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

    }
}
