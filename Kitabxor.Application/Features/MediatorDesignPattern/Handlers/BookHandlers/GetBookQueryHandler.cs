using Kitabxor.Application.Features.MediatorDesignPattern.Queries.BookQueries;
using Kitabxor.Application.Features.MediatorDesignPattern.Results.BookResults;
using Kitabxor.Domain.Entities;
using Kitabxor.Persistence.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Handlers.BookHandlers
{
    public class GetBookQueryHandler : IRequestHandler<GetBookQuery, List<GetBookQueryResult>>
    {
        private readonly KitabxorContext _context;

        public GetBookQueryHandler(KitabxorContext context)
        {
            _context = context;
        }

        public async Task<List<GetBookQueryResult>> Handle(GetBookQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Books.ToListAsync();
            return values.Select(x => new GetBookQueryResult
            {

                Title = x.Title,
                Description = x.Description,
                PublicationYear = x.PublicationYear,
                CoverImageUrl = x.CoverImageUrl,
                GoogleDriveFileId = x.GoogleDriveFileId,
                LanguageId = x.LanguageId,
                AuthorId = x.AuthorId,
                TagId = x.TagId,
                UploadedBy = x.UploadedBy,
                CreatedAt = x.CreatedAt
            }).ToList();
        }
    }
}
