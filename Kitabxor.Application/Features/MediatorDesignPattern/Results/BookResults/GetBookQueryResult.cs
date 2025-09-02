using Kitabxor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxor.Application.Features.MediatorDesignPattern.Results.BookResults
{
    public class GetBookQueryResult
    {
        public int BookId { get; set; }

        public string Title { get; set; } = null!;

        public string? Description { get; set; }

        public int? PublicationYear { get; set; }

        public string? CoverImageUrl { get; set; }

        public string GoogleDriveFileId { get; set; } = null!;

        public int? LanguageId { get; set; }

        public int? AuthorId { get; set; }

        public int? TagId { get; set; }

        public int? UploadedBy { get; set; }

        public DateTime? CreatedAt { get; set; }

    }
}
