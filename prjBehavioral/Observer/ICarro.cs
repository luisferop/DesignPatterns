using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBehavioral.Observer
{
    public interface ICarro
    {
        void Frente();
        void Direita();
        void Esquerda();
        void Para();
    }
}
