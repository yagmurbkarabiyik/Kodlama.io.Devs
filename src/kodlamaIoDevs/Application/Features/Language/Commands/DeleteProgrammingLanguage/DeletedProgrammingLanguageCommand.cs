using Application.Features.Language.Dtos;
using Application.Features.Language.Rules;
using Application.Services.Repositories;
using Domain.Entities;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Language.Commands.DeleteProgrammingLanguage
{
    public class DeletedProgrammingLanguageCommand : IRequest<DeleteProgrammingLanguageDto>
    {
        public int Id { get; set; }

        public class DeleteProgrammingLanguageCommandHandler : IRequestHandler<DeletedProgrammingLanguageCommand, DeleteProgrammingLanguageDto>
        {
            private readonly IProgrammingLanguageRepository _programmingLanguageRepository;
            private readonly IMapper _mapper;
            private readonly ProgrammingLanguageBusinessRules _programmingLanguageBusinessRules;

            public DeleteProgrammingLanguageCommandHandler(IProgrammingLanguageRepository programmingLanguageRepository, IMapper mapper, ProgrammingLanguageBusinessRules programmingLanguageBusinessRules)
            {
                _programmingLanguageRepository = programmingLanguageRepository;
                _mapper = mapper;
                _programmingLanguageBusinessRules = programmingLanguageBusinessRules;
            }

            public async Task<DeleteProgrammingLanguageDto> Handle(DeletedProgrammingLanguageCommand request, CancellationToken cancellationToken)
            {
                var programmingLanguage = await _programmingLanguageRepository.GetAsync(p => p.Id == request.Id);

                _programmingLanguageBusinessRules.ProgrammingLanguageShouldExistWhenRequested(programmingLanguage);

                ProgrammingLanguage deletedProgrammingLanguage = await _programmingLanguageRepository.DeleteAsync(programmingLanguage);
                DeleteProgrammingLanguageDto mappedDeletedProgrammingLanguageDto = _mapper.Map<DeleteProgrammingLanguageDto>(deletedProgrammingLanguage);
                return mappedDeletedProgrammingLanguageDto;
            }

           
        }
    }
}