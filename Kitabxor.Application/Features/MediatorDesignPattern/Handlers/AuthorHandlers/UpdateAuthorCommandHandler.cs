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
    public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand>
    {
        private readonly KitabxorContext _context;
        public UpdateAuthorCommandHandler(KitabxorContext context)
        {
            _context = context;
        }
        public async Task Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Authors.FindAsync(request.AuthorId);
            values.AuthorName = request.AuthorName;
            values.Biography = request.Biography;
            await _context.SaveChangesAsync();
        }
    }
}
