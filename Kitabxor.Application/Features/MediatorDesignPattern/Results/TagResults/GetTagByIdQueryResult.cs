using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Results.TagResults
{
    public class GetTagByIdQueryResult
    {
        public int TagId { get; set; }

        public string TagName { get; set; } = null!;

        public DateTime? CreatedAt { get; set; }

        //public virtual ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
