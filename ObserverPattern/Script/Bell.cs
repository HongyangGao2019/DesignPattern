using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Bell : Subject
    {
        private IList<IObserver> _observers=new List<IObserver>();
        public override void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public override void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public override void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}