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
    public class FornecedoresRepositorio : IPadraoRepositorio<Fornecedores>
    {
        private IRepositorio<Fornecedores> _Repositorio;

        private AppContext _db = new AppContext();

        public FornecedoresRepositorio(AppContext context = null)
        {
            _Repositorio = new Repositorio<Fornecedores>(context == null ? new AppContext() : context);
        }

        public string Incluir(Fornecedores entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(Fornecedores entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(Fornecedores entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Delete(entity.Id);
            }
            return mensagem;
        }

        public Fornecedores Selecionar(int id)
        {
            return _Repositorio.GetById(id);
        }


        public IQueryable<Fornecedores> SelecionarTodos()
        {
            return _Repositorio.GetAll();
        }

        public IQueryable<Fornecedores> Filtrar(string condicao)
        {
            return _Repositorio.Filter(condicao);
        }

        public string ValidarDados(Fornecedores entity)
        {
            //verificacao de dados
            if (entity.PessoaId == 0)
                return "Favor informar a Pessoa.";
            else
                return "";
        }

        public string ValidarExclusao(Fornecedores entity)
        {
            //    from q in _db.Pessoas where q.Fornecedores = en
            return "";
        }
    }
}
