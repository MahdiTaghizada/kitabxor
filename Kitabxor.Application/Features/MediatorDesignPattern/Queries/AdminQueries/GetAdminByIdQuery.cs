using Kitabxor.Application.Features.MediatorDesignPattern.Results.AdminResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Queries.AdminQueries
{
    public class GetAdminByIdQuery : IRequest<GetAdminByIdQueryResult>
    {
        public int AdminId { get; set; }

        public GetAdminByIdQuery(int adminId)
        {
            AdminId = adminId;
        }
    }
}
