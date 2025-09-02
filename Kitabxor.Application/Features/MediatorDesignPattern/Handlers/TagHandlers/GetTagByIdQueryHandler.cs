using Kitabxor.Application.Features.MediatorDesignPattern.Queries.TagQueries;
using Kitabxor.Application.Features.MediatorDesignPattern.Results.TagResults;
using Kitabxor.Persistence.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Handlers.TagHandlers
{
    public class GetTagByIdQueryHandler : IRequestHandler<GetTagByIdQuery, GetTagByIdQueryResult>
    {
        private readonly KitabxorContext _context;
        public GetTagByIdQueryHandler(KitabxorContext context)
        {
            _context = context;
        }
        public async Task<GetTagByIdQueryResult> Handle(GetTagByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Tags.FindAsync(request.TagId);
            return new GetTagByIdQueryResult
            {
                TagId = values.TagId,
                TagName = values.TagName,
                CreatedAt = values.CreatedAt
            };
        }
    }
}
