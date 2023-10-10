using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementApi.Application.Clients.Queries.GetClinetForScoring
{
    public class GetClientForScoringValidator: AbstractValidator<GetClientForScoringQuery>
    {
        public GetClientForScoringValidator()
        {
            RuleFor(u => u.Id)
                .NotEmpty()
                .WithMessage("this field is Required");
        }
    }
}
