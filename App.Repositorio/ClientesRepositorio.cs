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
    public class ClientesRepositorio : IPadraoRepositorio<Clientes>
    {
        private IRepositorio<Clientes> _Repositorio;

        private AppContext _db = new AppContext();

        public ClientesRepositorio(AppContext context = null)
        {
            _Repositorio = new Repositorio<Clientes>(context == null ? new AppContext() : context);
        }

        public string Incluir(Clientes entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(Clientes entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(Clientes entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Delete(entity.Id);
            }
            return mensagem;
        }

        public Clientes Selecionar(int id)
        {
            return _Repositorio.GetById(id);
        }


        public IQueryable<Clientes> SelecionarTodos()
        {
            return _Repositorio.GetAll();
        }

        public IQueryable<Clientes> Filtrar(string condicao)
        {
            return _Repositorio.Filter(condicao);
        }

        public string ValidarDados(Clientes entity)
        {
            //verificacao de dados
            if (entity.PessoaId == 0)
                return "Favor informar a Pessoa.";
            else
                return "";
        }

        public string ValidarExclusao(Clientes entity)
        {
            //    from q in _db.Pessoas where q.Clientes = en
            return "";
        }
    }
}
