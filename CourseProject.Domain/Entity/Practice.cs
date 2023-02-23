using System;
using System.Collections.Generic;

namespace CourseProject.Domain.Entity;

public partial class Practice
{
    public int Id { get; set; }

    public string PracticesName { get; set; } = null!;

    public DateOnly DateStart { get; set; }

    public DateOnly DateEnd { get; set; }

    public int TeacherId { get; set; }

    public int GroupId { get; set; }

    public virtual Group Group { get; set; } = null!;

    public virtual User Teacher { get; set; } = null!;
}
