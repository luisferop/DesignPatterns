using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBehavioral.Observer
{
    public class Carro
    {
        public Carro(string tipoCarro)
        {
            _tipoCarro = tipoCarro;
        }
        private string _tipoCarro;

        public string TipoCarro
        {
            get { return _tipoCarro; }
            set { _tipoCarro = value; }
        }

    }
}
