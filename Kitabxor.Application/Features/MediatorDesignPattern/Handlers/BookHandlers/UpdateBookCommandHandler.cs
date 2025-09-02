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
    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand>
    {
        private readonly KitabxorContext _context;

        public UpdateBookCommandHandler(KitabxorContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Books.FindAsync(request.BookId);
            values.Title = request.Title;
            values.Description = request.Description;
            values.PublicationYear = request.PublicationYear;
            values.CoverImageUrl = request.CoverImageUrl;
            values.GoogleDriveFileId = request.GoogleDriveFileId;
            values.LanguageId = request.LanguageId;
            values.AuthorId = request.AuthorId;
            values.TagId = request.TagId;
            values.UploadedBy = request.UploadedBy;
            values.CreatedAt = DateTime.Now;
            await _context.SaveChangesAsync();
        }
    }
}
