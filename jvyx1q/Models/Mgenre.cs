using System;
using System.Collections.Generic;

namespace jvyx1q.Models;

public partial class Mgenre
{
    public int Id { get; set; }

    public int MovieId { get; set; }

    public int GenreId { get; set; }

    public virtual Genre Genre { get; set; } = null!;

    public virtual Film Movie { get; set; } = null!;
}
