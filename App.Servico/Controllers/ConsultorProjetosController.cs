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
    public class ConsultorProjetosController : ApiController
    {
        private string _mensagem = "";

        [HttpGet]
        public IEnumerable<ConsultorProjetos> Filtrar(string condicao)
        {
            return new ConsultorProjetosRepositorio().Filtrar(condicao).ToList();
        }

        [HttpGet]
        public IEnumerable<ConsultorProjetos> SelecionarTodos()
        {
            return new ConsultorProjetosRepositorio().SelecionarTodos().ToList();
        }

        [HttpGet]
        public ConsultorProjetos Selecionar(int id)
        {
            return new ConsultorProjetosRepositorio().Selecionar(id);
        }

        [HttpPost]
        public string Excluir(ConsultorProjetos entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                _mensagem = new ConsultorProjetosRepositorio(contexto).Excluir(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

        [HttpPost]
        public string Salvar(ConsultorProjetos entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                if (entity.Id == 0)
                    _mensagem = new ConsultorProjetosRepositorio(contexto).Incluir(entity);
                else
                    _mensagem = new ConsultorProjetosRepositorio(contexto).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

    }
}
