using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listter
{
    public partial class FrmMainpage : Form
    {
        public FrmMainpage()
        {
            InitializeComponent();
        }
        public string name;
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin fr = new FrmLogin();
            fr.Show();
        }

        private void FrmMainpage_Load(object sender, EventArgs e)
        {
            LblUser.Text = name.ToString();
        }
    }
}
