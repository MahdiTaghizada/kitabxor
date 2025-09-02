using Kitabxor.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Commands.BookCommands
{
    public class RemoveBookCommand : IRequest
    {
        public int BookId { get; set; }

        public RemoveBookCommand(int bookId)
        {
            BookId = bookId;
        }
    }
}
