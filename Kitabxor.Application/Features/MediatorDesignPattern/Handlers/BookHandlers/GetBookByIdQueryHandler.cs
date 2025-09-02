using Kitabxor.Application.Features.MediatorDesignPattern.Queries.BookQueries;
using Kitabxor.Application.Features.MediatorDesignPattern.Results.BookResults;
using Kitabxor.Application.Features.MediatorDesignPattern.Results.TagResults;
using Kitabxor.Persistence.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Handlers.BookHandlers
{
    public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, GetBookByIdQueryResult>
    {
        private readonly KitabxorContext _context;

        public GetBookByIdQueryHandler(KitabxorContext context)
        {
            _context = context;
        }

        public async Task<GetBookByIdQueryResult> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Books.FindAsync(request.BookId);
            return new GetBookByIdQueryResult
            {
                Title = values.Title,
                Description = values.Description,
                PublicationYear = values.PublicationYear,
                CoverImageUrl = values.CoverImageUrl,
                GoogleDriveFileId = values.GoogleDriveFileId,
                LanguageId =values.LanguageId,
                AuthorId = values.AuthorId,
                TagId = values.TagId,
                UploadedBy = values.UploadedBy,
                CreatedAt = values.CreatedAt
            };
        }
    }
}
