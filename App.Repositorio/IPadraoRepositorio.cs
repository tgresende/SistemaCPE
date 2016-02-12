﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Repositorio
{
    public interface IPadraoRepositorio<T> where T : class
    {
        string Incluir(T entity);
        string Alterar(T entity);
        string Excluir(T entity);
        T Selecionar(int id);
        IQueryable<T> SelecionarTodos();
        IQueryable<T> Filtrar(string condicao);
    }
}
