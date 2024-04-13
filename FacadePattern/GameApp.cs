using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class GameApp
    {
        public void StartGame()
        {
            Console.WriteLine("Start game now!\n");
        }
        public void StopGame(){
            Console.WriteLine("Game Over\n");
        }
    }
}