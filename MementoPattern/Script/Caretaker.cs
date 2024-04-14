namespace MementoPattern
{
    //看管备忘录者
    public class Caretaker
    {
        private Memento _currentMemento;
        public Memento CurrentMemento{get=>_currentMemento;set=>_currentMemento=value;}
        public Caretaker(Memento memento)
        {
            CurrentMemento=memento;
        }
    }
}