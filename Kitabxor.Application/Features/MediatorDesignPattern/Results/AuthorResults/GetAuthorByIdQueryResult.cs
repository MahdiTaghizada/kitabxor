using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Results.AuthorResults
{
    public class GetAuthorByIdQueryResult
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; } = null!;
        public string? Biography { get; set; }
        public DateTime? CreatedAt { get; set; }
        //public virtual ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
