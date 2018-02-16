using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjStructural.Decorator
{
    public class PiscaPisca : Decoracao
    {
        public PiscaPisca(Arvore arvore) : base(arvore)
        {
        }

        public override void ShowEnfeites()
        {
            base.ShowEnfeites();
            Console.Write("Pisca-Pisca, ");
        }
    }
}
