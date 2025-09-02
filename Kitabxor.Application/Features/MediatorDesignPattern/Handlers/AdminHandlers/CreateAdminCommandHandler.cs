using Kitabxor.Application.Features.MediatorDesignPattern.Commands.AdminCommands;
using Kitabxor.Domain.Entities;
using Kitabxor.Persistence.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Handlers.AdminHandlers
{
    public class CreateAdminCommandHandler : IRequestHandler<CreateAdminCommand>
    {
        private readonly KitabxorContext _context;
        public CreateAdminCommandHandler(KitabxorContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateAdminCommand request, CancellationToken cancellationToken)
        {
            await _context.Admins.AddAsync(new Admin
            {
                Username = request.Username,
                PasswordHash = request.PasswordHash,
                Email = request.Email,
                CreatedAt = DateTime.UtcNow,
            });
            await _context.SaveChangesAsync();
        }
    }
}
