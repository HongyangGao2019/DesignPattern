using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public abstract class AbstractInterpreter
    {
        public abstract void Interpret(Context context);
    }
}