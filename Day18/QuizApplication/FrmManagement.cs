/*
 Created with love of Kaan!<3<3<3<3
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuizApplication
{
    public partial class FrmManagement : Form
    {
        Database db = new Database();
        Question q = new Question();
        CorrectAnswer c = new CorrectAnswer();
        WrongAnswer w1 = new WrongAnswer();
        WrongAnswer w2 = new WrongAnswer();
        WrongAnswer w3 = new WrongAnswer();
        List<WrongAnswer> wrongAnswers = new List<WrongAnswer>();
        public FrmManagement()
        {
            InitializeComponent();
        }
        Connection bgl = new Connection();

        int categoryType;
        string questionText;
        string cAnswer, wAnswer1, wAnswer2, wAnswer3;


        private void btnAdd_Click(object sender, EventArgs e)
        {

            //questionText = rchTxtBoxQuestion.Text;
            //cAnswer = txtCanswer.Text;
            //wAnswer1 = txtWanswer1.Text;
            //wAnswer2 = txtWanswer2.Text;
            //wAnswer3 = txtWanswer3.Text;

            //db.AddQuestion(categoryType, questionText);
            //SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM Tbl_Questions ORDER BY ID DESC", bgl.connection());
            //int quesitonId = (int)command.ExecuteScalar();

            //db.AddWrongAnswer(quesitonId, wAnswer1);
            //db.AddWrongAnswer(quesitonId, wAnswer2);
            //db.AddWrongAnswer(quesitonId, wAnswer3);
            //db.AddCorrectAnswer(quesitonId,cAnswer);
            //foreach (WrongAnswer answer in q.WrongAnswers)
            //{
            //    db.AddWrongAnswer(quesitonId, answer.WrongText);
            //}
            //db.AddCorrectAnswer(quesitonId, q.CorrectAnswer.CorrectText);

            categoryType = int.Parse(cmbBoxType.SelectedValue.ToString());
            q.QuestionText = rchTxtBoxQuestion.Text;
            c.CorrectText = txtCanswer.Text;
            w1.WrongText = txtWanswer1.Text;
            wrongAnswers.Add(w1);
            w2.WrongText = txtWanswer2.Text;
            wrongAnswers.Add(w2);
            w3.WrongText = txtWanswer3.Text;
            wrongAnswers.Add(w3);
            q.CorrectAnswer = c;
            q.WrongAnswers = wrongAnswers;
            q.CategoryType = categoryType;

            db.AddQuestionToDB(q);
            list();


        }
        int wid1, wid2, wid3;
        private void FrmManagement_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From Tbl_Categories", bgl.connection());
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbBoxType.DisplayMember = "CategoryName";
            cmbBoxType.ValueMember = "ID";
            cmbBoxType.DataSource = dt;
            bgl.connection().Close();


            //SqlCommand command1 = new SqlCommand("SELECT Tbl_Questions.ID,Tbl_Questions.Question,Tbl_WrongOptions.WrongOption,Tbl_CorrectOptions.CorrectOption FROM Tbl_Questions,Tbl_WrongOptions,Tbl_CorrectOptions WHERE Tbl_WrongOptions.Questionid=Tbl_Questions.ID AND Tbl_CorrectOptions.Questionid=Tbl_Questions.ID And Tbl_Questions.Categoryid=@p1", bgl.connection());
            //command1.Parameters.AddWithValue("@p1", int.Parse(cmbBoxType.SelectedValue.ToString()));
            //SqlDataAdapter da2 = new SqlDataAdapter(command1);
            //DataTable dt2 = new DataTable();
            //da2.Fill(dt2);
            //dataGridView1.DataSource = dt2;

        }
        void list()
        {
            SqlCommand command1 = new SqlCommand("SELECT ID,Question FROM Tbl_Questions WHERE Categoryid=@p1", bgl.connection());
            command1.Parameters.AddWithValue("@p1", int.Parse(cmbBoxType.SelectedValue.ToString()));
            SqlDataAdapter da2 = new SqlDataAdapter(command1);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            bgl.connection().Close();
            dataGridView1.Columns[0].Visible = false;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;
            rchTxtBoxQuestion.Text = "";
            txtCanswer.Text = "";
            txtWanswer1.Text = "";
            txtWanswer2.Text = "";
            txtWanswer3.Text = "";
        }
        private void cmbBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            list();
        }

       
        int questionid;

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                questionid = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                rchTxtBoxQuestion.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                SqlCommand command1 = new SqlCommand("SELECT CorrectOption FROM Tbl_CorrectOptions WHERE Questionid=@p1", bgl.connection());
                command1.Parameters.AddWithValue("@p1", questionid);
                SqlDataAdapter da2 = new SqlDataAdapter(command1);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView2.DataSource = dt2;
                bgl.connection().Close();

                SqlCommand command2 = new SqlCommand("SELECT ID,WrongOption FROM Tbl_WrongOptions WHERE Questionid=@p1", bgl.connection());
                command2.Parameters.AddWithValue("@p1", questionid);
                SqlDataAdapter da3 = new SqlDataAdapter(command2);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                dataGridView3.DataSource = dt3;
                dataGridView3.Columns[0].Visible = false;
                bgl.connection().Close();

                txtCanswer.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();
                txtWanswer1.Text = dataGridView3.Rows[0].Cells[1].Value.ToString();
                txtWanswer2.Text = dataGridView3.Rows[1].Cells[1].Value.ToString();
                txtWanswer3.Text = dataGridView3.Rows[2].Cells[1].Value.ToString();
                wid1 = (int)dataGridView3.Rows[0].Cells[0].Value;
                wid2 = (int)dataGridView3.Rows[1].Cells[0].Value;
                wid3 = (int)dataGridView3.Rows[2].Cells[0].Value;
            }
            catch (Exception)
            {
                MessageBox.Show("Please click on the cell!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
        private void txtCanswer_TextChanged(object sender, EventArgs e)
        {
            cAnswer = txtCanswer.Text;
        }

        private void rchTxtBoxQuestion_TextChanged(object sender, EventArgs e)
        {
            questionText = rchTxtBoxQuestion.Text;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            db.DeleteQuestion(questionid);
            db.DeleteWanswer(questionid);
            db.DeleteCanswer(questionid);
            list();
        }

        private void PicBack_Click(object sender, EventArgs e)
        {
            FrmMainpage fr = new FrmMainpage();
            fr.Show();
            this.Close();
        }

        private void txtWanswer1_TextChanged(object sender, EventArgs e)
        {
            wAnswer1 = txtWanswer1.Text;
        }
        private void txtWanswer2_TextChanged(object sender, EventArgs e)
        {
            wAnswer2 = txtWanswer2.Text;
        }
        private void txtWanswer3_TextChanged(object sender, EventArgs e)
        {
            wAnswer3 = txtWanswer3.Text;
        }

        private void PicExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                db.UpdateQuestion(questionText, questionid);
                db.UpdateCanswer(cAnswer, questionid);
                db.UpdateWanswer(wAnswer1, questionid, wid1);
                db.UpdateWanswer(wAnswer2, questionid, wid2);
                db.UpdateWanswer(wAnswer3, questionid, wid3);
                list();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select the question you want to change from the list!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
