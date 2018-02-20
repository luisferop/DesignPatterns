using prjBehavioral.Command;
using prjBehavioral.State;
using prjBehavioral.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBehavioral
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Command
            //Calculadora calculadora = new Calculadora();

            //Invoker invoker = new Invoker();

            //invoker.Compute(new Soma(calculadora, 10));
            //invoker.Compute(new Soma(calculadora, 5));
            //invoker.Compute(new Soma(calculadora, 10));
            ////Desfazer as duas últimas operações
            //invoker.Undo(2);
            #endregion

            #region Strategy
            //Vetor v = new Vetor(new BubbleSort());
            //v.Ordenar();

            //v.AlgoritmoOrdenacao = new QuickSort();
            //v.Ordenar();
            #endregion

            #region State
            //Pato p = new Pato();

            ////Altera o comportamento de voar
            //p.SetComportamentoVoar(new NaoVoar());

            //p.Voar();
            //p.Grasnar();
            #endregion
            Console.Read();
        }
    }
}
