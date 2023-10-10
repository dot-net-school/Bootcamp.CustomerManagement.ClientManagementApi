using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace ClientManagementApi.Application.Clients.Command.CreateClient


{
    public class CreateClientCommandValidator : AbstractValidator<CreateClientCommand>
    {
        public CreateClientCommandValidator()
        {
            RuleFor(u => u.FirstName)
                   .NotEmpty().WithMessage("this field is required")
                   .MaximumLength(50).WithMessage("first name must be less than 50");

            RuleFor(u => u.LastName)
                   .NotEmpty().WithMessage("this field is required")
                   .MaximumLength(80).WithMessage("last name must be less than 80");

        }
    }
}
