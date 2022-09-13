using Application.Features.Language.Dtos;
using Application.Features.Language.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Language.Queries
{
    public class GetByIdProgrammingLanguageQuery : IRequest<GetByIdProgrammingLanguageDto>
    {
        public int Id { get; set; }

        public class GetByIdProgrammingLanguageQueryHangler : IRequestHandler<GetByIdProgrammingLanguageQuery, GetByIdProgrammingLanguageDto>
        {
            private readonly IProgrammingLanguageRepository _programmingLanguageRepository;
            private readonly IMapper _mapper;
            private readonly ProgrammingLanguageBusinessRules _programmingLanguageBusinessRules;

            public GetByIdProgrammingLanguageQueryHangler(IProgrammingLanguageRepository programmingLanguageRepository, IMapper mapper, ProgrammingLanguageBusinessRules programmingLanguageBusinessRules)
            {
                _programmingLanguageRepository = programmingLanguageRepository;
                _mapper = mapper;
                _programmingLanguageBusinessRules = programmingLanguageBusinessRules;
            }

            public async Task<GetByIdProgrammingLanguageDto> Handle(GetByIdProgrammingLanguageQuery request, CancellationToken cancellationToken)
            {
                ProgrammingLanguage? programmingLanguage = await _programmingLanguageRepository.GetAsync(p => p.Id == request.Id);

                _programmingLanguageBusinessRules.ProgrammingLanguageShouldExistWhenRequested(programmingLanguage);

                GetByIdProgrammingLanguageDto mappedProgrammingLanguageGetByIdDto = _mapper.Map<GetByIdProgrammingLanguageDto>(programmingLanguage);
                return mappedProgrammingLanguageGetByIdDto;
            }
        }

    }
}
