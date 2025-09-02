using Kitabxor.Application.Features.MediatorDesignPattern.Results.BookResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Queries.BookQueries
{
    public class GetBookQuery : IRequest<List<GetBookQueryResult>>
    {
    }
}
