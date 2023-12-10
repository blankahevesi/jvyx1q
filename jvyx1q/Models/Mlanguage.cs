using System;
using System.Collections.Generic;

namespace jvyx1q.Models;

public partial class Mlanguage
{
    public int MovieId { get; set; }

    public int LanguageId { get; set; }

    public int Id { get; set; }

    public virtual Language Language { get; set; } = null!;

    public virtual Film Movie { get; set; } = null!;
}
