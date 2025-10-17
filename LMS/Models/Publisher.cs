using System;
using System.Collections.Generic;

namespace LMS.Models;

public partial class Publisher
{
    public int PublisherId { get; set; }

    public string? Name { get; set; }

    public int? YearOfPublication { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
