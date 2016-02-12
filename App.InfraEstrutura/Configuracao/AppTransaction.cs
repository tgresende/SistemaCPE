using App.Infrastructura;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace App.Infrastructure
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
