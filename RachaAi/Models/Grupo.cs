using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RachaAi.Models
{
    public class Grupo
    {
        public String Nome { get; set; } = String.Empty;
        public String Categoria { get; set; } = String.Empty;
        public Decimal ValorPendente { get; set; }
        public bool NoVermelho { get; set; }
    }
}