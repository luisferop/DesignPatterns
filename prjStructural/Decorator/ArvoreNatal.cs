using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjStructural.Decorator
{
    public class ArvoreNatal : Arvore
    {
        public override void ShowEnfeites()
        {
            Console.Write("Árvore de Natal, ");
        }
    }
}
