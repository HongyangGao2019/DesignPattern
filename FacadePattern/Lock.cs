using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Lock
    {
        private bool _locked=false;
        public bool Locked { get=>_locked;private set=>_locked=value; }
        public void LockUp()
        {
            Locked = true;
            Console.WriteLine("Lock up!\n");
        }
        public void Unlock()
        {
            Locked=false;
            Console.WriteLine("Unlock!\n");
        }
    }
}