using System;
using System.Collections.Generic;

namespace LMS.Models;

public partial class AuthenticationSystem
{
    public int LoginId { get; set; }

    public string? Password { get; set; }

    public virtual Staff? Staff { get; set; }
}
