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
    public class GastosRepositorio : IPadraoRepositorio<Gastos>
    {
        private IRepositorio<Gastos> _Repositorio;

        private AppContext _db = new AppContext();

        public GastosRepositorio(AppContext context = null)
        {
            _Repositorio = new Repositorio<Gastos>(context == null ? new AppContext() : context);
        }

        public IQueryable<GastosProjetosGastos> SelecionarGastos(string filtro)
        {
            return (from p in _db.GastosProjetos
                    join g in _db.Gastos on p.GastoId equals g.Id
                    select new GastosProjetosGastos{                    
                    GastoId = p.GastoId,
                    Observacao = p.Observacao,
                    ProjetosId = p.ProjetosId,
                    QuantidadePrevista = p.QuantidadePrevista,
                    QuantidadeReal = p.QuantidadeReal,
                    ValorUnitarioPrevisto = p.ValorUnitarioPrevisto,
                    ValorUnitarioReal = p.ValorUnitarioReal,
                    Descricao = g.Descricao
                    }).Where(filtro);
        }


        public string Incluir(Gastos entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(Gastos entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(Gastos entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Delete(entity.Id);
            }
            return mensagem;
        }

        public Gastos Selecionar(int id)
        {
            return _Repositorio.GetById(id);
        }

        public IQueryable<Gastos> SelecionarTodos()
        {
            return _Repositorio.GetAll();
        }

        public IQueryable<Gastos> Filtrar(string condicao)
        {
            return _Repositorio.Filter(condicao);
        }

        public string ValidarDados(Gastos entity)
        {
            return "";
        }

        public string ValidarExclusao(Gastos entity)
        {
            return "";
        }
    }
}
