using App.Dominio;
using App.InfraEstrutura.Configuracao;
using App.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;


namespace App.Servico.Controllers
{
    public class PessoasController 
    {
        private string _mensagem = "";

        
        public IEnumerable<Pessoas> Filtrar(string condicao)
        {
            return new PessoasRepositorio().Filtrar(condicao).ToList();
        }

        
        public IEnumerable<Pessoas> SelecionarTodos()
        {
            return new PessoasRepositorio().SelecionarTodos().ToList();
        }

        
        public Pessoas Selecionar(int id)
        {
            return new PessoasRepositorio().Selecionar(id);
        }

        
        public IEnumerable<Pessoas> SelecionarPessoa(string filtro)
        {
            return new PessoasRepositorio().SelecionarPessoa(filtro).ToList();
        }

        
        public string Excluir(Pessoas entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                _mensagem = new PessoasRepositorio(contexto).Excluir(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

        
        public string Salvar(Pessoas entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                if (entity.Id == 0)
                    _mensagem = new PessoasRepositorio(contexto).Incluir(entity);
                else
                    _mensagem = new PessoasRepositorio(contexto).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

    }
}
