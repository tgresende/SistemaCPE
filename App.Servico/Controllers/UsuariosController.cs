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
    public class UsuariosController
    {
        private string _mensagem = "";


        public IEnumerable<Usuarios> Filtrar(string condicao)
        {
            return new UsuariosRepositorio().Filtrar(condicao).ToList();
        }


        public IEnumerable<Usuarios> SelecionarTodos()
        {
            return new UsuariosRepositorio().SelecionarTodos().ToList();
        }

        public Usuarios Selecionar(int id)
        {
            return new UsuariosRepositorio().Selecionar(id);
        }



        public string Excluir(Usuarios entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                _mensagem = new UsuariosRepositorio(contexto).Excluir(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }


        public string Salvar(Usuarios entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                if (entity.Id == 0)
                    _mensagem = new UsuariosRepositorio(contexto).Incluir(entity);
                else
                    _mensagem = new UsuariosRepositorio(contexto).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

    }
}
