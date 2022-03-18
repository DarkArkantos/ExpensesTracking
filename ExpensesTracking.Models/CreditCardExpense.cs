using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracking.Models
{
    public class CreditCardExpense
    {
        public CreditCard CreditCard { get; set; }
        public Expense Expense { get; set; }
        public int Installments { get; set; }
        public bool Paid { get; set; }
    }
}
