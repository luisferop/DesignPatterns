using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjStructural.Decorator
{
    public class Bola : Decoracao
    {
        public Bola(Arvore arvore) : base(arvore)
        {
        }

        public override void ShowEnfeites()
        {
            base.ShowEnfeites();
            Console.Write("Bola, ");
        }
    }
}
