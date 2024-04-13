using PrototypePattern;

QuizPaper parentQuizPaper=new QuizPaper(new PaperInfo(null,null));
Quiz quiz=new Quiz();
quiz.SetQuestions("你好吗？","你吃了吗？","你今天怎么样");
QuizPaper[] printPapers=new QuizPaper[10];



for(int i=0;i<printPapers.Length;i++)
{
    printPapers[i]=(QuizPaper)parentQuizPaper.Clone();
}

parentQuizPaper.SetInfo("Mr.Li",null);
parentQuizPaper.SetAnswer('c','b','d');
parentQuizPaper.school="XXXXXXXXXXXX";

parentQuizPaper.Show();
foreach(QuizPaper quizPaper in printPapers){
    quizPaper.Show();
}




