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
    public partial class FrmAdministration : Form
    {
        public FrmAdministration()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if (db.Login(TxtUserName.Text, TxtPassword.Text) == false)
            {
                MessageBox.Show("Incorrect user information.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtPassword.BackColor = Color.IndianRed;
            }
            else
                this.Close();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMainpage fr = new FrmMainpage();
            fr.Show();
        }
    }
}
