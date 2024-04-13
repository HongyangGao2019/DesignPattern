using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class AbstractDecorator:AbstractPerson
    {
        protected AbstractPerson? person;
        public void SetWearPerson(AbstractPerson person){
            this.person = person;
        }
        public override void Show(){
            person?.Show();
        }
    }
}