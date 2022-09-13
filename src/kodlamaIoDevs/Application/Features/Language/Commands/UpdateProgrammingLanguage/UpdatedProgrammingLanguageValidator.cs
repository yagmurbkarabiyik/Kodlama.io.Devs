using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Language.Commands.UpdateProgrammingLanguage
{
    public class UpdatedProgrammingLanguageValidator : AbstractValidator<UpdateProgrammingLanguageCommand>
    {
        public UpdatedProgrammingLanguageValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MinimumLength(2); 
        }
    }
}
