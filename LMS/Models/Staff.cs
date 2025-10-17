using System;
using System.Collections.Generic;

namespace LMS.Models;

public partial class Staff
{
    public int StaffId { get; set; }

    public string? Name { get; set; }

    public int? LoginId { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();

    public virtual AuthenticationSystem? Login { get; set; }

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();
}
