using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApplication
{
    public partial class FrmQuiz : Form
    {
        public FrmQuiz()
        {
            InitializeComponent();
        }
        int i = 0;
        int counter;
        public void viewdata()
        {
            Random rand = new Random();
            int sayi = rand.Next(65, 69);
            char karakter = Convert.ToChar(sayi);
            if (i < db.questions.Count())
            {
                rchTxtBoxQuestions.Text = db.questions[i].QuestionText;
                if (karakter == 'A')
                {
                    BtnA.Text = db.questions[i].CorrectAnswer.CorrectText;
                    BtnB.Text = db.questions[i].WrongAnswers[0].WrongText;
                    BtnC.Text = db.questions[i].WrongAnswers[1].WrongText;
                    BtnD.Text = db.questions[i].WrongAnswers[2].WrongText;
                }
                if (karakter == 'B')
                {
                    BtnA.Text = db.questions[i].WrongAnswers[0].WrongText;
                    BtnB.Text = db.questions[i].CorrectAnswer.CorrectText;
                    BtnC.Text = db.questions[i].WrongAnswers[1].WrongText;
                    BtnD.Text = db.questions[i].WrongAnswers[2].WrongText;
                }
                if (karakter == 'C')
                {
                    BtnA.Text = db.questions[i].WrongAnswers[0].WrongText;
                    BtnB.Text = db.questions[i].WrongAnswers[1].WrongText;
                    BtnC.Text = db.questions[i].CorrectAnswer.CorrectText;
                    BtnD.Text = db.questions[i].WrongAnswers[2].WrongText;
                }
                if (karakter == 'D')
                {
                    BtnA.Text = db.questions[i].WrongAnswers[0].WrongText;
                    BtnB.Text = db.questions[i].WrongAnswers[1].WrongText;
                    BtnC.Text = db.questions[i].WrongAnswers[2].WrongText;
                    BtnD.Text = db.questions[i].CorrectAnswer.CorrectText;
                }
            }
            i++;
        }
        Database db = new Database();
        private void FrmQuiz_Load(object sender, EventArgs e)
        {
            db.loadData(FrmMainpage.type);
            viewdata();
        }
        private void PicExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnAgain_Click(object sender, EventArgs e)
        {
            FrmMainpage fr = new FrmMainpage();
            fr.Show();
            this.Close();
        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            BtnA.BackColor = Color.Transparent;
            BtnB.BackColor = Color.Transparent;
            BtnC.BackColor = Color.Transparent;
            BtnD.BackColor = Color.Transparent;
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            viewdata();
            if(i==db.questions.Count())
            {
                picFinish.Visible = true;
            }
            if(i == db.questions.Count()+1)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
            }
        }
        private void BtnA_Click(object sender, EventArgs e)
        {
            if (BtnA.Text == db.questions[i-1].CorrectAnswer.CorrectText)
            {
                counter++;
                lblSkor.Text = counter.ToString();
                BtnA.BackColor = Color.Green;
            }
            else
                BtnA.BackColor = Color.Red;
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
        }
        private void BtnB_Click(object sender, EventArgs e)
        {
            try
            {
                if (BtnB.Text == db.questions[i - 1].CorrectAnswer.CorrectText)
                {
                    counter++;
                    lblSkor.Text = counter.ToString();
                    BtnB.BackColor = Color.Green;
                }
                else
                    BtnB.BackColor = Color.Red;
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("You have already made a choice.");
            }
        }
        private void BtnC_Click(object sender, EventArgs e)
        {
            if (BtnC.Text == db.questions[i - 1].CorrectAnswer.CorrectText)
            {
                counter++;
                lblSkor.Text = counter.ToString();
                BtnC.BackColor = Color.Green;
            }
            else
                BtnC.BackColor = Color.Red;
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
        }
        private void BtnD_Click(object sender, EventArgs e)
        {
            if (BtnD.Text == db.questions[i - 1].CorrectAnswer.CorrectText)
            {
                counter++;
                lblSkor.Text = counter.ToString();
                BtnD.BackColor = Color.Green;
            }
            else
                BtnD.BackColor = Color.Red;
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
        }
    }
}
