using System;
using System.Collections.Generic;

namespace LMS.Models;

public partial class Reader
{
    public int UserId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? PhoneNo { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<ReaderBook> ReaderBooks { get; set; } = new List<ReaderBook>();

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();
}
