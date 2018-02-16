using System;

namespace prjCreational.AbstractFactory
{
    public class ConcretePassagemOnibusInterEstadual : PassagemOnibusInterEstadual
    {
        public ConcretePassagemOnibusInterEstadual(string origem, string destino, DateTime dataHoraPartida) : base(origem, destino, dataHoraPartida)
        {
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Passagem de ônibus interestadual : {ORIGEM} para {DESTINO}, data/hora: {DATAHORAPARTIDA.ToString("dd/MM/yyyy HH:mm:ss")}");
        }
    }
}
