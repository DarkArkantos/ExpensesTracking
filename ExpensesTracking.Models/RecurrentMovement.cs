using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracking.Models
{
    public class RecurrentMovement: BaseMovement
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int DayInMonth { get; set; }
    }
}
