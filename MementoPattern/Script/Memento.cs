namespace MementoPattern
{
    public class Memento
    {
        private string mementoName;
        private DateTime saveTime;
        public Memento(string mementoName)
        {
            this.mementoName=mementoName;
            saveTime= DateTime.Now;
        }
        public string MementoName{
            get=>mementoName;
            // set{
            //     mementoName=value;
            //     saveTime=DateTime.Now;
            // }
        }
        public DateTime SaveTime{get=>saveTime;}
    }
}