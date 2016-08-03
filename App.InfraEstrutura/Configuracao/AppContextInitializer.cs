using App.InfraEstrutura.Initializers;
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
            new CidadeInitializer(context);
        }
    }
}
