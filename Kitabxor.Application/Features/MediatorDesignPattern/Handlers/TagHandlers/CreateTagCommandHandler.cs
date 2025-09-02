using Kitabxor.Application.Features.MediatorDesignPattern.Commands.TagCommands;
using Kitabxor.Domain.Entities;
using Kitabxor.Persistence.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Handlers.TagHandlers
{
    public class CreateTagCommandHandler : IRequestHandler<CreateTagCommand>
    {
        private readonly KitabxorContext _context;
        public CreateTagCommandHandler(KitabxorContext context)
        {
            _context = context;
        }
        public async Task Handle(CreateTagCommand request, CancellationToken cancellationToken)
        {
             await _context.Tags.AddAsync(new Tag
            {
                TagName = request.TagName,
                CreatedAt = request.CreatedAt
            });
            await _context.SaveChangesAsync();
        }
    }
}
