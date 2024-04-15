using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public abstract class Subject
    {
        public abstract void Attach(IObserver observer);
        public abstract void Detach(IObserver observer);
        public abstract void Notify();
    }
}