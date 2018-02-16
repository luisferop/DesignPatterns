using System;

namespace prjCreational.AbstractFactory
{
    public class ConcreteEmpresaOnibus : EmpresaOnibus
    {
        public override PassagemOnibusInterEstadual EmitirPassagemOnibusInterEstadual(string origem, string destino, DateTime datahorapartida)
        {
            return new ConcretePassagemOnibusInterEstadual(origem, destino, datahorapartida);
        }

        public override PassagemOnibusUrbano EmitirPassagemOnibusUrbano(string origem, string destino, DateTime datahorapartida)
        {
            return new ConcretePassagemOnibusUrbano(origem, destino, datahorapartida);
        }
    }
}
