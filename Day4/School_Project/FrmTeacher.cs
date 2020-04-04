using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Project
{
    public partial class FrmTeacher : Form
    {
        public FrmTeacher()
        {
            InitializeComponent();
        }
        private void BtnClub_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmClub fr = new FrmClub();
            fr.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 fr = new Form1();
            fr.Show();
        }

        private void BtnCourse_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLesson fr = new FrmLesson();
            fr.Show();
        }

        private void BtnClub_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FrmClub fr = new FrmClub();
            fr.Show();
        }

        private void BtnStudent_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmStudent fr = new FrmStudent();
            fr.Show();
        }

        private void BtnExam_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPoints fr = new FrmPoints();
            fr.Show();
        }
    }
}
