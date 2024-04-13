using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public enum Family{
        Grandfather,
        Father,
        Son
    }
    public abstract class Handler
    {
        protected Handler nextHandler;
        public void SetNextHandler(Handler nextHandler)
        {
            this.nextHandler = nextHandler;
        }
        public abstract void Handle(Family family);
    }
    public class GrandfatherHandler : Handler
    {
        public override void Handle(Family family)
        {
            if(family==Family.Grandfather)
            {
                Console.WriteLine("Grandfather handle this.");
            }
            else{
                Console.WriteLine("Grandfather cant handle this.");
                nextHandler.Handle(family);
            }
        }
    }
    public class FatherHandler : Handler
    {
        public override void Handle(Family family)
        {
            if(family==Family.Father)
            {
                Console.WriteLine("Father handle this.");
            }
            else{
                Console.WriteLine("Father cant handle this.");
                nextHandler.Handle(family);
            }
        }
    }
    public class SonHandler : Handler
    {
        public override void Handle(Family family)
        {
            if(family==Family.Son)
            {
                Console.WriteLine("Son handle this.");
            }
            else{
                Console.WriteLine("Son cant handle this.");
                nextHandler.Handle(family);
            }
        }
    }
}