using ExpensesTracking.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracking.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        public EmploymentType EmploymentType { get; set; }
        public Currency LocalCurrency { get; set; }
        public List<Income> Incomes { get; set; }
        public List<Expense> Expenses { get; set; }
        public List<CreditCard> CreditCards { get; set; }
        public List<RecurrentMovement> RecurrentMovements { get; set; }
    }
}
