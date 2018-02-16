using System;

namespace prjCreational.AbstractFactory
{
    public abstract class EmpresaOnibus
    {
        public abstract PassagemOnibusUrbano EmitirPassagemOnibusUrbano(string origem, string destino, DateTime datahorapartida);
        public abstract PassagemOnibusInterEstadual EmitirPassagemOnibusInterEstadual(string origem, string destino, DateTime datahorapartida);
    }
}
