using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjStructural.Adapter
{
    public class TomadaBrasileira : Tomada<PlugBrasileiro>
    {
        public override string Conecta(PlugBrasileiro plug)
        {
            return $"{plug.ObtemEletricidade()} {GetNomeRede()}";
        }

        public override string GetNomeRede()
        {
            return "tomada brasileira";
        }
    }
}
