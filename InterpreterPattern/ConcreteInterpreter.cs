using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class ConcreteInterpreter : AbstractInterpreter
    {
        public override void Interpret(Context context)
        {
            if(context == null)return;
            if(context.Input.Contains("A"))
            {context.Output="这句话里有A。";}
            else if(context.Input.Contains("B"))
            {context.Output="这句话里有B。";}
        }
    }
}