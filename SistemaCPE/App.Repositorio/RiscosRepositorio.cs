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
    public class RiscosRepositorio : IPadraoRepositorio<Riscos>
    {
        private IRepositorio<Riscos> _Repositorio;

        private AppContext _db = new AppContext();

        public RiscosRepositorio(AppContext context = null)
        {
            _Repositorio = new Repositorio<Riscos>(context == null ? new AppContext() : context);
        }

        public IQueryable<RiscosProjetosRiscos> SelecionarRiscos(string filtro)
        {
            return (from p in _db.RiscosProjetos
                    join g in _db.Riscos on p.RiscoId equals g.Id
                    select new RiscosProjetosRiscos
                    {
                        Id = p.Id,
                        Descricao = p.Descricao,
                        DescricaoRiscos = g.Descricao,
                        Impacto = p.Impacto,
                        MedidaPreventiva = g.MedidaPreventiva,
                        Nome = g.Nome,
                        Observacao = p.Observacao,
                        PlanoContigencia = g.PlanoContigencia,
                        Previsto = p.Previsto,
                        Probabilidade = p.Probabilidade,
                        ProjetosId = p.ProjetosId,
                        RiscoId = p.RiscoId,
                        Score = p.Score
                    }).Where(filtro);
        }


        public string Incluir(Riscos entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(Riscos entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(Riscos entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Delete(entity.Id);
            }
            return mensagem;
        }

        public Riscos Selecionar(int id)
        {
            return _Repositorio.GetById(id);
        }

        public IQueryable<Riscos> SelecionarTodos()
        {
            return _Repositorio.GetAll();
        }

        public IQueryable<Riscos> Filtrar(string condicao)
        {
            return _Repositorio.Filter(condicao);
        }

        public string ValidarDados(Riscos entity)
        {
            return "";
        }

        public string ValidarExclusao(Riscos entity)
        {
            return "";
        }
    }
}
