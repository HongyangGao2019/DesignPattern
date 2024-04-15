using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositePattern
{
    public abstract class Level
    {
        public string Name { get; set; }
        public Level(string name)
        {
            Name = name;
        }
        public abstract void Add(Level level);
        public abstract void Remove(Level level);
        public abstract void ShowLevelInfo(int i);
    }
}