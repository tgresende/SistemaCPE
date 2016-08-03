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
    public class PedidoItemController
    {
        private string _mensagem = "";


        public IEnumerable<PedidoItem> Filtrar(string condicao)
        {
            return new PedidoItemRepositorio().Filtrar(condicao).ToList();
        }


        public IEnumerable<PedidoItem> SelecionarTodos()
        {
            return new PedidoItemRepositorio().SelecionarTodos().ToList();
        }

        public PedidoItem Selecionar(int id)
        {
            return new PedidoItemRepositorio().Selecionar(id);
        }



        public string Excluir(PedidoItem entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                _mensagem = new PedidoItemRepositorio(contexto).Excluir(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }


        public string Salvar(PedidoItem entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                if (entity.Id == 0)
                    _mensagem = new PedidoItemRepositorio(contexto).Incluir(entity);
                else
                    _mensagem = new PedidoItemRepositorio(contexto).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

    }
}
