using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyweightPattern
{
        public enum SkinColor{
        Black,
        White,
        Yellow,
        Brown
    }
    public interface IRegister
    {
        void Register(string name, SkinColor color);
        void ModifyName(string name);
    }
    public class ConcretePeople : People,IRegister
    {
        public string Name { get; set; }
        public SkinColor SkinColor { get; set; }
        public string Citizenship{get; set; }
        public ConcretePeople(string citizenship)
        {
            Citizenship=citizenship;
        }

        public override void ShowID()
        {
            Console.WriteLine($"Name:{this.Name} SkinColor:{this.SkinColor} Citizenship:{this.Citizenship}"); 
        }

        public void Register(string name, SkinColor color)
        {
            this.Name=name;
            this.SkinColor=color;
        }

        public void ModifyName(string name)
        {
            this.Name = name;
        }
    }
}