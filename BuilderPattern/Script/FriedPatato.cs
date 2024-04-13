using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// Concreate Dish
    /// </summary>
    public class FriedPatato : Dish
    {
        public override void AddPeanutOil()
        {
            Console.WriteLine("Add 10g peanut oil.");
        }

        public override void AddSalt()
        {
            Console.WriteLine("Add 3g salt.");
        }

        public override void AddSoy()
        {
            Console.WriteLine("Add 2g soy.");
        }

        public override void AddSuger()
        {
            Console.WriteLine("Add 0g suger.");
        }

        public override void AddVegetable()
        {
            Console.WriteLine("Add 100g patato.");
        }

        public override void AddVinegar()
        {
            Console.WriteLine("Add 3g vinegar.");
        }

        public override void CookingMethod()
        {
            Console.WriteLine("Fried!");
        }

        public override void Serve()
        {
            Console.WriteLine("Serve Over.");
        }
    }
}