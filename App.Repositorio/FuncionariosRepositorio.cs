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
    public class FuncionariosRepositorio : IPadraoRepositorio<Funcionarios>
    {
        private IRepositorio<Funcionarios> _Repositorio;

        private AppContext _db = new AppContext();

        public FuncionariosRepositorio(AppContext context = null)
        {
            _Repositorio = new Repositorio<Funcionarios>(context == null ? new AppContext() : context);
        }

        public string Incluir(Funcionarios entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(Funcionarios entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(Funcionarios entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Delete(entity.Id);
            }
            return mensagem;
        }

        public Funcionarios Selecionar(int id)
        {
            return _Repositorio.GetById(id);
        }


        public IQueryable<Funcionarios> SelecionarTodos()
        {
            return _Repositorio.GetAll();
        }

        public IQueryable<Funcionarios> Filtrar(string condicao)
        {
            return _Repositorio.Filter(condicao);
        }

        public string ValidarDados(Funcionarios entity)
        {
            //verificacao de dados
            if (entity.PessoaId == 0)
                return "Favor informar a Pessoa.";
            else
                return "";
        }

        public string ValidarExclusao(Funcionarios entity)
        {
            //    from q in _db.Pessoas where q.Funcionarios = en
            return "";
        }
    }
}
