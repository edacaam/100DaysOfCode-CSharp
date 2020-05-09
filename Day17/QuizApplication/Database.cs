using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuizApplication
{
    class Database
    {
        public List<Question> questions;
        Connection bgl = new Connection();
        public void getAnwers()
        {
            //->Kategori seç
            //->Kategoriye ait soruları çek
            //->Her bir sorunun wronganswerlarını ve correct answerı çek 
            //->Question nesnesine yaz
            //->Nesneyi questions listesine ekle
            //-Tataaaaa


        }

        /* void loadData(int KategoriID)
          {
              getQuestions(int KategoriID);
              for(q in questions)
              {
                  q.WrongAnswers(q.questionID);
                  q.CorrectAnswer(q.questionID);
                  //temel mevzu bu şekilde tamam ben bi uğraşayım tamam çiçeğim, bugece dizi izlemeyelim senin CVyi yapalım tamam bi şey daha sorcam
              }

              q.WrongAnswers(int questionID);
              q.CorrectAnswer(int questionID);
              //Şuan feyz akışı olmuş olmsı lazım load dataya kadar her şey güzeldi gkjhvldfksnfasf single responsibilit
              //ayrı ayrı yazdın fonksiyonları sonra loadData yı çağırdı hoooop hepsi yüklendi
          }
          void getQuestions(int kategoriID) {
              //select from questions find by id bla bla
              //vıdı vıdı veritabanı işlemleri
              //this.questions=veritabanından gelenler bi şey sorcam burda 1 taen soru gelmeyecek mi kategorideki tüm sorular
              //böyle çekicen her bi tabloyu burda yazdığımız mantıkla sonra loadDatada hepsini çalıştırcan
          }
          List<WrongAnswer> getWrongAnswers() {
              List<WrongAnswer> answers;
              //vıdı vıdı veritabanı işlemleri
              return answers;
          }

          CorrectAnswer getCorrectAnswer()
          {
              CorrectAnswer answer;
              //vıdı vıdı veritabanı işlemleri
              return answer;
          }

          //ilk başta yaptığım gibi olmuyo mu o zaman question ayrı bu ayrı, ya iki şekilde de oluyor da bi saniye düşünmem lazımmmmmmmmmmmuaaaaaaah
          //GÖTÜNÜ YERİM :O muckmuckmuckmuck*486556*5959595*yan8 hoaydaaa ;)
          //Kodda yaparsak dediğimi o zaman tüm formlarda bi ton kod yazmak gerekcek, dediğim gibi yapmak daha optimal evet ama şu var

          public List<string> GetQuestions()
          {

              List<string> Questions = new List<string>();
              SqlCommand command = new SqlCommand("Select Question from Tbl_Questions", bgl.connection());
              SqlDataReader dr = command.ExecuteReader();

              while(dr.Read())
              {
                //veritabanından ilk alacağın şey ne ? Atıyorum sports id si ne "6"
                //bu id ile ne çekeceksin soruları çektin ne geldi mmm güzel
                // soru id si mi lazım cevaplarına ulaşmak için evet soru id->7
                // şuan yok olduğunu düşün soru id si 7 olan yanlış cevapları çektin mi yes bunları şimdi listeye
                  //akıyorum o zaman öyle mi aynen önce nesne oluştu sonra listeye
                  //veritabanından bi liste gelmiş olsun içinde yanlış cevaplar var
                  //for (yanlış cevaplar.size kadar döncek)
                  //WrongAnswer answer=new WrongAnswer(text)//bunu bi kere yazsan yeter o nesne text ne burdaki - veritabanından sana dönen wronganswer texti
                  //Question[questionID].wronganswers.add(answer); bu şkeilde ekledin döngü içinde ekliyosun 
                  //evet var mı başka sorunuz sevdiceğim sanırım yok :* seni 2 3 gün kendi haline bırakıyorum sonra yine yapcaz bunu tm kaan abi :** <3<3<3<3<3
                  //böyle dedim diye de takılırsan 2 3 gün sonra sorarım  deme basit bi şeydir hallederiz tm mı tm kaan abi teşekkürler :** Rica ederim çiçeğim :*
              }
              bgl.connection().Close();
              return Questions;
          }*/
        public void AddQuestion(int id, string txt)
        {
            SqlCommand command = new SqlCommand("Insert into Tbl_Questions (Categoryid,Question) values (@p1,@p2)", bgl.connection());
            command.Parameters.AddWithValue("@p1", id);
            command.Parameters.AddWithValue("@p2", txt);
            command.ExecuteNonQuery();
            bgl.connection().Close();
        }
        public void AddCorrectAnswer(int id, string txt)
        {
            SqlCommand command = new SqlCommand("Insert into Tbl_CorrectOptions (Questionid,CorrectOption) values (@p1,@p2)", bgl.connection());
            command.Parameters.AddWithValue("@p1", id);
            command.Parameters.AddWithValue("@p2", txt);
            command.ExecuteNonQuery();
            bgl.connection().Close();
        }
        public void AddWrongAnswer(int id, string txt)
        {
            SqlCommand command = new SqlCommand("Insert into Tbl_WrongOptions (Questionid,WrongOption) values (@p1,@p2)", bgl.connection());
            command.Parameters.AddWithValue("@p1", id);
            command.Parameters.AddWithValue("@p2", txt);
            command.ExecuteNonQuery();
            bgl.connection().Close();
        }
        public void AddQuestionToDB(Question question)
        {
            AddQuestion(question.CategoryType, question.QuestionText);
            SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM Tbl_Questions ORDER BY ID DESC", bgl.connection());
            int quesitonId = (int)command.ExecuteScalar();
            foreach (WrongAnswer answer in question.WrongAnswers)
            {
                AddWrongAnswer(quesitonId, answer.WrongText);
            }
            AddCorrectAnswer(quesitonId, question.CorrectAnswer.CorrectText);
        }
        public void UpdateQuestion(string question,int id)
        {
            SqlCommand command = new SqlCommand("Update Tbl_Questions set Question=@p1 where ID=@p2", bgl.connection());
            command.Parameters.AddWithValue("@p1", question);
            command.Parameters.AddWithValue("@p2", id);
            command.ExecuteNonQuery();
            bgl.connection().Close();
        }
        public void UpdateCanswer(string canswer, int id)
        {
            SqlCommand command = new SqlCommand("Update Tbl_CorrectOptions set CorrectOption=@p1 where Questionid=@p2", bgl.connection());
            command.Parameters.AddWithValue("@p1", canswer);
            command.Parameters.AddWithValue("@p2", id);
            command.ExecuteNonQuery();
            bgl.connection().Close();
        }
        public void UpdateWanswer(string wanswer, int id,int aid)
        {
            SqlCommand command = new SqlCommand("Update Tbl_WrongOptions set WrongOption=@p1 where Questionid=@p2 and ID=@p3", bgl.connection());
            command.Parameters.AddWithValue("@p1", wanswer);
            command.Parameters.AddWithValue("@p2", id);
            command.Parameters.AddWithValue("@p3", aid);
            command.ExecuteNonQuery();
            bgl.connection().Close();
        }

    }
}
