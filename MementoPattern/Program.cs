using MementoPattern;


Originator originator= new Originator();
Caretaker caretaker=new Caretaker(originator.CreateMemento());
originator.CreateMemento("Hello");
originator.CreateMemento("Bye");
originator.SetCurrentMemento(caretaker.CurrentMemento);
originator.ShowMemento();
Console.WriteLine("------------------");
originator.ShowMementos();
Console.ReadKey();

// Console.WriteLine("------Memento Pattern------");
// do{
//     Console.WriteLine("Key A: Create new memento.");
//     Console.WriteLine("Key B: Delete current memento.");
//     Console.WriteLine("Key C: Show current memento.");
//     Console.WriteLine("Key D: Show all mementos.");
//     ConsoleKeyInfo consoleKey= Console.ReadKey();
//     switch (consoleKey.Key)
//     {
//         case ConsoleKey.A:
//         {

//             break;
//         }
//     }

// }while (Console.ReadKey(true).Key!=ConsoleKey.Enter);

    