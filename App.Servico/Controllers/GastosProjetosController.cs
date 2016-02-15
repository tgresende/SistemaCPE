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
    public class GastosProjetosController : ApiController
    {
        private string _mensagem = "";

        [HttpGet]
        public IEnumerable<GastosProjetos> Filtrar(string condicao)
        {
            return new GastosProjetosRepositorio().Filtrar(condicao).ToList();
        }

        [HttpGet]
        public IEnumerable<GastosProjetos> SelecionarTodos()
        {
            return new GastosProjetosRepositorio().SelecionarTodos().ToList();
        }

        [HttpGet]
        public GastosProjetos Selecionar(int id)
        {
            return new GastosProjetosRepositorio().Selecionar(id);
        }

        [HttpPost]
        public string Excluir(GastosProjetos entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                _mensagem = new GastosProjetosRepositorio(contexto).Excluir(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

        [HttpPost]
        public string Salvar(GastosProjetos entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                if (entity.Id == 0)
                    _mensagem = new GastosProjetosRepositorio(contexto).Incluir(entity);
                else
                    _mensagem = new GastosProjetosRepositorio(contexto).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

    }
}
