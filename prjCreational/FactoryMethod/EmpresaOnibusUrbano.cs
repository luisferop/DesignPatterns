using System;

namespace prjCreational.FactoryMethod
{
    /// <summary>
    /// Concrete Factory
    /// </summary>
    public class EmpresaOnibusUrbano : Empresa
    {
        public override Passagem EmitirPassagem(string origem, string destino, DateTime dataHoraPartida)
        {
            return new PassagemOnibusUrbano(origem, destino, dataHoraPartida);
        }
    }
}
