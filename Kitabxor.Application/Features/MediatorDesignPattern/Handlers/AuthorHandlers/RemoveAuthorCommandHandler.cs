using Kitabxor.Application.Features.MediatorDesignPattern.Commands.AuthorCommands;
using Kitabxor.Persistence.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Handlers.AuthorHandlers
{
    public class RemoveAuthorCommandHandler : IRequestHandler<RemoveAuthorCommand>
    {
        private readonly KitabxorContext _context;
        public RemoveAuthorCommandHandler(KitabxorContext context)
        {
            _context = context;
        }
        public async Task Handle(RemoveAuthorCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Authors.FindAsync(request.AuthorId);
            _context.Authors.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
