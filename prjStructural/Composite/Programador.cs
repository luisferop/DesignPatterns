using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjStructural.Composite
{
    public class Programador : Empregado
    {
        public Programador(string nome, double salario) : base(nome, salario)
        {
        }

        public override void Add(Empregado e)
        {
            Console.WriteLine("Não é possível adicionar empregado subordinado do programador");
        }

        public override void Print()
        {
            Console.WriteLine($"Nome: {base._nome}, Salário: ${base._salario}");
        }

        public override void Remove(Empregado e)
        {
            Console.WriteLine("Não é possível remover empregado subordinado do programador");
        }
    }
}
