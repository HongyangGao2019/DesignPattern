using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Student : IObserver
    {
        private string name;
        public Student(string name)
        {
            this.name = name;
        }
        public void Update()
        {
            Console.WriteLine($"{this.name}该上课了！");
        }
    }
}