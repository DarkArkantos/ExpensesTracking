using Application.Wrappers;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExpensesTracking.Application.Enums;
using ExpensesTracking.Application.Fetures.Incomes.Commands;
using ExpensesTracking.Application.Fetures.Outcomes.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracking.ViewModels
{
    internal partial class RegisterExpenseViewModel: ObservableValidator
    {
        public RegisterExpenseViewModel(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        private string _description;

        [ObservableProperty]
        private decimal _value;

        [ObservableProperty]
        private Category _category;

        [ObservableProperty]
        private ExpenseType _expenseType;

        private readonly IMediator _mediator;


        [RelayCommand]
        Task SaveExpense()
        {
            IRequest<Response<int>> request = _expenseType switch
            {
                ExpenseType.Income => CreateIncomeCommand(),
                ExpenseType.Outcome => CreateOutcomeCommand(),
                _ => throw new ArgumentOutOfRangeException(),
            };

            _mediator.Send(request);
            return Task.CompletedTask;
        }


        private RegisterIncomeCommand CreateIncomeCommand()
        {
            return new RegisterIncomeCommand();
        }

        private RegisterOutcomeCommand CreateOutcomeCommand()
        {
            return new RegisterOutcomeCommand();
        }
    }
}
