using Kitabxor.Application.Features.MediatorDesignPattern.Commands.AdminCommands;
using Kitabxor.Persistence.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Handlers.AdminHandlers
{
    public class UpdateAdminCommandHandler : IRequestHandler<UpdateAdminCommand>
    {
        private readonly KitabxorContext _context;
        public UpdateAdminCommandHandler(KitabxorContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateAdminCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Admins.FindAsync(request.AdminId);
            values.Username = request.Username;
            values.PasswordHash = request.PasswordHash;
            values.Email = request.Email;
            await _context.SaveChangesAsync();
        }
    }
}
