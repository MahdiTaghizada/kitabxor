using Kitabxor.Application.Features.MediatorDesignPattern.Queries.TagQueries;
using Kitabxor.Application.Features.MediatorDesignPattern.Results.TagResults;
using Kitabxor.Persistence.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Handlers.TagHandlers
{
    public class GetTagQueryHandler : IRequestHandler<GetTagQuery, List<GetTagQueryResult>>
    {
        private readonly KitabxorContext _context;
        public GetTagQueryHandler(KitabxorContext context)
        {
            _context = context;
        }
        public async Task<List<GetTagQueryResult>> Handle(GetTagQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Tags.ToListAsync();
            return values.Select(x => new GetTagQueryResult
            {
                TagId = x.TagId,
                TagName = x.TagName,
                CreatedAt = x.CreatedAt
            }).ToList();
        }
    }
}
