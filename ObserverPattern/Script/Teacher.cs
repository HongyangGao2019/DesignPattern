using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Teacher : IObserver
    {
        private string name;
        public Teacher(string name)
        {
            this.name = name;
        }
        public void Update()
        {
            Console.WriteLine($"{this.name}老师该教课了！");
        }
    }
}