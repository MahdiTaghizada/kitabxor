using Kitabxor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Queries.LanguageResults
{
    public class GetLanguageQueryResult
    {
        public int LanguageId { get; set; }

        public string LanguageName { get; set; } = null!;

        //public virtual ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
