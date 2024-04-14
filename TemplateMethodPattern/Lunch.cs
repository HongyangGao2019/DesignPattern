using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class Lunch : Meal
    {
        protected override void PrepareFood()
        {
            Console.WriteLine("准备的是米饭和牛肉青菜！");
        }

        protected override void PrepareTableware()
        {
            Console.WriteLine("准备的是筷子！");
        }
    }
}