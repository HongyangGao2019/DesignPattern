namespace PrototypePattern
{
    public class Quiz : ICloneable
    {
        private string question1;
        private string question2;
        private string question3;
        private char? answer1;
        private char? answer2;
        private char? answer3;
        public void SetQuestions(string question1, string question2, string question3){
            this.question1 = question1;
            this.question2 = question2;
            this.question3 = question3;
        }
        public void SetAnswer(char? answer1, char? answer2,char? answer3){
            this.answer1 = answer1;
            this.answer2 = answer2;
            this.answer3 = answer3;
        }
        public void Display()
        {
            Console.WriteLine("---Questions--Answers---");
            Console.WriteLine($"question 1:{question1} answer 1:{answer1}");
            Console.WriteLine($"question 2:{question2} answer 2:{answer2}");
            Console.WriteLine($"question 3:{question3} answer 3:{answer3}");            
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}