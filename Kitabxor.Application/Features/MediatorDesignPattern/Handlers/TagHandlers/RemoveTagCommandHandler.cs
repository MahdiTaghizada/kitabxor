using Kitabxor.Application.Features.MediatorDesignPattern.Commands.TagCommands;
using Kitabxor.Persistence.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Handlers.TagHandlers
{
    public class RemoveTagCommandHandler : IRequestHandler<RemoveTagCommand>
    {
        private readonly KitabxorContext _context;
        public RemoveTagCommandHandler(KitabxorContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveTagCommand request, CancellationToken cancellationToken)
        {
            var values= await _context.Tags.FindAsync(request.TagId);
            _context.Tags.Remove(values);
            await _context.SaveChangesAsync();
        }

    }
}
