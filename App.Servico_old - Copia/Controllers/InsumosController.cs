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
    public class InsumosController : ApiController
    {
        private string _mensagem = "";

        [HttpGet]
        public IEnumerable<Insumos> Filtrar(string condicao)
        {
            return new InsumosRepositorio().Filtrar(condicao).ToList();
        }

        [HttpGet]
        public IEnumerable<Insumos> SelecionarTodos()
        {
            return new InsumosRepositorio().SelecionarTodos().ToList();
        }

        [HttpGet]
        public Insumos Selecionar(int id)
        {
            return new InsumosRepositorio().Selecionar(id);
        }


        [HttpGet]
        public IEnumerable<InsumosProdutos> SelecionarInsumoPorProduto(string filtro)
        {
            return new InsumosRepositorio().SelecionarInsumoPorProduto(filtro).ToList();
        }

        [HttpGet]
        public IEnumerable<Insumos> SelecionarInsumo(string filtro)
        {
            return new InsumosRepositorio().SelecionarInsumo(filtro).ToList();
        }


        [HttpPost]
        public string Excluir(Insumos entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                _mensagem = new InsumosRepositorio(contexto).Excluir(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

        [HttpPost]
        public string Salvar(Insumos entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                if (entity.Id == 0)
                    _mensagem = new InsumosRepositorio(contexto).Incluir(entity);
                else
                    _mensagem = new InsumosRepositorio(contexto).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

    }
}
