using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjStructural.Flyweight
{
    public abstract class Figura
    {
        public Figura()
        {

        }
        public abstract void Desenha(string cor);
    }
}
