using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Teacher:Commander
    {
        public override void Notify()
        {
            foreach(var command in commands)
            {
                command.Execute();
            }
        }
    }
}