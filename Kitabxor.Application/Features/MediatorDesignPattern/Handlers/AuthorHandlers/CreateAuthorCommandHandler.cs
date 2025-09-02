using Kitabxor.Application.Features.MediatorDesignPattern.Commands.AuthorCommands;
using Kitabxor.Domain.Entities;
using Kitabxor.Persistence.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Handlers.AuthorHandlers
{
    public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommand>
    {
        private readonly KitabxorContext _context;
        public CreateAuthorCommandHandler(KitabxorContext context)
        {
            _context = context;
        }
        public async Task Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Authors.AddAsync(new Author
            {
                AuthorName = request.AuthorName,
                Biography = request.Biography,
                CreatedAt = DateTime.Now
            }); await _context.SaveChangesAsync();
        }
    }
}
