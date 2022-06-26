using Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracking.Application.Fetures.Outcomes.Commands
{
    public class RegisterOutcomeCommand: IRequest<Response<int>>
    {
    }
}
