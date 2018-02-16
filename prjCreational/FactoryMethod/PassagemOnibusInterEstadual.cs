using System;

namespace prjCreational.FactoryMethod
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class PassagemOnibusInterEstadual : Passagem
    {
        public PassagemOnibusInterEstadual(string origem, string destino, DateTime dataHoraPartida) : base(origem, destino, dataHoraPartida)
        {
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Passagem de ônibus interestadual : {ORIGEM} para {DESTINO}, data/hora: {DATAHORAPARTIDA.ToString("dd/MM/yyyy HH:mm:ss")}");
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
