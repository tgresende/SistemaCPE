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
    public class RiscosProjetosController : ApiController
    {
        private string _mensagem = "";

        [HttpGet]
        public IEnumerable<RiscosProjetos> Filtrar(string condicao)
        {
            return new RiscosProjetosRepositorio().Filtrar(condicao).ToList();
        }

        [HttpGet]
        public IEnumerable<RiscosProjetos> SelecionarTodos()
        {
            return new RiscosProjetosRepositorio().SelecionarTodos().ToList();
        }

        [HttpGet]
        public IEnumerable<RiscosProjetosProjetos> SelecionarRiscosProjetos(string filtro)
        {
            return new RiscosProjetosRepositorio().SelecionarRiscosProjetos(filtro).ToList();
        }


        [HttpGet]
        public RiscosProjetos Selecionar(int id)
        {
            return new RiscosProjetosRepositorio().Selecionar(id);
        }

        [HttpPost]
        public string Excluir(RiscosProjetos entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                _mensagem = new RiscosProjetosRepositorio(contexto).Excluir(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

        [HttpPost]
        public string Salvar(RiscosProjetos entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                if (entity.Id == 0)
                    _mensagem = new RiscosProjetosRepositorio(contexto).Incluir(entity);
                else
                    _mensagem = new RiscosProjetosRepositorio(contexto).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

    }
}
