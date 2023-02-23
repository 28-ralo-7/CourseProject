using System;
using System.Collections.Generic;

namespace CourseProject.Domain.Entity;

public partial class Group
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Practice> Practices { get; } = new List<Practice>();

    public virtual ICollection<UsersGroup> UsersGroups { get; } = new List<UsersGroup>();
}
