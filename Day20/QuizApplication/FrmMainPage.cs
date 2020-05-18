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
    public partial class FrmMainpage : Form
    {
        public FrmMainpage()
        {
            InitializeComponent();
        }
        public static int type;
        private void PicExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnHistory_Click(object sender, EventArgs e)
        {
            type = 1;
            FrmQuiz quiz = new FrmQuiz();
            quiz.Show();
            this.Hide();
        }
        private void BtnScience_Click(object sender, EventArgs e)
        {
            type = 2;
            FrmQuiz quiz = new FrmQuiz();
            quiz.Show();
            this.Hide();
        }
        private void BtnEntertrainment_Click(object sender, EventArgs e)
        {
            type = 3;
            FrmQuiz quiz = new FrmQuiz();
            quiz.Show();
            this.Hide();
        }
        private void BtnArt_Click(object sender, EventArgs e)
        {
            type = 4;
            FrmQuiz quiz = new FrmQuiz();
            quiz.Show();
            this.Hide();
        }
        private void BtnGeography_Click(object sender, EventArgs e)
        {
            type = 5;
            FrmQuiz quiz = new FrmQuiz();
            quiz.Show();
            this.Hide();
        }
        private void BtnSports_Click(object sender, EventArgs e)
        {
            type = 6;
            FrmQuiz quiz = new FrmQuiz();
            quiz.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            type = 7;
            FrmQuiz quiz = new FrmQuiz();
            quiz.Show();
            this.Hide();
        }
    }
}
