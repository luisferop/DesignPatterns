using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjStructural.Flyweight
{
    public class Linha : Figura
    {
        public Linha() : base()
        {

        }

        public override void Desenha(string cor)
        {
            Console.WriteLine($"Figura linha {cor}");
        }
    }
}
