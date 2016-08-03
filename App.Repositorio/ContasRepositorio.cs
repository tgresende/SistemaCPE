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
    public class ContasRepositorio : IPadraoRepositorio<Contas>
    {
        private IRepositorio<Contas> _Repositorio;

        private AppContext _db = new AppContext();

        public ContasRepositorio(AppContext context = null)
        {
            _Repositorio = new Repositorio<Contas>(context == null ? new AppContext() : context);
        }

        public string Incluir(Contas entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(Contas entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(Contas entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Delete(entity.Id);
            }
            return mensagem;
        }

        public Contas Selecionar(int id)
        {
            return _Repositorio.GetById(id);
        }

        public IQueryable<Contas> SelecionarConta(string filtro)
        {
            return (from p in _db.Contas
                    select p).Where(filtro);
        }


        public IQueryable<ContasPessoas> SelecionarContasRel(string filtro)
        {
            return (from p in _db.Contas
                    join g in _db.Pessoas on p.PessoaId equals g.Id
                    select new ContasPessoas
                    {
                        Id = p.Id,
                        Valor = p.Valor,
                        DataVencimento = p.DataVencimento,
                        ContaId = p.Id,
                        Nome = g.Nome,
         //               PagarReceber = p.PagarReceber,
                        DescricaoConta = p.Descricao
                    }).Where(filtro);
        }

        public IQueryable<Contas> SelecionarTodos()
        {
            return _Repositorio.GetAll();
        }

        public IQueryable<Contas> Filtrar(string condicao)
        {
            return _Repositorio.Filter(condicao);
        }

        public string ValidarDados(Contas entity)
        {
            //verificacao de dados
            if (string.IsNullOrWhiteSpace(entity.Descricao))
                return "Favor informar a descrição da conta.";
            else if (entity.Valor == 0)
                return "Favor informar o valor da conta.";
            else if (entity.DataEmissao == DateTime.MinValue)
                return "Favor informar a data de emissão.";
            else if (entity.DataVencimento == DateTime.MinValue)
                return "Favor informar a data de vencimento.";
            else if (entity.PessoaId == 0)
                return "Favor informar a pessoa referenciada a essa conta.";
            else
                return "";
        }

        public string ValidarExclusao(Contas entity)
        {
            return "";
        }
    }
}
