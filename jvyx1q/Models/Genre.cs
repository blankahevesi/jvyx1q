using System;
using System.Collections.Generic;

namespace jvyx1q.Models;

public partial class Genre
{
    public int GenreId { get; set; }

    public string GenreName { get; set; } = null!;

    public virtual ICollection<Mgenre> Mgenres { get; set; } = new List<Mgenre>();
}
