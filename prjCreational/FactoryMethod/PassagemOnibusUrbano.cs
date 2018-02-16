using System;

namespace prjCreational.FactoryMethod
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class PassagemOnibusUrbano : Passagem
    {
        public PassagemOnibusUrbano(string origem, string destino, DateTime dataHoraPartida) : base(origem, destino, dataHoraPartida)
        {
        }
    
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Passagem de ônibus urbano : {ORIGEM} para {DESTINO}, data/hora: {DATAHORAPARTIDA.ToString("dd/MM/yyyy HH:mm:ss")}");
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
