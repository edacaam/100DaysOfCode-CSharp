using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplication
{
    class WrongAnswer
    {
        private string wrongtext;
        private int questionID;
        public WrongAnswer()
        {

        }
        public string WrongText { get => wrongtext; set => wrongtext = value; }
        public int QuestionID { get => questionID; set => questionID = value; }

    }
}
