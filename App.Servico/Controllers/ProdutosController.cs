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
    public class ProdutosController 
    {
        private string _mensagem = "";

        
        public IEnumerable<Produtos> Filtrar(string condicao)
        {
            return new ProdutosRepositorio().Filtrar(condicao).ToList();
        }

        
        public IEnumerable<Produtos> SelecionarTodos()
        {
            return new ProdutosRepositorio().SelecionarTodos().ToList();
        }

        
        public Produtos Selecionar(int id)
        {
            return new ProdutosRepositorio().Selecionar(id);
        }



        
        public IEnumerable<Produtos> SelecionarProduto(string filtro)
        {
            return new ProdutosRepositorio().SelecionarProduto(filtro).ToList();
        }


        
        public string Excluir(Produtos entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                _mensagem = new ProdutosRepositorio(contexto).Excluir(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

        
        public string Salvar(Produtos entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                if (entity.Id == 0)
                    _mensagem = new ProdutosRepositorio(contexto).Incluir(entity);
                else
                    _mensagem = new ProdutosRepositorio(contexto).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

    }
}
