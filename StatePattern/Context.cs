using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Context
    {
        protected State state;
        public DateTime DateTime { get=>DateTime.Now; }
        public Context(State state)
        {
            this.state = state; 
        }
        public void SetState(State state)
        {
            this.state=state;
        }
        public void Operation(){
            state.Handle(this);
        }
    }
}