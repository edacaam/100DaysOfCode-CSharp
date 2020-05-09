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
        public static string type;
        private void FrmMainpage_Load(object sender, EventArgs e)
        {
           
        }

        private void PicExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            type = "History";
            FrmQuiz quiz = new FrmQuiz();
            quiz.Show();
            this.Hide();
        }

        private void BtnScience_Click(object sender, EventArgs e)
        {
            type = "Science";
            FrmQuiz quiz = new FrmQuiz();
            quiz.Show();
            this.Hide();
        }

        private void BtnEntertrainment_Click(object sender, EventArgs e)
        {
            type = "Entertrainment";
            FrmQuiz quiz = new FrmQuiz();
            quiz.Show();
            this.Hide();
        }

        private void BtnArt_Click(object sender, EventArgs e)
        {
            type = "Art";
            FrmQuiz quiz = new FrmQuiz();
            quiz.Show();
            this.Hide();
        }

        private void BtnGeography_Click(object sender, EventArgs e)
        {
            type = "Geography";
            FrmQuiz quiz = new FrmQuiz();
            quiz.Show();
            this.Hide();
        }

        private void BtnSports_Click(object sender, EventArgs e)
        {
            type = "Sports";
            FrmQuiz quiz = new FrmQuiz();
            quiz.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            type = "Mix";
            FrmQuiz quiz = new FrmQuiz();
            quiz.Show();
            this.Hide();
        }
    }
}
