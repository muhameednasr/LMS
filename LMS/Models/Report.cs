using System;
using System.Collections.Generic;

namespace LMS.Models;

public partial class Report
{
    public int RegNo { get; set; }

    public int? BookNo { get; set; }

    public int? UserId { get; set; }

    public string? IssueReturn { get; set; }

    public int? StaffId { get; set; }

    public virtual Staff? Staff { get; set; }

    public virtual Reader? User { get; set; }
}
