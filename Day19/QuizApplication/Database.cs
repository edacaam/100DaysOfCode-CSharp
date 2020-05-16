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
        public List<Question> questions = new List<Question>();
        Connection bgl = new Connection();
        //public void getAnwers()
        //{
        //    //->Kategori seç
        //    //->Kategoriye ait soruları çek
        //    //->Her bir sorunun wronganswerlarını ve correct answerı çek 
        //    //->Question nesnesine yaz
        //    //->Nesneyi questions listesine ekle
        //    //-Tataaaaa


        //}

        public void loadData(int kategoriId)
        {
            getQuestions(kategoriId);
            foreach (var item in questions)
            {
                getWrongAnswers(item);
                getCorrectAnswer(item);
            }
        }
        //Şuan feyz akışı olmuş olmsı lazım load dataya kadar her şey güzeldi gkjhvldfksnfasf single responsibilit
        //ayrı ayrı yazdın fonksiyonları sonra loadData yı çağırdı hoooop hepsi yüklendi
        // }
        private void getQuestions(int kategoriID)
        {
            SqlCommand command = new SqlCommand("Select ID , Question From Tbl_Questions where Categoryid=@p1", bgl.connection());
            command.Parameters.AddWithValue("@p1", kategoriID);
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                Question question = new Question();
                question.QuestionID = Convert.ToInt32(dr[0]);
                question.QuestionText = dr[1].ToString();
                questions.Add(question);
            }
            //this.questions = veritabanından gelenler bi şey sorcam burda 1 taen soru gelmeyecek mi kategorideki tüm sorular
            //  böyle çekicen her bi tabloyu burda yazdığımız mantıkla sonra loadDatada hepsini çalıştırcan
        }
        private void getWrongAnswers(Question q)
        {            
            SqlCommand command = new SqlCommand("Select WrongOption From Tbl_WrongOptions where Questionid=@p1", bgl.connection());
            command.Parameters.AddWithValue("@p1", q.QuestionID);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                WrongAnswer answer = new WrongAnswer();
                answer.WrongText = dr[0].ToString();
                q.WrongAnswers.Add(answer);
            }
            //vıdı vıdı veritabanı işlemleri           
        }

        private void getCorrectAnswer(Question q)
        {           
            SqlCommand command = new SqlCommand("Select CorrectOption From Tbl_CorrectOptions where Questionid=@p1", bgl.connection());
            command.Parameters.AddWithValue("@p1", q.QuestionID);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                CorrectAnswer answer = new CorrectAnswer();
                answer.CorrectText = dr[0].ToString();
                q.CorrectAnswer = answer;
            }
            //vıdı vıdı veritabanı işlemleri
        }

        //ilk başta yaptığım gibi olmuyo mu o zaman question ayrı bu ayrı, ya iki şekilde de oluyor da bi saniye düşünmem lazımmmmmmmmmmmuaaaaaaah
        //GÖTÜNÜ YERİM :O muckmuckmuckmuck*486556*5959595*yan8 hoaydaaa ;)
        //Kodda yaparsak dediğimi o zaman tüm formlarda bi ton kod yazmak gerekcek, dediğim gibi yapmak daha optimal evet ama şu var

        //public List<string> GetQuestions()
        //{

        //    List<string> Questions = new List<string>();
        //    SqlCommand command = new SqlCommand("Select Question from Tbl_Questions", bgl.connection());
        //    SqlDataReader dr = command.ExecuteReader();

        //    while (dr.Read())
        //    {
        //        //veritabanından ilk alacağın şey ne ? Atıyorum sports id si ne "6"
        //        //bu id ile ne çekeceksin soruları çektin ne geldi mmm güzel
        //        // soru id si mi lazım cevaplarına ulaşmak için evet soru id->7
        //        // şuan yok olduğunu düşün soru id si 7 olan yanlış cevapları çektin mi yes bunları şimdi listeye
        //        //akıyorum o zaman öyle mi aynen önce nesne oluştu sonra listeye
        //        //veritabanından bi liste gelmiş olsun içinde yanlış cevaplar var
        //        //for (yanlış cevaplar.size kadar döncek)
        //        //WrongAnswer answer=new WrongAnswer(text)//bunu bi kere yazsan yeter o nesne text ne burdaki - veritabanından sana dönen wronganswer texti
        //        //Question[questionID].wronganswers.add(answer); bu şkeilde ekledin döngü içinde ekliyosun 
        //        //evet var mı başka sorunuz sevdiceğim sanırım yok :* seni 2 3 gün kendi haline bırakıyorum sonra yine yapcaz bunu tm kaan abi :** <3<3<3<3<3
        //        //böyle dedim diye de takılırsan 2 3 gün sonra sorarım  deme basit bi şeydir hallederiz tm mı tm kaan abi teşekkürler :** Rica ederim çiçeğim :*
        //    }
        //    bgl.connection().Close();
        //    return Questions;
        //}
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
        public void UpdateQuestion(string question, int id)
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
        public void UpdateWanswer(string wanswer, int id, int aid)
        {
            SqlCommand command = new SqlCommand("Update Tbl_WrongOptions set WrongOption=@p1 where Questionid=@p2 and ID=@p3", bgl.connection());
            command.Parameters.AddWithValue("@p1", wanswer);
            command.Parameters.AddWithValue("@p2", id);
            command.Parameters.AddWithValue("@p3", aid);
            command.ExecuteNonQuery();
            bgl.connection().Close();
        }
        public void DeleteQuestion(int id)
        {
            SqlCommand command = new SqlCommand("Delete from Tbl_Questions where ID=@p1", bgl.connection());
            command.Parameters.AddWithValue("@p1", id);
            command.ExecuteNonQuery();
            bgl.connection().Close();
        }
        public void DeleteCanswer(int id)
        {
            SqlCommand command = new SqlCommand("Delete from Tbl_CorrectOptions where Questionid=@p1", bgl.connection());
            command.Parameters.AddWithValue("@p1", id);
            command.ExecuteNonQuery();
            bgl.connection().Close();
        }
        public void DeleteWanswer(int id)
        {
            SqlCommand command = new SqlCommand("Delete from Tbl_WrongOptions where Questionid=@p1", bgl.connection());
            command.Parameters.AddWithValue("@p1", id);
            command.ExecuteNonQuery();
            bgl.connection().Close();
        }
        public bool Login(string username, string password)
        {
            SqlCommand command = new SqlCommand("Select ID From Tbl_Users where Username=@p1 and UserPassword=@p2", bgl.connection());
            command.Parameters.AddWithValue("@p1", username);
            command.Parameters.AddWithValue("@p2", password);
            SqlDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {
                FrmManagement fr = new FrmManagement();
                fr.Show();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
