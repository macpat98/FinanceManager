using FinanceManager.Infrastructure.Database;
using FinanceManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.ViewModels
{
    internal class OverviewViewModel: INotifyPropertyChanged
    {
        private string _tekscik = "Hello World!";
        private readonly TransactionContext _context = new TransactionContext();
        public event PropertyChangedEventHandler PropertyChanged;
        public string Tekscik
        {
            get { return _tekscik; }
            set
            {
                _tekscik = value;
                OnPropertyChanged();
            }
        }
        public Overview Overview { get; set; } = new Overview();
        public OverviewViewModel()
        {
            Trace.WriteLine("HEY");

            _context.Database.EnsureCreated();
            //_context.Transactions.Load();
            _context.Transactions.Add(new Transaction { Amount = 100, Description = "Test", Date = DateTime.Now });
            _context.SaveChanges();
            _context.Dispose();
        }

        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
