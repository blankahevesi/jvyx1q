using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jvyx1q
{
    public class Movies
    {
        public int Id { get; set; }
        public string Names { get; set; } = null!;

        public string Language1 { get; set; } = null!;

        public byte Score { get; set; }

        public string Overview { get; set; } = null!;
    }
}
