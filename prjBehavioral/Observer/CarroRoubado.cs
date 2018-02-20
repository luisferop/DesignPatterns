using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBehavioral.Observer
{
    public class CarroRoubado : IObservable<Carro>, ICarro
    {
        List<IObserver<Carro>> observers;
        public CarroRoubado()
        {
            observers = new List<IObserver<Carro>>();
        }
        public void Direita()
        {
            throw new NotImplementedException();
        }

        public void Esquerda()
        {
            throw new NotImplementedException();
        }

        public void Frente()
        {
            throw new NotImplementedException();
        }

        public void Para()
        {
            throw new NotImplementedException();
        }

        public IDisposable Subscribe(IObserver<Carro> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);

            return new Unsubscriber(observers, observer);
        }
        public void MudaEstado()
        {
            //noti; // Mudou o estado
            //notifyObservers(acao); // Notifica os observadores
        }
    }
   
}
