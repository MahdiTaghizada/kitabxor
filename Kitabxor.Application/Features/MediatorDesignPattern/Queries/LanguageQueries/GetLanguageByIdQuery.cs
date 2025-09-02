using Kitabxor.Application.Features.MediatorDesignPattern.Queries.LanguageResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Queries.LanguageQueries
{
    public class GetLanguageByIdQuery : IRequest<GetLanguageByIdQueryResult>
    {
        public int LanguageId { get; set; }
        public GetLanguageByIdQuery(int languageId)
        {
            LanguageId = languageId;
        }
    }
}
