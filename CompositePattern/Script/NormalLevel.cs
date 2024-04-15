using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class NormalLevel:Level
    {
        private List<Level> levels=new List<Level>();

        public NormalLevel(string name) : base(name)
        {
        }

        public override void Add(Level level)
        {
            levels.Add(level);
        }

        public override void Remove(Level level)
        {
            levels.Remove(level);
        }

        public override void ShowLevelInfo(int i)
        {
            Console.WriteLine(new String('-',i)+$"Normal Level Name:{this.Name}" );
            foreach(Level le in levels)
            {
                le.ShowLevelInfo(i+2);
            }
        }
        
    }
}