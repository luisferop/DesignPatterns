using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBehavioral.Observer
{
    class Unsubscriber : IDisposable
    {
        private List<IObserver<Carro>> _observers;
        private IObserver<Carro> _observer;

        public Unsubscriber(List<IObserver<Carro>> observers, IObserver<Carro> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (!(_observer == null)) _observers.Remove(_observer);
        }
    }
}
