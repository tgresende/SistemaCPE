using App.Dominio;
using App.DTO;
using App.InfraEstrutura.Configuracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Text;

namespace App.Repositorio
{
    public class UsuarioAcessoRepositorio : IPadraoRepositorio<UsuarioAcesso>
    {
        private IRepositorio<UsuarioAcesso> _Repositorio;

        private AppContext _db = new AppContext();

        public UsuarioAcessoRepositorio(AppContext context = null)
        {
            _Repositorio = new Repositorio<UsuarioAcesso>(context == null ? new AppContext() : context);
        }

        public string Incluir(UsuarioAcesso entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(UsuarioAcesso entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(UsuarioAcesso entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Delete(entity.Id);
            }
            return mensagem;
        }

        public UsuarioAcesso Selecionar(int id)
        {
            return _Repositorio.GetById(id);
        }


        public IQueryable<UsuarioAcesso> SelecionarTodos()
        {
            return _Repositorio.GetAll();
        }

        public IQueryable<UsuarioAcesso> Filtrar(string condicao)
        {
            return _Repositorio.Filter(condicao);
        }

        public string ValidarDados(UsuarioAcesso entity)
        {
            //verificacao de dados
            if (entity.UsuarioId == 0)
                return "Favor informar o usuário.";
            else if (entity.RotinaId == 0)
                return "Favor informar a rotina.";
            else
                return "";
        }

        public string ValidarExclusao(UsuarioAcesso entity)
        {
            //    from q in _db.Pessoas where q.UsuarioAcesso = en
            return "";
        }
    }
}
