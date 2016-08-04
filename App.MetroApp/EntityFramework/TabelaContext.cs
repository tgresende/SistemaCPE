using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace App.MetroApp.EntityFramework
{
    public class TabelaContext : DbContext
    {
        public TabelaContext() : base("TabelaConnectionString")
        {
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
    }
}
