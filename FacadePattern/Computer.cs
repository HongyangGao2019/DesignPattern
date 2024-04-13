namespace FacadePattern
{
    public class Computer
    {
        Power power;
        Lock @lock;
        GameApp gameApp;
        public Computer()
        {
            power = new Power();
            @lock = new Lock();
            gameApp= new GameApp();
        }

        ConsoleKeyInfo inputKey;
        public void Use()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----Power On:   key A   ----");
            Console.WriteLine("-----------------------------");

            while(!power.Powered)
            {
                inputKey=Console.ReadKey(true);
                Console.WriteLine("");
                switch (inputKey.Key)
                {
                    case ConsoleKey.A:{
                        power.PowerOn();
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Please input again!\a");
                        break;
                    }

                }
            }

            while(power.Powered){
                Console.WriteLine("------------------------------");
                Console.WriteLine("---- Power Off:  key B   -----");
                Console.WriteLine("---- Lockup:     key C   -----");
                Console.WriteLine("---- Unlock:     key D   -----");
                Console.WriteLine("---- Start Game: key E   -----");
                Console.WriteLine("---- Stop Game:  key F   -----");
                Console.WriteLine("------------------------------");
                inputKey=Console.ReadKey(true);
                Console.WriteLine("");
                switch (inputKey.Key){
                    case ConsoleKey.B:{
                        power.PowerOff();
                        break;
                    }
                    case ConsoleKey.C:{
                        @lock.LockUp();
                        break;
                    }
                    case ConsoleKey.D:{
                        @lock.Unlock();
                        break;
                    }
                    case ConsoleKey.E:{
                        gameApp.StartGame();
                        break;
                    }
                    case ConsoleKey.F:{
                        gameApp.StopGame();
                        break;
                    }
                    default:{
                        Console.WriteLine("Please input again.\a");
                        break;
                    }
                }
            }
        }
    }
}