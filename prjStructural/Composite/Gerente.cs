using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjStructural.Composite
{
    /// <summary>
    /// Composite
    /// </summary>
    public class Gerente : Empregado
    {
        private List<Empregado> _listaSubordinados = new List<Empregado>();

        public Gerente(string nome, double salario) : base(nome, salario)
        {
        }

        public override void Add(Empregado e)
        {
            _listaSubordinados.Add(e);
        }

        public override void Print()
        {
            Console.WriteLine($"Nome: {base._nome}, Salário: ${base._salario}");
            foreach (Empregado item in _listaSubordinados)
            {
                item.Print();
            }
        }

        public override void Remove(Empregado e)
        {
            _listaSubordinados.Remove(e);
        }
    }
}
