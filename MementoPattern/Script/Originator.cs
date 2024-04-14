namespace MementoPattern
{
    public class Originator
    {
        private string _mementoName="";
        private DateTime _mementoSaveTime;
        private List<Memento> _mementos=new List<Memento>();

        public string MementoName{get=>_mementoName;private set{_mementoName=value; }}
        public DateTime MementoSaveTime{get=>_mementoSaveTime;private set=>_mementoSaveTime=value;}
        public List<Memento> Mementos{get=>_mementos;}
        public void SetCurrentMemento(Memento memento)
        {
            if(!Mementos.Contains(memento))
            {
                Console.WriteLine("没找到当前备忘录！");
                return;
            }
            MementoName=memento.MementoName;
            MementoSaveTime=memento.SaveTime;
        }
        public void ShowMemento()
        {
            Console.WriteLine($"存档名字：{MementoName}  \n保存时间：{MementoSaveTime}");
        }
        public Memento CreateMemento()
        {
            Memento memento= new Memento("Default Name");
            Mementos.Add(memento);
            return memento;
        }
        public Memento CreateMemento(string mementoName)
        {
            Memento memento= new Memento(mementoName);
            Mementos.Add(memento);
            return memento;
        }
        public bool DeleteMemento(Memento memento)
        {
            if(Mementos.Contains(memento))
            {
                Mementos.Remove(memento);
                return true;
            }
            return false;
        }
        public void ShowMementos()
        {
            Console.WriteLine("------Mementos Show Start-----");
            foreach(Memento memento in Mementos)
            {
                Console.WriteLine($"存档名字：{memento.MementoName}  \n保存时间：{memento.SaveTime}");
            }
            Console.WriteLine("------Mementos Show End-------");
        }

    }
}