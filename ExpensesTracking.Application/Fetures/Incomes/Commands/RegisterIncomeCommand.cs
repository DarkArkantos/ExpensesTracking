using Application.Wrappers;
using ExpensesTracking.Application.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracking.Application.Fetures.Incomes.Commands
{
    public class RegisterIncomeCommand: IRequest<Response<int>>
    {

        /// <summary>
        /// Name of the purchase
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// Description of the item
        /// </summary>
        public string Description { get; set; } = "";

        /// <summary>
        /// Value paid
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// Currency in which this transaction ocurred
        /// </summary>
        public Currency Currency { get; set; }

        /// <summary>
        /// Conversion rate defined at the time of processing the transaction
        /// </summary>
        public decimal CurrencyConversion { get; set; }

        /// <summary>
        /// Value in the local currency.
        /// </summary>
        public decimal ValueInLocalCurrency => CurrencyConversion * Value;

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
