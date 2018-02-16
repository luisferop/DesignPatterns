using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjStructural.Flyweight
{
    public class Oval : Figura
    {
        private bool _isPreenchido;
        public Oval(bool isPreenchido): base()
        {
            _isPreenchido = isPreenchido;
        }

        public override void Desenha(string cor)
        {
            if (_isPreenchido)
            {
                Console.WriteLine($"Figura oval preenchida com a cor {cor}");
            }
            else
            {
                Console.WriteLine($"Figura oval não preenchida com a cor {cor}");
            }
        }
    }
}
