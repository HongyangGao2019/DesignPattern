using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Pants:AbstractDecorator
    {
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Wear Pants");
        }
    }
}