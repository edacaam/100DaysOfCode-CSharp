using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplication
{

    class CorrectAnswer
    {
        private string correctText;
        private int questionID;

        public CorrectAnswer()
        {

        }
        public string CorrectText { get => correctText; set => correctText = value; }
        public int QuestionID { get => questionID; set => questionID = value; }
    }
}
   
