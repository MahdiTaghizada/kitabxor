using Kitabxor.Application.Features.MediatorDesignPattern.Commands.LanguageCommands;
using Kitabxor.Persistence.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Handlers.LanguageHandlers
{
    public class RemoveLanguageCommandHandler : IRequestHandler<RemoveLanguageCommand>
    {
        private readonly KitabxorContext _context;
        public RemoveLanguageCommandHandler(KitabxorContext context)
        {
            _context = context;
        }
        public async Task Handle(RemoveLanguageCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Languages.FindAsync(request.LanguageId);
            _context.Languages.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
