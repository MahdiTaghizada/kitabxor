using Kitabxor.Application.Features.MediatorDesignPattern.Queries.AdminQueries;
using Kitabxor.Application.Features.MediatorDesignPattern.Results.AdminResults;
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
    public class GetAdminQueryHandler : IRequestHandler<GetAdminQuery, List<GetAdminQueryResult>>
    {
        private readonly KitabxorContext _context;
        public GetAdminQueryHandler(KitabxorContext context)
        {
            _context = context;
        }

        public async Task<List<GetAdminQueryResult>> Handle(GetAdminQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Admins.ToListAsync();
            return values.Select(x => new GetAdminQueryResult
            {
                AdminId = x.AdminId,
                Username = x.Username,
                Email = x.Email,
                PasswordHash = x.PasswordHash,
            }).ToList();
        }
    }
}
