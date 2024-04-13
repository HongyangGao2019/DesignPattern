using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class DishDirector
    {
        public void Cook(Dish dish)
        {
            if (dish == null){
                Console.WriteLine("no dish!");
            }
            else{
                dish.AddPeanutOil();
                dish.CookingMethod();
                dish.AddVegetable();
                dish.AddVinegar();
                dish.AddSoy();
                dish.AddSuger();
                dish.AddSalt();
                dish.Serve();
            }

        }
    }
}