﻿using App.Dominio;
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
            else if (string.IsNullOrWhiteSpace(entity.PagarReceber))
                return "Favor informar se a conta é à pagar ou receber.";
            else if (entity.PessoaId == 0)
                return "Favor informar a pessoa referenciada a essa conta.";
            if (string.IsNullOrWhiteSpace(entity.Quitado))
                return "Favor informar se a conta foi quitada.";
            else
                return "";
        }

        public string ValidarExclusao(Contas entity)
        {
            return "";
        }
    }
}
