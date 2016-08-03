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
    public class RotinasController
    {
        private string _mensagem = "";


        public IEnumerable<Rotinas> Filtrar(string condicao)
        {
            return new RotinasRepositorio().Filtrar(condicao).ToList();
        }


        public IEnumerable<Rotinas> SelecionarTodos()
        {
            return new RotinasRepositorio().SelecionarTodos().ToList();
        }

        public Rotinas Selecionar(int id)
        {
            return new RotinasRepositorio().Selecionar(id);
        }



        public string Excluir(Rotinas entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                _mensagem = new RotinasRepositorio(contexto).Excluir(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }


        public string Salvar(Rotinas entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                if (entity.Id == 0)
                    _mensagem = new RotinasRepositorio(contexto).Incluir(entity);
                else
                    _mensagem = new RotinasRepositorio(contexto).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

    }
}
