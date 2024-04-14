using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public abstract class Meal
    {
        public void HaveMeal()
        {
            PrepareTableware();
            PrepareFood();
        }
        protected abstract void PrepareTableware();
        protected abstract void PrepareFood();
    }
}