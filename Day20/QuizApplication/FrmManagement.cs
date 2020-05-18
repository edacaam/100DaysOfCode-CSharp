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
            if(rchTxtBoxQuestion.Text == "" || txtCanswer.Text == "" || txtWanswer1.Text == "" || txtWanswer2.Text == "" || txtWanswer3.Text == "")
            {
                MessageBox.Show("Please fill in the blanks", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
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
        }
        int wid1, wid2, wid3;
        private void FrmManagement_Load(object sender, EventArgs e)
        {
            cmbBoxType.DisplayMember = "CategoryName";
            cmbBoxType.ValueMember = "ID";
            cmbBoxType.DataSource = db.ViewCategory();
            bgl.connection().Close();
        }
        void list()
        {
            int type = int.Parse(cmbBoxType.SelectedValue.ToString());
            dataGridView1.DataSource =db.ListQuestion(type);
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
                dataGridView2.DataSource =db.ListCorrectAnswer(questionid);
                dataGridView3.DataSource =db.ListWrongAnswers(questionid);
                dataGridView3.Columns[0].Visible = false;

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
            FrmStart fr = new FrmStart();
            fr.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.ResetScore();
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
            if (rchTxtBoxQuestion.Text == "" || txtCanswer.Text == "" || txtWanswer1.Text == "" || txtWanswer2.Text == "" || txtWanswer3.Text == "")
            {
                MessageBox.Show("Please fill in the blanks", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
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
}
