using Kitabxor.Application.Features.MediatorDesignPattern.Results.BookResults;
using Kitabxor.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Queries.BookQueries
{
    public class GetBookByIdQuery : IRequest<GetBookByIdQueryResult>
    {
        public int BookId { get; set; }

        public GetBookByIdQuery(int bookId)
        {
            BookId = bookId;
        }
    }
}
