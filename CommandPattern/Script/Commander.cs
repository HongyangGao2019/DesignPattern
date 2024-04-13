using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandPattern
{
    public abstract class Commander
    {
        protected IList<Command> commands=new List<Command>();
        public void SetCommander(IList<Command> commands){
            this.commands = commands;
        }
        public void AddCommander(Command command)
        {
            commands.Add(command);
        }
        public void RemoveCommander(Command command)
        {
            commands.Remove(command);
        }
        public abstract void Notify();
    }

}