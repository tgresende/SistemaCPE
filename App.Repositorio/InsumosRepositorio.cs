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
    public class InsumosRepositorio : IPadraoRepositorio<Insumos>
    {
        private IRepositorio<Insumos> _Repositorio;

        private AppContext _db = new AppContext();

        public InsumosRepositorio(AppContext context = null)
        {
            _Repositorio = new Repositorio<Insumos>(context == null ? new AppContext() : context);
        }

        public string Incluir(Insumos entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(Insumos entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(Insumos entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Delete(entity.Id);
            }
            return mensagem;
        }

        public Insumos Selecionar(int id)
        {
            return _Repositorio.GetById(id);
        }

        public IQueryable<Insumos> SelecionarInsumo(string filtro)
        {
            return (from p in _db.Insumos
                    select p).Where(filtro);
        }


        public IQueryable<InsumosProdutos> SelecionarInsumoPorProduto(string filtro)
        {
            return (from p in _db.ProdutosInsumos
                    join g in _db.Produtos on p.ProdutoId equals g.Id
                    join h in _db.Insumos on p.InsumoId equals h.Id
                    select new InsumosProdutos
                    {
                       Id = p.Id,
                       Nome = h.Nome,
                       Descricao = h.Descricao,
                       Unidade = h.Unidade,
                       Valor = h.Valor,
                       Quantidade = p.Quantidade,
                       ProdutoId = g.Id,
                       InsumoId = h.Id
                    }).Where(filtro);
        }

        public IQueryable<Insumos> SelecionarTodos()
        {
            return _Repositorio.GetAll();
        }

        public IQueryable<Insumos> Filtrar(string condicao)
        {
            return _Repositorio.Filter(condicao);
        }

        public string ValidarDados(Insumos entity)
        {
            //verificacao de dados
            if (string.IsNullOrWhiteSpace(entity.Nome))
                return "Favor informar a descrição do insumo.";
            else if (entity.Valor == 0)
                return "Favor informar o valor do insumo.";
            else
                return "";
        }

        public string ValidarExclusao(Insumos entity)
        {
            return "";
        }
    }
}
