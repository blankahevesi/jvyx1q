using System;
using System.Collections.Generic;

namespace jvyx1q.Models;

public partial class CrewMember
{
    public int CrewId { get; set; }

    public string? CrewName { get; set; }

    public virtual ICollection<MovieCrew> MovieCrews { get; set; } = new List<MovieCrew>();
}
