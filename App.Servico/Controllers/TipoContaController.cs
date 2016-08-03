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
    public class TipoContaController
    {
        private string _mensagem = "";


        public IEnumerable<TipoConta> Filtrar(string condicao)
        {
            return new TipoContaRepositorio().Filtrar(condicao).ToList();
        }


        public IEnumerable<TipoConta> SelecionarTodos()
        {
            return new TipoContaRepositorio().SelecionarTodos().ToList();
        }

        public TipoConta Selecionar(int id)
        {
            return new TipoContaRepositorio().Selecionar(id);
        }



        public string Excluir(TipoConta entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                _mensagem = new TipoContaRepositorio(contexto).Excluir(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }


        public string Salvar(TipoConta entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                if (entity.Id == 0)
                    _mensagem = new TipoContaRepositorio(contexto).Incluir(entity);
                else
                    _mensagem = new TipoContaRepositorio(contexto).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

    }
}
