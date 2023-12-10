using System;
using System.Collections.Generic;

namespace jvyx1q.Models;

public partial class MovieCrew
{
    public int Id { get; set; }

    public int MovieId { get; set; }

    public int CrewId { get; set; }

    public virtual CrewMember Crew { get; set; } = null!;

    public virtual Film Movie { get; set; } = null!;
}
