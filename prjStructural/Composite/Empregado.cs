using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjStructural.Composite
{
    /// <summary>
    /// Component
    /// </summary>
    public abstract class Empregado
    {
        protected String _nome;
        protected double _salario;

        public Empregado(String nome, double salario)
        {
            _nome = nome;
            _salario = salario;
        }

        //Exibe detalhes do empregado
        public abstract void Print();
        public abstract void Add(Empregado e);
        public abstract void Remove(Empregado e);
    }
}
