using App.Dominio;
using App.DTO;
using App.InfraEstrutura.Configuracao;
using App.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;


namespace App.Servico.Controllers
{
    public class PedidosController
    {
        private string _mensagem = "";


        public IEnumerable<Pedidos> Filtrar(string condicao)
        {
            return new PedidosRepositorio().Filtrar(condicao).ToList();
        }


        public IEnumerable<Pedidos> SelecionarTodos()
        {
            return new PedidosRepositorio().SelecionarTodos().ToList();
        }

        public Pedidos Selecionar(int id)
        {
            return new PedidosRepositorio().Selecionar(id);
        }



        public string Excluir(Pedidos entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                _mensagem = new PedidosRepositorio(contexto).Excluir(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }


        public string Salvar(Pedidos entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                if (entity.Id == 0)
                    _mensagem = new PedidosRepositorio(contexto).Incluir(entity);
                else
                    _mensagem = new PedidosRepositorio(contexto).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

    }
}
