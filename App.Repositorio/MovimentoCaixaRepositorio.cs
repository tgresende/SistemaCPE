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
    public class MovimentoCaixaRepositorio : IPadraoRepositorio<MovimentoCaixa>
    {
        private IRepositorio<MovimentoCaixa> _Repositorio;

        private AppContext _db = new AppContext();

        public MovimentoCaixaRepositorio(AppContext context = null)
        {
            _Repositorio = new Repositorio<MovimentoCaixa>(context == null ? new AppContext() : context);
        }

        public string Incluir(MovimentoCaixa entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Insert(entity);
            }
            return mensagem;
        }

        public string Alterar(MovimentoCaixa entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(MovimentoCaixa entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Delete(entity.Id);
            }
            return mensagem;
        }

        public MovimentoCaixa Selecionar(int id)
        {
            return _Repositorio.GetById(id);
        }

        public IQueryable<MovimentoCaixa> SelecionarTodos()
        {
            return _Repositorio.GetAll();
        }

        public IQueryable<MovimentoCaixa> Filtrar(string condicao)
        {
            return _Repositorio.Filter(condicao);
        }

        public string ValidarDados(MovimentoCaixa entity)
        {
            if (DateTime.MinValue == entity.Data)
                return "Favor informar a data do movimento";
            else if (entity.Valor == 0)
                return "Favor informar o Valor do Movimento";
            else if (string.IsNullOrWhiteSpace(entity.Descricao))
                return "Favor informar a descrição.";
            else if (entity.CreditoDebito == CreditoDebito.Nulo)
                return "Favor informar se a movimentação é um crédito ou débito";
            else
                return "";
        }

        public string ValidarExclusao(MovimentoCaixa entity)
        {
            return "";
        }
    }
}
