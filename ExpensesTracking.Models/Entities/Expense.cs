using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracking.Models.Entities
{
    public class Expense : BaseMovement
    {
        public bool PaidWithCreditCard { get; set; }
    }
}
