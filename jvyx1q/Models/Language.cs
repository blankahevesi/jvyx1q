using System;
using System.Collections.Generic;

namespace jvyx1q.Models;

public partial class Language
{
    public int LanguageId { get; set; }

    public string Language1 { get; set; } = null!;

    public virtual ICollection<Mlanguage> Mlanguages { get; set; } = new List<Mlanguage>();
}
