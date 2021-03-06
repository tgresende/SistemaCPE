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
    public class PessoasRepositorio : IPadraoRepositorio<Pessoas>
    {
        private IRepositorio<Pessoas> _Repositorio;

        private AppContext _db = new AppContext();

        public PessoasRepositorio(AppContext context = null)
        {
            _Repositorio = new Repositorio<Pessoas>(context == null ? new AppContext() : context);
        }

        public string Incluir(Pessoas entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Insert(entity);
            }
            return mensagem;
        }

        public IQueryable<Pessoas> SelecionarPessoa(string filtro)
        {
            return (from p in _db.Pessoas
                    select p).Where(filtro);
        }

        public string Alterar(Pessoas entity)
        {
            string mensagem = this.ValidarDados(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Update(entity);
            }
            return mensagem;
        }

        public string Excluir(Pessoas entity)
        {
            string mensagem = this.ValidarExclusao(entity);
            if (mensagem == "")
            {
                mensagem = _Repositorio.Delete(entity.Id);
            }
            return mensagem;
        }

        public Pessoas Selecionar(int id)
        {
            return _Repositorio.GetById(id);
        }

        public IQueryable<Pessoas> SelecionarTodos()
        {
            return _Repositorio.GetAll();
        }

        public IQueryable<Pessoas> Filtrar(string condicao)
        {
            return _Repositorio.Filter(condicao);
        }

        public string ValidarDados(Pessoas entity)
        {
            if (string.IsNullOrWhiteSpace(entity.Nome))
                return "Favor informar o nome da pessoa.";
            else if (!Library.Rotinas.ValidaCpfCnpj(entity.CPFCNPJ))
            {
                return string.Format("Favor informar um {0} válido.", entity.TipoDocumento == TipoDocumentoPessoa.Cpf ? "CPF " : "CNPJ");
            }
            return "";
        }

        public string ValidarExclusao(Pessoas entity)
        {
            return "";
        }
    }
}
