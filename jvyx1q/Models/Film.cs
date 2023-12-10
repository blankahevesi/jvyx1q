using System;
using System.Collections.Generic;

namespace jvyx1q.Models;

public partial class Film
{
    public int Id { get; set; }

    public string Names { get; set; } = null!;

    public DateTime DateX { get; set; }

    public byte Score { get; set; }

    public string Overview { get; set; } = null!;

    public string OrigTitle { get; set; } = null!;

    public string Status { get; set; } = null!;

    public int BudgetX { get; set; }

    public long Revenue { get; set; }

    public virtual ICollection<Mgenre> Mgenres { get; set; } = new List<Mgenre>();

    public virtual ICollection<Mlanguage> Mlanguages { get; set; } = new List<Mlanguage>();

    public virtual ICollection<MovieCrew> MovieCrews { get; set; } = new List<MovieCrew>();
}
