using System;
using System.Collections.Generic;

namespace CourseProject.Domain.Entity;

public partial class UserRole
{
    public int RoleId { get; set; }

    public string RoleValue { get; set; } = null!;

    public virtual ICollection<User> Users { get; } = new List<User>();
}
