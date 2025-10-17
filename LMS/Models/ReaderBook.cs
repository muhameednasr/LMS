using System;
using System.Collections.Generic;

namespace LMS.Models;

public partial class ReaderBook
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? Isbn { get; set; }

    public DateOnly? ReserveDate { get; set; }

    public DateOnly? ReturnDate { get; set; }

    public DateOnly? DueDate { get; set; }

    public virtual Book? IsbnNavigation { get; set; }

    public virtual Reader? User { get; set; }
}
