using Kitabxor.Application.Features.MediatorDesignPattern.Queries.AuthorQueries;
using Kitabxor.Application.Features.MediatorDesignPattern.Results.AuthorResults;
using Kitabxor.Persistence.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Handlers.AuthorHandlers
{
    public class GetAuthorQueryHandler : IRequestHandler<GetAuthorQuery, List<GetAuthorQueryResult>>
    {
        private readonly KitabxorContext _context;
        public GetAuthorQueryHandler(KitabxorContext context)
        {
            _context = context;
        }
        public async  Task<List<GetAuthorQueryResult>> Handle(GetAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Authors.ToListAsync();
            return values.Select(x => new GetAuthorQueryResult
            {
                AuthorId = x.AuthorId,
                AuthorName = x.AuthorName,
                Biography = x.Biography,
                CreatedAt = x.CreatedAt
            }).ToList();
        }
    }
}
