using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class PeopleFactory
    {
        private Hashtable flyweights=new Hashtable();
        public People GetPeopleCitizenship(string citizenship)
        {
            if(!flyweights.ContainsKey(citizenship))
            {
                flyweights.Add(citizenship,new ConcretePeople(citizenship));
            }
            return (People)flyweights[citizenship];
        }
        public void ShowCitizenshipCount()
        {
            Console.WriteLine($"People Citizenship count :{flyweights.Count}");
        }
    }
}