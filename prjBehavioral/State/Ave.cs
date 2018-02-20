using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBehavioral.State
{
    public abstract class Ave
    {
        public abstract void SetComportamentoVoar(Comportamento c);
        public abstract void Voar();
        public abstract void SetComportamentoGrasnar(Comportamento c);
        public abstract void Grasnar();
    }
}
