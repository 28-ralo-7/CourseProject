using System;
using System.Collections.Generic;

namespace CourseProject.Domain.Entity;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public int FkRoleId { get; set; }

    public string UserNumber { get; set; } = null!;

    public virtual UserRole FkRole { get; set; } = null!;

    public virtual ICollection<Practice> Practices { get; } = new List<Practice>();

    public virtual ICollection<UsersGroup> UsersGroups { get; } = new List<UsersGroup>();
}
