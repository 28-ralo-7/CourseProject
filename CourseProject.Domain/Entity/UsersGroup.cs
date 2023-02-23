using System;
using System.Collections.Generic;

namespace CourseProject.Domain.Entity;

public partial class UsersGroup
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int? GroupId { get; set; }

    public virtual Group? Group { get; set; }

    public virtual User User { get; set; } = null!;
}
