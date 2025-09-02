using Kitabxor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Results.TagResults
{
    public class GetTagQueryResult
    {
        public int TagId { get; set; }

        public string TagName { get; set; } = null!;

        public DateTime? CreatedAt { get; set; }

        //public virtual ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
