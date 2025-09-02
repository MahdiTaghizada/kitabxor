using Kitabxor.Application.Features.MediatorDesignPattern.Queries.LanguageQueries;
using Kitabxor.Application.Features.MediatorDesignPattern.Queries.LanguageResults;
using Kitabxor.Persistence.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Handlers.LanguageHandlers
{
    public class GetLanguageByIdQueryHandler : IRequestHandler<GetLanguageByIdQuery, GetLanguageByIdQueryResult>
    {
        private readonly KitabxorContext _context;
        public GetLanguageByIdQueryHandler(KitabxorContext context)
        {
            _context = context;
        }

        public async Task<GetLanguageByIdQueryResult> Handle(GetLanguageByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Languages.FindAsync(request.LanguageId);
            return new GetLanguageByIdQueryResult
            {
                LanguageId = values.LanguageId,
                LanguageName = values.LanguageName
            };
        }
    }
}
