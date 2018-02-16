using System;

namespace prjCreational.AbstractFactory
{
    public class ConcretePassagemOnibusUrbano : PassagemOnibusUrbano
    {
        public ConcretePassagemOnibusUrbano(string origem, string destino, DateTime dataHoraPartida) : base(origem, destino, dataHoraPartida)
        {
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Passagem de ônibus urbano : {ORIGEM} para {DESTINO}, data/hora: {DATAHORAPARTIDA.ToString("dd/MM/yyyy HH:mm:ss")}");
        }
    }
}
