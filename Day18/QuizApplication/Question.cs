using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplication
{
    class Question
    {
        private string questionText;
        private CorrectAnswer correctAnswer;
        private List<WrongAnswer> wrongAnswers;
        private int categoryType;
       
     

        //public Question(string questionText, CorrectAnswer correctAnswer,List<WrongAnswer> wrongAnswers)
        //{
        //    this.QuestionText = questionText;
        //    this.CorrectAnswer = correctAnswer;
        //    this.WrongAnswers = wrongAnswers;
        //}
        public string QuestionText { get => questionText; set => questionText = value; }
        public CorrectAnswer CorrectAnswer { get => correctAnswer; set => correctAnswer = value; }
        public List<WrongAnswer> WrongAnswers { get => wrongAnswers; set => wrongAnswers = value; }
        public int CategoryType { get => categoryType; set => categoryType = value; }

    }
}
