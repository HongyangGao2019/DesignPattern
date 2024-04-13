using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Underwear:AbstractDecorator
    {
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Wear Underwear!");
        }
    }
}