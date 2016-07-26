using System.Data;
using System.Data.Entity;

namespace App.InfraEstrutura.Configuracao
{
    public class AppTransaction
    {
        public AppTransaction()
        {

        }
        public static DbContextTransaction CreateDbContextTransaction(AppContext db)
        {
            return db.Database.BeginTransaction(IsolationLevel.ReadUncommitted);
        }
    }
}
