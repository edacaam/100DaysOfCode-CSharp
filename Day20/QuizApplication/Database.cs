using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuizApplication
{
    class Database
    {
        public List<Question> questions = new List<Question>();
        Connection bgl = new Connection();
        public void loadData(int kategoriId)
        {
            getQuestions(kategoriId);
            foreach (var item in questions)
            {
                getWrongAnswers(item);
                getCorrectAnswer(item);
            }
        }
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
        }
        bool player;
        void repeatedplayer(string nick)
        {
            SqlCommand command = new SqlCommand("Select * from Tbl_Players where NickName=@p1", bgl.connection());
            command.Parameters.AddWithValue("@p1", nick);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                player = false;
            }
            else
            {
                player = true;
            }
            bgl.connection().Close();
        }
        public int AddPlayer(string txt)
        {
            repeatedplayer(txt);
            if (player == true)
            {
                SqlCommand command = new SqlCommand("Insert into Tbl_Players (NickName,Score) values (@p1,@p2)", bgl.connection());
                command.Parameters.AddWithValue("@p1", txt);
                command.Parameters.AddWithValue("@p2", 0);
                command.ExecuteNonQuery();
                bgl.connection().Close();
                return 1;
            }
            else
                return 0;
        }
        public void DeletePlayer()
        {
            SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM Tbl_Players ORDER BY ID DESC", bgl.connection());
            int playerId = (int)command.ExecuteScalar();
            SqlCommand command2 = new SqlCommand("Delete from Tbl_Players where ID=@p1", bgl.connection());
            command2.Parameters.AddWithValue("@p1",playerId);
            command2.ExecuteNonQuery();
            bgl.connection().Close();
        }
       
        public void AddScore(int score, int type)
        {
            SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM Tbl_Players ORDER BY ID DESC", bgl.connection());
            int playerId = (int)command.ExecuteScalar();
            SqlCommand command2 = new SqlCommand("Update Tbl_Players set Type=@p1,Score=@p2 where ID=@p3", bgl.connection());
            command2.Parameters.AddWithValue("@p1", type);
            command2.Parameters.AddWithValue("@p2", score );
            command2.Parameters.AddWithValue("@p3", playerId);
            command2.ExecuteNonQuery();
            bgl.connection().Close();
        }
        public DataTable ListScore(int type)
        {
            SqlCommand command1 = new SqlCommand("SELECT NickName,Score FROM Tbl_Players WHERE Type=@p1", bgl.connection());
            command1.Parameters.AddWithValue("@p1",type);
            SqlDataAdapter da = new SqlDataAdapter(command1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void ResetScore()
        {
            SqlCommand command = new SqlCommand("Delete from Tbl_Players", bgl.connection());
            command.ExecuteNonQuery();
            bgl.connection().Close();
        }
        bool status;
        void repeated(string question)
        {
            SqlCommand command = new SqlCommand("Select * from Tbl_Questions where Question=@p1", bgl.connection());
            command.Parameters.AddWithValue("@p1",question);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                status = false;
            }
            else
            {
                status = true;
            }
            bgl.connection().Close();
        }
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
            repeated(question.QuestionText);
            if (status == true)
            {
                AddQuestion(question.CategoryType, question.QuestionText);
                SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM Tbl_Questions ORDER BY ID DESC", bgl.connection());
                int quesitonId = (int)command.ExecuteScalar();
                for (int i = 0; i < 3; i++)
                {
                    AddWrongAnswer(quesitonId, question.WrongAnswers[i].WrongText);
                }
                AddCorrectAnswer(quesitonId, question.CorrectAnswer.CorrectText);
            }
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
        
        public DataTable ListQuestion(int type)
        {
            SqlCommand command = new SqlCommand("SELECT ID,Question FROM Tbl_Questions WHERE Categoryid=@p1", bgl.connection());
            command.Parameters.AddWithValue("@p1",type);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bgl.connection().Close();
            return dt;
        }
        public DataTable ViewCategory()
        {
            SqlCommand command = new SqlCommand("Select * From Tbl_Categories", bgl.connection());
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bgl.connection().Close();
            return dt;
        }
       public DataTable ListCorrectAnswer(int id)
       {
            SqlCommand command = new SqlCommand("SELECT CorrectOption FROM Tbl_CorrectOptions WHERE Questionid=@p1", bgl.connection());
            command.Parameters.AddWithValue("@p1",id);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            bgl.connection().Close();
        }
        public DataTable ListWrongAnswers(int id)
        {
            SqlCommand command = new SqlCommand("SELECT ID,WrongOption FROM Tbl_WrongOptions WHERE Questionid=@p1", bgl.connection());
            command.Parameters.AddWithValue("@p1", id);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
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
