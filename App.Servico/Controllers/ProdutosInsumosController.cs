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
    public class ProdutosInsumosController 
    {
        private string _mensagem = "";

        
        public IEnumerable<ProdutosInsumos> Filtrar(string condicao)
        {
            return new ProdutosInsumosRepositorio().Filtrar(condicao).ToList();
        }

        
        public IEnumerable<ProdutosInsumos> SelecionarTodos()
        {
            return new ProdutosInsumosRepositorio().SelecionarTodos().ToList();
        }

        
        public ProdutosInsumos Selecionar(int id)
        {
            return new ProdutosInsumosRepositorio().Selecionar(id);
        }

      
       


        
        public string Excluir(ProdutosInsumos entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                _mensagem = new ProdutosInsumosRepositorio(contexto).Excluir(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

        
        public string Salvar(ProdutosInsumos entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                if (entity.Id == 0)
                    _mensagem = new ProdutosInsumosRepositorio(contexto).Incluir(entity);
                else
                    _mensagem = new ProdutosInsumosRepositorio(contexto).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

    }
}
