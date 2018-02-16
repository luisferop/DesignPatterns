using System;

namespace prjCreational.FactoryMethod
{
    /// <summary>
    /// Concrete Factory
    /// </summary>
    public class EmpresaOnibusInterEstadual : Empresa
    {
        public override Passagem EmitirPassagem(string origem, string destino, DateTime dataHoraPartida)
        {
            return new PassagemOnibusInterEstadual(origem, destino, dataHoraPartida);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
