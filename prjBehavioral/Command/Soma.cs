using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBehavioral.Command
{
    /// <summary>
    /// ConcreteCommand
    /// </summary>
    public class Soma : Command
    {
        private Calculadora _calculadora;
        private int _numero;

        public Soma(Calculadora calculadora, int numero)
        {
            _calculadora = calculadora;
            _numero = numero;
        }
        public override void Execute()
        {
            _calculadora.Valor = _calculadora.Valor + _numero;
            Console.WriteLine($"Valor: {_calculadora.Valor}");
        }

        public override void Undo()
        {
            _calculadora.Valor = _calculadora.Valor - _numero;
            Console.WriteLine($"Valor: {_calculadora.Valor}");
        }
    }
}
