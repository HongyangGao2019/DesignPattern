using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterPattern
{
    interface IChinese{
        void SpeakChinese();
    }
    public class Chinese : IChinese
    {
        public void SpeakChinese()
        {
            Console.WriteLine("我只会说中文。");
        }
    } 
}