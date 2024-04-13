using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class QuizPaper : ICloneable
    {
        public string school="Ta School";
        private PaperInfo paperInfo;
        private Quiz quiz;
        public QuizPaper(PaperInfo paperInfo)
        {
            this.paperInfo = paperInfo;
            this.quiz = new Quiz();
        }
        private QuizPaper(Quiz quiz)
        {
            this.quiz = quiz;
        }
        public void Show()
        {
            Console.WriteLine($"--------School:{school}-------");
            paperInfo.Display();
            quiz.Display();
        }
        public void SetInfo(string? name,int? id)
        {
            paperInfo.Name=name;
            paperInfo.Id=id;
        }
        public void SetAnswer(char? answer1,char? answer2,char? answer3)
        {
            quiz.SetAnswer(answer1,answer2,answer3);
        }
        public object Clone()
        {
            // return this.MemberwiseClone();
            // QuizPaper quizPaper= new QuizPaper((Quiz)this.quiz.Clone());
            // quizPaper.paperInfo = (PaperInfo)this.paperInfo.Clone();
            QuizPaper quizPaper= new QuizPaper((Quiz)this.quiz.Clone());
            quizPaper.paperInfo =(PaperInfo)this.paperInfo.Clone();
            quizPaper.school=this.school;
            return quizPaper;
        }
    }
}