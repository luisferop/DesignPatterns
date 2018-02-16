using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjStructural.Decorator
{
    public abstract class Decoracao : Arvore
    {
        private readonly Arvore _arvore;
        public Decoracao(Arvore arvore)
        {
            _arvore = arvore;
        }
        public override void ShowEnfeites()
        {
            _arvore.ShowEnfeites();
        }
    }
}
