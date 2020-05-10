using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplication
{
    class Answers
    {
        int questionId;// burda question id tutuyoz ya zaten database de tek bi fonksiyonda otu boku çekmek yerine hepsini ayrı ayrı çeksek
        //sonra da kodun içinde o soru idsine ait olanları alsak daha kolay olur gibi geldi kısaca gösterim
        Answers(int _questionID) {questionId = _questionID; }
    }
}

