using Kitabxor.Application.Features.MediatorDesignPattern.Queries.LanguageQueries;
using Kitabxor.Application.Features.MediatorDesignPattern.Queries.LanguageResults;
using Kitabxor.Persistence.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Handlers.LanguageHandlers
{
    public class GetLanguageQueryHandler : IRequestHandler<GetLanguageQuery, List<GetLanguageQueryResult>>
    {
        private readonly KitabxorContext _context;
        public GetLanguageQueryHandler(KitabxorContext context)
        {
            _context = context;
        }
        public async Task<List<GetLanguageQueryResult>> Handle(GetLanguageQuery request, CancellationToken cancellationToken)
        {
           var values = await _context.Languages.ToListAsync();
            return values.Select(x => new GetLanguageQueryResult
            {
                LanguageId = x.LanguageId,
                LanguageName = x.LanguageName
            }).ToList();
        }
    }
}
