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
    public class UpdateLanguageCommandHandler : IRequestHandler<UpdateLanguageCommand>
    {
        private readonly KitabxorContext _context;
        public UpdateLanguageCommandHandler(KitabxorContext context)
        {
            _context = context;
        }
        public async Task Handle(UpdateLanguageCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Languages.FindAsync(request.LanguageId);
            values.LanguageName = request.LanguageName;
            await _context.SaveChangesAsync();

        }
    }
}
