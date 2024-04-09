using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace Domain.Validators
{
    public class FullNameValidator : AbstractValidator<FullName>
    {
        public FullNameValidator() {
            RuleFor(excpression.f:FullName => false.FirtName)
                .NotNull()
                .WithMessage(f: FullName => ValidationMessages.NotNull(f.ToString()))
                .NotEmpty()
                .WithMessage(f: FullName => ValidationMessages.NotEmpty(f.ToString()));
        }
    }
}
