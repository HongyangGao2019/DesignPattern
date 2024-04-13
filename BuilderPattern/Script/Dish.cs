using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class Dish
    {
        public abstract void CookingMethod();
        public abstract void AddVegetable();
        public abstract void AddSalt();
        public abstract void AddSuger();        
        public abstract void AddVinegar();
        public abstract void AddSoy();
        public abstract void AddPeanutOil();
        public abstract void Serve();
    }
}