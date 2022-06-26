using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracking.Models.Entities
{
    public class RecurrentMovement : BaseMovement
    {
        public MovementType MovementType { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int DayInMonth { get; set; }

        public User User { get; set; }
    }
}
