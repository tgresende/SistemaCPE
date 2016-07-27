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
    public class SaldoCaixaRepositorio : IPadraoRepositorio<SaldoCaixa>
    {
        private IRepositorio<SaldoCaixa> _Repositorio;

        private AppContext _db = new AppContext();

        public SaldoCaixaRepositorio(AppContext context = null)
        {
            _Repositorio = new Repositorio<SaldoCaixa>(context == null ? new AppContext() : context);
        }

        public string Incluir(SaldoCaixa entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(SaldoCaixa entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(SaldoCaixa entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Delete(entity.Id);
            }
            return mensagem;
        }

        public SaldoCaixa Selecionar(int id)
        {
            return _Repositorio.GetById(id);
        }

        public IQueryable<SaldoCaixa> SelecionarTodos()
        {
            return _Repositorio.GetAll();
        }

        public IQueryable<SaldoCaixa> Filtrar(string condicao)
        {
            return _Repositorio.Filter(condicao);
        }

        public string ValidarDados(SaldoCaixa entity)
        {
            return "";
        }

        public string ValidarExclusao(SaldoCaixa entity)
        {
            return "";
        }
    }
}
