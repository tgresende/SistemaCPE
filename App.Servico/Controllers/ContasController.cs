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
    public class ContasController 
    {
        private string _mensagem = "";

        
        public IEnumerable<Contas> Filtrar(string condicao)
        {
            return new ContasRepositorio().Filtrar(condicao).ToList();
        }

        
        public IEnumerable<Contas> SelecionarTodos()
        {
            return new ContasRepositorio().SelecionarTodos().ToList();
        }

        public Contas Selecionar(int id)
        {
            return new ContasRepositorio().Selecionar(id);
        }

        public IEnumerable<ContasPessoas> SelecionarContasRel(string filtro)
        {
            return new ContasRepositorio().SelecionarContasRel(filtro).ToList();
        }


        public IEnumerable<Contas> SelecionarConta(string filtro)
        {
            return new ContasRepositorio().SelecionarConta(filtro).ToList();
        }


        public string Excluir(Contas entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                _mensagem = new ContasRepositorio(contexto).Excluir(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

        
        public string Salvar(Contas entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                if (entity.Id == 0)
                    _mensagem = new ContasRepositorio(contexto).Incluir(entity);
                else
                    _mensagem = new ContasRepositorio(contexto).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

    }
}
