using Kitabxor.Application.Features.MediatorDesignPattern.Commands.AdminCommands;
using Kitabxor.Persistence.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Handlers.AdminHandlers
{
    public class RemoveAdminCommandHandler : IRequestHandler<RemoveAdminCommand>
    {
        private readonly KitabxorContext _context;
        public RemoveAdminCommandHandler(KitabxorContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveAdminCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Admins.FindAsync(request.AdminId);
            _context.Admins.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
