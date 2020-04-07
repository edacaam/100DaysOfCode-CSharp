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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PbVisible_Click(object sender, EventArgs e)
        {
            PbVisible.Hide();
            TxtPassword.UseSystemPasswordChar = false;
            PbUnvisible.Show();
        }

        private void PbUnvisible_Click(object sender, EventArgs e)
        {
            PbUnvisible.Hide();
            TxtPassword.UseSystemPasswordChar = true;
            PbVisible.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PbVisible.Show();
            PbUnvisible.Hide();
        }

        private void PbOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
