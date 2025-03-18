using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Models
{
    internal class Overview
    {
        public decimal Income { get; set; }
        public decimal Expense { get; set; }
        public decimal Total { get { return Income - Expense; } }
    }
}
