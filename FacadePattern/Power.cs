using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Power
    {
        private bool _powered=false;
        public bool Powered { get=>_powered;private set=>_powered=value; }
        public void PowerOn()
        {
            Powered=true;
            Console.WriteLine("开机了！\n");
        }
        public void PowerOff()
        {
            Powered=false;
            Console.WriteLine("关机了！\n");
        }
    }
}