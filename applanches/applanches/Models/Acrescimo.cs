using System;
using System.Collections.Generic;
using System.Text;

namespace applanches.Models
{
    public class Acrescimo
    {
        public int AcrescimoId { get; set; }
        public string Nome { get; set; }
        public string Valor { get; set; }

        public decimal Maionese { get; } = 1.00M;
        public decimal Ovo { get; } = 1.00M;
        public decimal Cheddar { get; } = 1.00M;
        public decimal Catupiry { get; } = 1.00M;
        public decimal Bacon { get; } = 1.00M;

    }
}
