using Kitabxor.Application.Features.MediatorDesignPattern.Queries.AuthorQueries;
using Kitabxor.Application.Features.MediatorDesignPattern.Results.AuthorResults;
using Kitabxor.Persistence.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Handlers.AuthorHandlers
{
    public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQuery, GetAuthorByIdQueryResult>
    {
        private readonly KitabxorContext _context;
        public GetAuthorByIdQueryHandler(KitabxorContext context)
        {
            _context = context;
        }
        public async Task<GetAuthorByIdQueryResult> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Authors.FindAsync(request.AuthorId);
            return new GetAuthorByIdQueryResult
            {
                AuthorId = values.AuthorId,
                AuthorName = values.AuthorName,
                Biography = values.Biography,
                CreatedAt = values.CreatedAt
            };
        }
    }
}
