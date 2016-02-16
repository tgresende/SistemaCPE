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
    public class GastosController : ApiController
    {
        private string _mensagem = "";

        [HttpGet]
        public IEnumerable<Gastos> Filtrar(string condicao)
        {
            return new GastosRepositorio().Filtrar(condicao).ToList();
        }

        [HttpGet]
        public IEnumerable<Gastos> SelecionarTodos()
        {
            return new GastosRepositorio().SelecionarTodos().ToList();
        }

        [HttpGet]
        public IEnumerable<GastosProjetosGastos> SelecionarGastos(string filtro)
        {

            return new GastosRepositorio().SelecionarGastos(filtro).ToList();
        }


        [HttpGet]
        public Gastos Selecionar(int id)
        {
            return new GastosRepositorio().Selecionar(id);
        }

        [HttpPost]
        public string Excluir(Gastos entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                _mensagem = new GastosRepositorio(contexto).Excluir(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

        [HttpPost]
        public string Salvar(Gastos entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                if (entity.Id == 0)
                    _mensagem = new GastosRepositorio(contexto).Incluir(entity);
                else
                    _mensagem = new GastosRepositorio(contexto).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

    }
}
