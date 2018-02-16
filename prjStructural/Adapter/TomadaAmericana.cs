using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjStructural.Adapter
{
    public class TomadaAmericana : Tomada<PlugAmericano>
    {
        public override string Conecta(PlugAmericano plug)
        {
            return $"{plug.ObtemEletricidade()} {GetNomeRede()}";
        }

        public override string GetNomeRede()
        {
            return "tomada americana";
        }
    }
}
