using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class Breakfast : Meal
    {
        protected override void PrepareFood()
        {
            Console.WriteLine("准备的是汤圆！");
        }

        protected override void PrepareTableware()
        {
            Console.WriteLine("准备汤匙吃汤圆咯！");
        }
    }
}