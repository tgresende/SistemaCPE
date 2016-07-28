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
    public class ProdutosInsumosRepositorio : IPadraoRepositorio<ProdutosInsumos>
    {
        private IRepositorio<ProdutosInsumos> _Repositorio;

        private AppContext _db = new AppContext();

        public ProdutosInsumosRepositorio(AppContext context = null)
        {
            _Repositorio = new Repositorio<ProdutosInsumos>(context == null ? new AppContext() : context);
        }

        public string Incluir(ProdutosInsumos entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(ProdutosInsumos entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(ProdutosInsumos entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Delete(entity.Id);
            }
            return mensagem;
        }

        public ProdutosInsumos Selecionar(int id)
        {
            return _Repositorio.GetById(id);
        }

       


        public IQueryable<ProdutosInsumos> SelecionarTodos()
        {
            return _Repositorio.GetAll();
        }

        public IQueryable<ProdutosInsumos> Filtrar(string condicao)
        {
            return _Repositorio.Filter(condicao);
        }

        public string ValidarDados(ProdutosInsumos entity)
        {
            //verificacao de dados

            if (entity.ProdutoId == 0)
                return "Favor informar o produto.";
            else if (entity.InsumoId == 0)
                return "Favor informar o insumo.";
            else if (entity.Quantidade == 0)
                return "Favor informar a quantidade.";
            else
                return "";
        }

        public string ValidarExclusao(ProdutosInsumos entity)
        {
            return "";
        }
    }
}
