using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBehavioral.State
{
    public class Pato : Ave
    {
        private Comportamento _comportamentoVoar;
        private Comportamento _comportamentoGrasnar;

        public Pato()
        {
            _comportamentoVoar = new Voar();
            _comportamentoGrasnar = new Grasnar();
        }
        public override void Grasnar()
        {
            _comportamentoGrasnar.Exec();
        }

        public override void SetComportamentoGrasnar(Comportamento c)
        {
            _comportamentoGrasnar = c;
        }

        public override void SetComportamentoVoar(Comportamento c)
        {
            _comportamentoVoar = c;
        }

        public override void Voar()
        {
            _comportamentoVoar.Exec();
        }
    }
}
