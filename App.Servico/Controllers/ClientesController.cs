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
    public class ClientesController
    {
        private string _mensagem = "";


        public IEnumerable<Clientes> Filtrar(string condicao)
        {
            return new ClientesRepositorio().Filtrar(condicao).ToList();
        }


        public IEnumerable<Clientes> SelecionarTodos()
        {
            return new ClientesRepositorio().SelecionarTodos().ToList();
        }

        public Clientes Selecionar(int id)
        {
            return new ClientesRepositorio().Selecionar(id);
        }

            

        public string Excluir(Clientes entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                _mensagem = new ClientesRepositorio(contexto).Excluir(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }


        public string Salvar(Clientes entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                if (entity.Id == 0)
                    _mensagem = new ClientesRepositorio(contexto).Incluir(entity);
                else
                    _mensagem = new ClientesRepositorio(contexto).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

    }
}
