using Kitabxor.Application.Features.MediatorDesignPattern.Queries.AdminQueries;
using Kitabxor.Application.Features.MediatorDesignPattern.Results.AdminResults;
using Kitabxor.Persistence.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Handlers.AdminHandlers
{
    public class GetAdminByIdQueryHandler : IRequestHandler<GetAdminByIdQuery, GetAdminByIdQueryResult>
    {
        private readonly KitabxorContext _context;
        public GetAdminByIdQueryHandler(KitabxorContext context)
        {
            _context = context;
        }
        public async Task<GetAdminByIdQueryResult> Handle(GetAdminByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Admins.FindAsync(request.AdminId);
            return new GetAdminByIdQueryResult
            {
                AdminId = values.AdminId,
                Username = values.Username,
                PasswordHash = values.PasswordHash,
                Email = values.Email,
                CreatedAt = values.CreatedAt,
            };
        }
    }
}
