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
        public string QuestionText { get => questionText; set => questionText = value; }
        public CorrectAnswer CorrectAnswer { get => correctAnswer; set => correctAnswer = value; }
        public List<WrongAnswer> WrongAnswers { get => wrongAnswers; set => wrongAnswers = value; }
        public int CategoryType { get => categoryType; set => categoryType = value; }

    }
}
