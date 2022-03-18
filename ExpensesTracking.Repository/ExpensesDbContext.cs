using ExpensesTracking.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracking.Repository
{
    public class ExpensesDbContext: DbContext
    {

        public ExpensesDbContext(DbContextOptions<ExpensesDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<CreditCard> CreditCards{ get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<RecurrentMovement> RecurrentMovements { get; set; }
        public DbSet<CreditCardExpense> CreditCardExpenses { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
