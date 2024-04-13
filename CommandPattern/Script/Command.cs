using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandPattern
{
    public abstract class Command
    {
        protected Reciever reciever;
        public void SetCommand(Reciever reciever){
            this.reciever=reciever;
        }
        public abstract void Execute();
    }
}