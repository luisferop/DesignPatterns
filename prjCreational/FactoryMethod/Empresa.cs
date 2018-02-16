using System;

namespace prjCreational.FactoryMethod
{
    /// <summary>
    /// Abstract Factory
    /// </summary>
    public abstract class Empresa
    {
        public abstract Passagem EmitirPassagem(string origem, string destino, DateTime dataHoraPartida);
    }
}
