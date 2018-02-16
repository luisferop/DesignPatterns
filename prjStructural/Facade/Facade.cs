using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjStructural.Facade
{
    public class Facade
    {

        private SubsistemaUm sis1;
        private SubsistemaDois sis2;
        private SubsistemaTres sis3;

        public Facade()
        {
            sis1 = new SubsistemaUm();
            sis2 = new SubsistemaDois();
            sis3 = new SubsistemaTres();
        }
        public void MetodoA()
        {
            sis1.MetodoUm(); //subsistema 1
            sis2.MetodoDois(); //subsistema 2
            sis3.MetodoTres(); //subsistema 3
        }

        public void MetodoB()
        {
            sis3.MetodoTres(); //subsistema 3
            sis2.MetodoDois(); //subsistema 2
            sis1.MetodoUm(); //subsistema 1
        }
    }
}
