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
    public class ProdutosRepositorio : IPadraoRepositorio<Produtos>
    {
        private IRepositorio<Produtos> _Repositorio;

        private AppContext _db = new AppContext();

        public ProdutosRepositorio(AppContext context = null)
        {
            _Repositorio = new Repositorio<Produtos>(context == null ? new AppContext() : context);
        }

        public string Incluir(Produtos entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(Produtos entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(Produtos entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Delete(entity.Id);
            }
            return mensagem;
        }

        public Produtos Selecionar(int id)
        {
            return _Repositorio.GetById(id);
        }

        public IQueryable<Produtos> SelecionarProduto(string filtro)
        {
            return (from p in _db.Produtos
                    select p).Where(filtro);
        }


        public IQueryable<Produtos> SelecionarTodos()
        {
            return _Repositorio.GetAll();
        }

        public IQueryable<Produtos> Filtrar(string condicao)
        {
            return _Repositorio.Filter(condicao);
        }

        public string ValidarDados(Produtos entity)
        {
            //verificacao de dados
            if (string.IsNullOrWhiteSpace(entity.Nome))
                return "Favor informar o nome do produto.";
            else if (entity.Peso == 0)
                return "Favor informar o peso do produto.";
            else if (string.IsNullOrWhiteSpace(entity.Unidade))
                return "Favor informar a unidade do produto.";
            else
                return "";
        }

        public string ValidarExclusao(Produtos entity)
        {
            return "";
        }
    }
}
