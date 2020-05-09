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
    public partial class FrmQuiz : Form
    {
        public FrmQuiz()
        {
            InitializeComponent();
        }
        Connection bgl = new Connection();
        private void FrmQuiz_Load(object sender, EventArgs e)
        {
            Database db = new Database();
          //  rchTxtBoxQuestions.Text = db.GetQuestions()[3];

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
    }
}
