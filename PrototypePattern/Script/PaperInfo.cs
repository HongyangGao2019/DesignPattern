using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class PaperInfo:ICloneable
    {
        private string? name;
        private int? id;
        public string? Name{
            get{ return name; }
            set{ name = value; }
        }
        public int? Id{
            get{ return id; }
            set{ id = value; }
        }
        public PaperInfo(string? name, int? id)
        {
            this.name = name;
            this.id = id;
        }
        public void Display()
        {
            Console.WriteLine($"---Name:{name} ----- Id:{id}---");
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}