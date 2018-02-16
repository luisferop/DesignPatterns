using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjStructural.Adapter
{
    public class PlugAmericano : Plug
    {
        public override string ObtemEletricidade()
        {
            return "Plug Americano conectado à ";
        }
    }
}
