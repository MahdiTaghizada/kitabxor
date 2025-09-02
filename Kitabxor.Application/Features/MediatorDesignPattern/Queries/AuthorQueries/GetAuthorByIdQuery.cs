using Kitabxor.Application.Features.MediatorDesignPattern.Results.AuthorResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Queries.AuthorQueries
{
    public class GetAuthorByIdQuery : IRequest<GetAuthorByIdQueryResult>
    {
        public int AuthorId { get; set; }
        public GetAuthorByIdQuery(int authorId)
        {
            AuthorId = authorId;
        }
    }
}
