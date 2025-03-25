using FinanceManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Infrastructure.Database
{
    public class TransactionContext: DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=financemanager.db");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
