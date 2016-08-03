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
    public class UsuariosRepositorio : IPadraoRepositorio<Usuarios>
    {
        private IRepositorio<Usuarios> _Repositorio;

        private AppContext _db = new AppContext();

        public UsuariosRepositorio(AppContext context = null)
        {
            _Repositorio = new Repositorio<Usuarios>(context == null ? new AppContext() : context);
        }

        public string Incluir(Usuarios entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(Usuarios entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(Usuarios entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Delete(entity.Id);
            }
            return mensagem;
        }

        public Usuarios Selecionar(int id)
        {
            return _Repositorio.GetById(id);
        }


        public IQueryable<Usuarios> SelecionarTodos()
        {
            return _Repositorio.GetAll();
        }

        public IQueryable<Usuarios> Filtrar(string condicao)
        {
            return _Repositorio.Filter(condicao);
        }

        public string ValidarDados(Usuarios entity)
        {
            //verificacao de dados
            if (entity.PessoaId == 0)
                return "Favor informar a pessoa.";
            else if (string.IsNullOrWhiteSpace(entity.Senha))
                return "Favor informar a senha.";
            else
                return "";
        }

        public string ValidarExclusao(Usuarios entity)
        {
            //    from q in _db.Pessoas where q.Usuarios = en
            return "";
        }
    }
}
