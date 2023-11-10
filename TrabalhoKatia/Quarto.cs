using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoKatia
{
    public abstract class Quarto
    {
        public string Unidade { get; set; }
        public string NumQuarto { get; set; }
        public string Quadra { get; set; }
        public string Tipo { get; set; }
        public string CPF { get; set; }
        public abstract double Calcular();
    }
}
