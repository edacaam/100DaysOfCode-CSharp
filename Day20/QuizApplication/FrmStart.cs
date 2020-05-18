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
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmAdministration fr = new FrmAdministration();
            this.Hide();
            fr.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if(txtPlayer.Text=="")
            {
                MessageBox.Show("Please enter nickname","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                Database db = new Database();
                int i = db.AddPlayer(txtPlayer.Text);
                if (i==1)
                {
                    FrmMainpage fr = new FrmMainpage();
                    fr.Show();
                }
                else
                    MessageBox.Show("Please choose another username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
