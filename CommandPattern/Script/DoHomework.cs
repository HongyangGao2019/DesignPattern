using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class DoHomework:Command{

        public override void Execute(){
            reciever.Operation();
        }
    }
}