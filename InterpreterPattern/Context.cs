using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class Context
    {
        private string input;
        public string Input{
            get { return input; }
            set { input = value; }
        }
        private string output;
        public string Output{
            get { return output; }
            set { output = value; }
        }
    }
}