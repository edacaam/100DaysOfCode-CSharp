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
        private List<WrongAnswer> wrongAnswers=new List<WrongAnswer>();
        private int categoryType;
        private int questionID;

        public Question()
        {

        }
        //public Question(int questionID,int categoryType,string questionText, CorrectAnswer correctAnswer, List<WrongAnswer> wrongAnswers)
        //{
        //    this.QuestionText = questionText;
        //    this.CorrectAnswer = correctAnswer;
        //    this.WrongAnswers = wrongAnswers;
        //    this.QuestionID = questionID;
        //    this.CategoryType= categoryType;
        //}
        public string QuestionText { get => questionText; set => questionText = value; }
        public CorrectAnswer CorrectAnswer { get => correctAnswer; set => correctAnswer = value; }
        public List<WrongAnswer> WrongAnswers { get => wrongAnswers; set => wrongAnswers = value; }
        public int CategoryType { get => categoryType; set => categoryType = value; }
        public int QuestionID { get => questionID; set => questionID = value; }

    }
}
