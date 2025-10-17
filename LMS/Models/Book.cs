using System;
using System.Collections.Generic;

namespace LMS.Models;

public partial class Book
{
    public int Isbn { get; set; }

    public string? Title { get; set; }

    public string? Edition { get; set; }

    public string? Category { get; set; }

    public decimal? Price { get; set; }

    public int? PublisherId { get; set; }

    public int? StaffId { get; set; }

    public int? AuthorId { get; set; }

    public virtual Author? Author { get; set; }

    public virtual Publisher? Publisher { get; set; }

    public virtual ICollection<ReaderBook> ReaderBooks { get; set; } = new List<ReaderBook>();

    public virtual Staff? Staff { get; set; }
}
