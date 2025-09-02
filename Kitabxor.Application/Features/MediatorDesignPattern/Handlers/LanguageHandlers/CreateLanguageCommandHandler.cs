using Kitabxor.Application.Features.MediatorDesignPattern.Commands.LanguageCommands;
using Kitabxor.Domain.Entities;
using Kitabxor.Persistence.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Handlers.LanguageHandlers
{
    public class CreateLanguageCommandHandler : IRequestHandler<CreateLanguageCommand>
    {
        private readonly KitabxorContext _context;
        public CreateLanguageCommandHandler(KitabxorContext context)
        {
            _context = context;
        }
        public async Task Handle(CreateLanguageCommand request, CancellationToken cancellationToken)
        {
            await _context.Languages.AddAsync(new Language
            {
                LanguageName = request.LanguageName
            });
            await _context.SaveChangesAsync();
        }
    }
}

