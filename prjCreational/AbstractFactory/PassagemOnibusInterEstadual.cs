using System;

namespace prjCreational.AbstractFactory
{
    public abstract class PassagemOnibusInterEstadual
    {
        private string _origem;
        private string _destino;
        private DateTime _dataHoraPartida;

        public PassagemOnibusInterEstadual(string origem, string destino, DateTime dataHoraPartida)
        {
            _origem = origem;
            _destino = destino;
            _dataHoraPartida = dataHoraPartida;
        }

        public string ORIGEM
        {
            get { return _origem; }
            set { _origem = value; }
        }
        public string DESTINO
        {
            get { return _destino; }
            set { _destino = value; }
        }

        public DateTime DATAHORAPARTIDA
        {
            get { return _dataHoraPartida; }
            set { _dataHoraPartida = value; }
        }
        public abstract void ExibirDetalhes();
    }
}
