using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Student : Reciever
    {
        public override void Operation()
        {
            Console.WriteLine("写作业！");
        }
    }
}