namespace AdapterPattern
{
    public class Translator
    {
        private IChinese chinese=new Chinese();

        public void Translate()
        {
            chinese.SpeakChinese();
            Console.WriteLine("The only language I know well is Chinese.");
        }
    }
}