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
    public class UsuarioAcessoController
    {
        private string _mensagem = "";


        public IEnumerable<UsuarioAcesso> Filtrar(string condicao)
        {
            return new UsuarioAcessoRepositorio().Filtrar(condicao).ToList();
        }


        public IEnumerable<UsuarioAcesso> SelecionarTodos()
        {
            return new UsuarioAcessoRepositorio().SelecionarTodos().ToList();
        }

        public UsuarioAcesso Selecionar(int id)
        {
            return new UsuarioAcessoRepositorio().Selecionar(id);
        }



        public string Excluir(UsuarioAcesso entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                _mensagem = new UsuarioAcessoRepositorio(contexto).Excluir(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }


        public string Salvar(UsuarioAcesso entity)
        {
            AppContext contexto = new AppContext();
            using (DbContextTransaction transacao = AppTransaction.CreateDbContextTransaction(contexto))
            {
                if (entity.Id == 0)
                    _mensagem = new UsuarioAcessoRepositorio(contexto).Incluir(entity);
                else
                    _mensagem = new UsuarioAcessoRepositorio(contexto).Alterar(entity);

                if (_mensagem == "")
                    transacao.Commit();
                else
                    transacao.Rollback();
            }
            return _mensagem;
        }

    }
}
