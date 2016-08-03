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
    public class UnidadesController
    {
        private string _mensagem = "";


        public IEnumerable<Unidades> Filtrar(string condicao)
        {
            return new UnidadesRepositorio().Filtrar(condicao).ToList();
        }


        public IEnumerable<Unidades> SelecionarTodos()
        {
            return new UnidadesRepositorio().SelecionarTodos().ToList();
        }

        public Unidades Selecionar(int id)
        {
            return new UnidadesRepositorio().Selecionar(id);
        }



        public string Excluir(Unidades entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                _mensagem = new UnidadesRepositorio(contexto).Excluir(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }


        public string Salvar(Unidades entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                if (entity.Id == 0)
                    _mensagem = new UnidadesRepositorio(contexto).Incluir(entity);
                else
                    _mensagem = new UnidadesRepositorio(contexto).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

    }
}
