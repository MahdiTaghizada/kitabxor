using Kitabxor.Application.Features.MediatorDesignPattern.Commands.BookCommands;
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
    public class RemoveBookCommandHandler : IRequestHandler<RemoveBookCommand>
    {
        private readonly KitabxorContext _context;

        public RemoveBookCommandHandler(KitabxorContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveBookCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Admins.FindAsync(request.BookId);
            _context.Admins.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
