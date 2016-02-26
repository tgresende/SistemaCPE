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
    public class RiscosProjetosRepositorio : IPadraoRepositorio<RiscosProjetos>
    {
        private IRepositorio<RiscosProjetos> _Repositorio;

        private AppContext _db = new AppContext();

        public RiscosProjetosRepositorio(AppContext context = null)
        {
            _Repositorio = new Repositorio<RiscosProjetos>(context == null ? new AppContext() : context);
        }

        public IQueryable<RiscosProjetosProjetos> SelecionarRiscosProjetos(string filtro)
        {
            return (from p in _db.Projetos
                    join g in _db.RiscosProjetos on p.Id equals g.ProjetosId
                    select new RiscosProjetosProjetos
                    {
                        Descricao = g.Descricao,
                        Id = g.Id,
                        Impacto = g.Impacto,
                        Observacao = g.Observacao,
                        Previsto = g.Previsto,
                        Probabilidade = g.Probabilidade,
                        ProjetosId = g.ProjetosId,
                        RiscoId = g.RiscoId,
                        Score = g.Score
                    }).Where(filtro);
        }


        public string Incluir(RiscosProjetos entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(RiscosProjetos entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(RiscosProjetos entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Delete(entity.Id);
            }
            return mensagem;
        }

        public RiscosProjetos Selecionar(int id)
        {
            return _Repositorio.GetById(id);
        }

        public IQueryable<RiscosProjetos> SelecionarTodos()
        {
            return _Repositorio.GetAll();
        }

        public IQueryable<RiscosProjetos> Filtrar(string condicao)
        {
            return _Repositorio.Filter(condicao);
        }

        public string ValidarDados(RiscosProjetos entity)
        {
            return "";
        }

        public string ValidarExclusao(RiscosProjetos entity)
        {
            return "";
        }
    }
}
