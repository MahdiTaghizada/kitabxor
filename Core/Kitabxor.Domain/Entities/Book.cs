using System;
using System.Collections.Generic;

namespace Kitabxor.Domain.Entities;

public partial class Book
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

    public virtual Author? Author { get; set; }

    public virtual Language? Language { get; set; }

    public virtual Tag? Tag { get; set; }

    public virtual Admin? UploadedByNavigation { get; set; }
}
