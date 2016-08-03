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
    public class FuncionariosController
    {
        private string _mensagem = "";


        public IEnumerable<Funcionarios> Filtrar(string condicao)
        {
            return new FuncionariosRepositorio().Filtrar(condicao).ToList();
        }


        public IEnumerable<Funcionarios> SelecionarTodos()
        {
            return new FuncionariosRepositorio().SelecionarTodos().ToList();
        }

        public Funcionarios Selecionar(int id)
        {
            return new FuncionariosRepositorio().Selecionar(id);
        }



        public string Excluir(Funcionarios entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                _mensagem = new FuncionariosRepositorio(contexto).Excluir(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }


        public string Salvar(Funcionarios entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                if (entity.Id == 0)
                    _mensagem = new FuncionariosRepositorio(contexto).Incluir(entity);
                else
                    _mensagem = new FuncionariosRepositorio(contexto).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

    }
}
