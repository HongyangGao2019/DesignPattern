using StatePattern;

Context context=new Context(new MorningState());
while(Console.ReadKey(true).Key!=ConsoleKey.Enter)
{
    context.Operation();
}