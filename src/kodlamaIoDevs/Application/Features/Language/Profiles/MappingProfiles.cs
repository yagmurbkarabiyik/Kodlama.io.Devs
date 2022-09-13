using Application.Features.Language.Commands.CreateProgrammingLanguage;
using Application.Features.Language.Commands.DeleteProgrammingLanguage;
using Application.Features.Language.Commands.UpdateProgrammingLanguage;
using Application.Features.Language.Dtos;
using Application.Features.Language.Models;
using Application.Features.Language.Queries;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Language.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<ProgrammingLanguage, CreatedProgrammingLanguageDto>().ReverseMap();
            CreateMap<ProgrammingLanguage, CreateProgrammingLanguageCommand>().ReverseMap();

            CreateMap<IPaginate<ProgrammingLanguage>, ProgrammingLanguageListModel>().ReverseMap();
            CreateMap<ProgrammingLanguage, ListedProgrammingLanguageDto>().ReverseMap();

            CreateMap<ProgrammingLanguage, UpdatedProgrammingLanguageDto>().ReverseMap();
            CreateMap<ProgrammingLanguage, UpdateProgrammingLanguageCommand>().ReverseMap();

            CreateMap<ProgrammingLanguage, DeleteProgrammingLanguageDto>().ReverseMap();
            CreateMap<ProgrammingLanguage, DeletedProgrammingLanguageCommand>().ReverseMap();

            CreateMap<ProgrammingLanguage, GetByIdProgrammingLanguageDto>().ReverseMap();
            CreateMap<ProgrammingLanguage, GetByIdProgrammingLanguageQuery>().ReverseMap();
        }
    }
}
