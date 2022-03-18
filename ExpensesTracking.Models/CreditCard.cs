using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracking.Models
{
    public class CreditCard
    {
        public string Name { get; set; }
        public int Last4 { get; set; }
        public decimal Debt { get; set; }
        public float Tax { get; set; }
        public decimal Limit { get; set; }

        public List<CreditCardExpense> CreditCardExpenses { get; set; }
    }
}
