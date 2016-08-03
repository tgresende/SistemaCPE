using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.InfraEstrutura.Configuracao
{
    public class AppContextInitializer : 
        CreateDatabaseIfNotExists<AppContext>
    {
        protected override void Seed(AppContext context)
        {
            context.Cidades.Add(new Dominio.Cidade() { Nome = "Teste1", Estado = "Minas Gerais", SiglaEstado = "MG", CodigoIgbe = "123456" });
            context.Cidades.Add(new Dominio.Cidade() { Nome = "Teste2", Estado = "Minas Gerais", SiglaEstado = "MG", CodigoIgbe = "123456" });
            context.Cidades.Add(new Dominio.Cidade() { Nome = "Teste3", Estado = "Minas Gerais", SiglaEstado = "MG", CodigoIgbe = "123456" });
            context.Cidades.Add(new Dominio.Cidade() { Nome = "Teste4", Estado = "Minas Gerais", SiglaEstado = "MG", CodigoIgbe = "123456" });
        }
    }
}
