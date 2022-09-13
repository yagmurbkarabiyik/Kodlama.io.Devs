using Application.Features.Language.Dtos;
using Core.Persistence.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Language.Models
{
    public class ProgrammingLanguageListModel : BasePageableModel
    {
        public IList<ListedProgrammingLanguageDto> Items { get; set; }
    }
}
