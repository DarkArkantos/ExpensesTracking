using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracking.Models
{
    public class BaseMovement
    {

        /// <summary>
        /// Name of the purchase
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the item
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Value paid
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// Date where it ocurred
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Category of the item
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Tags to do post processing
        /// </summary>
        public string Tags { get; set; }
    }
}
