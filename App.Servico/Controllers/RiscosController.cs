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
    public class RiscosController : ApiController
    {
        private string _mensagem = "";

        [HttpGet]
        public IEnumerable<Riscos> Filtrar(string condicao)
        {
            return new RiscosRepositorio().Filtrar(condicao).ToList();
        }

        [HttpGet]
        public IEnumerable<Riscos> SelecionarTodos()
        {
            return new RiscosRepositorio().SelecionarTodos().ToList();
        }

        [HttpGet]
        public IEnumerable<RiscosProjetosRiscos> SelecionarRiscos(string filtro)
        {

            return new RiscosRepositorio().SelecionarRiscos(filtro).ToList();
        }


        [HttpGet]
        public Riscos Selecionar(int id)
        {
            return new RiscosRepositorio().Selecionar(id);
        }

        [HttpPost]
        public string Excluir(Riscos entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                _mensagem = new RiscosRepositorio(contexto).Excluir(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

        [HttpPost]
        public string Salvar(Riscos entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                if (entity.Id == 0)
                    _mensagem = new RiscosRepositorio(contexto).Incluir(entity);
                else
                    _mensagem = new RiscosRepositorio(contexto).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

    }
}
