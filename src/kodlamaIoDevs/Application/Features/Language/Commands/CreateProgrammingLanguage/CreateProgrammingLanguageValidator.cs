using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Language.Commands.CreateProgrammingLanguage
{
    public class CreateProgrammingLanguageValidator : AbstractValidator<CreateProgrammingLanguageCommand>
    {
        public CreateProgrammingLanguageValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Name).MinimumLength(2);
        }
    }
}
