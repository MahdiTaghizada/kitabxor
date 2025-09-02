using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Commands.AuthorCommands
{
    public class CreateAuthorCommand : IRequest
    {
        public string AuthorName { get; set; } = null!;
        public string? Biography { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
