using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjStructural.Adapter
{
    public class PlugBrasileiro : Plug
    {
        public override string ObtemEletricidade()
        {
            return "Plug Brasileiro conectado à ";
        }
    }
}
