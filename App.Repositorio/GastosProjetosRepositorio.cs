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
    public class GastosProjetosRepositorio : IPadraoRepositorio<GastosProjetos>
    {
        private IRepositorio<GastosProjetos> _Repositorio;

        private AppContext _db = new AppContext();

        public GastosProjetosRepositorio(AppContext context = null)
        {
            _Repositorio = new Repositorio<GastosProjetos>(context == null ? new AppContext() : context);
        }

        public IQueryable<GastosProjetosProjetos> SelecionarGastosProjetos(string filtro)
        {
            return (from p in _db.Projetos
             join g in _db.GastosProjetos on p.Id equals g.ProjetosId
             select new GastosProjetosProjetos {
                 NomeProjeto =  p.NomeProjeto,
                 GastoId = g.GastoId,
                 Observacao = g.Observacao,
                 ProjetosId = p.Id,
                 QuantidadePrevista = g.QuantidadePrevista,
                 QuantidadeReal = g.QuantidadeReal,
                 ResponsavelId = p.ResponsavelId,
                 ValorUnitarioPrevisto = g.ValorUnitarioPrevisto,
                 ValorUnitarioReal = g.ValorUnitarioReal
                 }).Where(filtro);
        }


        public string Incluir(GastosProjetos entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(GastosProjetos entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(GastosProjetos entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Delete(entity.Id);
            }
            return mensagem;
        }

        public GastosProjetos Selecionar(int id)
        {
            return _Repositorio.GetById(id);
        }

        public IQueryable<GastosProjetos> SelecionarTodos()
        {
            return _Repositorio.GetAll();
        }

        public IQueryable<GastosProjetos> Filtrar(string condicao)
        {
            return _Repositorio.Filter(condicao);
        }

        public string ValidarDados(GastosProjetos entity)
        {
            return "";
        }

        public string ValidarExclusao(GastosProjetos entity)
        {
            return "";
        }
    }
}
