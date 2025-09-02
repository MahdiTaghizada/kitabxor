using Kitabxor.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Commands.TagCommands
{
    public class CreateTagCommand : IRequest
    {
        public string TagName { get; set; } = null!;

        public DateTime? CreatedAt { get; set; }
    }
}
