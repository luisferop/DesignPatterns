using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjStructural.Adapter
{
    /// <summary>
    /// Adapter
    /// </summary>
    public class AdapterEUAtoBrasil : TomadaBrasileira
    {
        public string Conecta(PlugAmericano plug)
        {
            return $"{plug.ObtemEletricidade()} {GetNomeRede()}";
        }
    }
}
