using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatePattern
{
    public abstract class State
    {
        public abstract void Handle(Context context);
    }
    public class MorningState:State{
        public override void Handle(Context context)
        {
            if(context.DateTime.Second>=0&&context.DateTime.Second<20)
            {
                Console.WriteLine($"Good Morning.{context.DateTime.Second}");
            }
            else{
                context.SetState(new AfternoonState());
                context.Operation();
            }
        }
    }
    public class AfternoonState:State{
        public override void Handle(Context context)
        {
            if(context.DateTime.Second>=20&&context.DateTime.Second<40){
                Console.WriteLine($"Good Afternoon.{context.DateTime.Second}");
            }
            else{
                context.SetState(new NightState());
                context.Operation();
            }
        }

    }
    public class NightState:State{
        public override void Handle(Context context)
        {
            if(context.DateTime.Second>=40&&context.DateTime.Second<60)
            Console.WriteLine($"Good Night.{context.DateTime.Second}");
            else{
                context.SetState(new MorningState());
                context.Operation();
            }
        }
    }
}