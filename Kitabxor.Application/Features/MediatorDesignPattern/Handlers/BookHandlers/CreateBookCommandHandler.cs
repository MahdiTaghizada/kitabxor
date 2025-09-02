using Kitabxor.Application.Features.MediatorDesignPattern.Commands.BookCommands;
using Kitabxor.Domain.Entities;
using Kitabxor.Persistence.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Handlers.BookHandlers
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand>
    {
        private readonly KitabxorContext _context;

        public CreateBookCommandHandler(KitabxorContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            await _context.Books.AddAsync(new Book
            {
                Title = request.Title,
                Description = request.Description,
                PublicationYear = request.PublicationYear,
                CoverImageUrl = request.CoverImageUrl,
                GoogleDriveFileId = request.GoogleDriveFileId,
                LanguageId = request.LanguageId,
                AuthorId = request.AuthorId,
                TagId = request.TagId,
                UploadedBy = request.UploadedBy,
                CreatedAt = DateTime.Now
            });
            await _context.SaveChangesAsync();
        }
    }
}
