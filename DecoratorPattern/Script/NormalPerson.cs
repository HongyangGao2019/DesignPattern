using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class NormalPerson : AbstractPerson
    {
        public override void Show()
        {
            Console.WriteLine("Still wear nothing");
        }
    }
}