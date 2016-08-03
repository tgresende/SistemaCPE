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
    public class FornecedoresController
    {
        private string _mensagem = "";


        public IEnumerable<Fornecedores> Filtrar(string condicao)
        {
            return new FornecedoresRepositorio().Filtrar(condicao).ToList();
        }


        public IEnumerable<Fornecedores> SelecionarTodos()
        {
            return new FornecedoresRepositorio().SelecionarTodos().ToList();
        }

        public Fornecedores Selecionar(int id)
        {
            return new FornecedoresRepositorio().Selecionar(id);
        }



        public string Excluir(Fornecedores entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                _mensagem = new FornecedoresRepositorio(contexto).Excluir(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }


        public string Salvar(Fornecedores entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                if (entity.Id == 0)
                    _mensagem = new FornecedoresRepositorio(contexto).Incluir(entity);
                else
                    _mensagem = new FornecedoresRepositorio(contexto).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

    }
}
