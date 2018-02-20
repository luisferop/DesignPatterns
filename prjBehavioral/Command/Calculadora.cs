using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBehavioral.Command
{
    /// <summary>
    /// Receiver
    /// </summary>
    public class Calculadora
    {
        private int _valor;

        public int Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public Calculadora()
        {
            _valor = 0;
        }
    }
}
