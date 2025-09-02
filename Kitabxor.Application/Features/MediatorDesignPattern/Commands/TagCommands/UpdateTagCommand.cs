using Kitabxor.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Commands.TagCommands
{
    public class UpdateTagCommand : IRequest
    {
        public int TagId { get; set; }

        public string TagName { get; set; } = null!;

        public DateTime? CreatedAt { get; set; }

        //public virtual ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
