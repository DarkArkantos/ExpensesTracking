using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracking.Models.Entities
{
    public enum Category
    {
        /// <summary>
        /// Purchased related to entertainment, films, parks, etc.
        /// </summary>
        Entertainment,

        /// <summary>
        /// Payments related to transportation, Uber, Didi, SITP
        /// </summary>
        Transport,

        /// <summary>
        /// Expenses related to food, it includes groceries
        /// </summary>
        Food,

        /// <summary>
        /// Expenses related to health care
        /// </summary>
        Health,

        /// <summary>
        /// Expenses related to things I buy over internet or in stores
        /// </summary>
        Shopping,

        /// <summary>
        /// Money spent in church
        /// </summary>
        Church,

        /// <summary>
        /// Money spent in travelling
        /// </summary>
        Travel,

        /// <summary>
        /// Savings
        /// </summary>
        Savings,

        /// <summary>
        /// Money I have borrowed
        /// </summary>
        Debtors
    }
}
