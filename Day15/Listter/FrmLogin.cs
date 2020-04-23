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

namespace Listter
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        Connection bgl = new Connection();
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

        private void LblSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSignup fr = new FrmSignup();
            fr.Show();
        }
        
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select ID From Tbl_Users where Username=@p1 and UserPassword=@p2", bgl.connection());
            command.Parameters.AddWithValue("@p1", TxtUserName.Text);
            command.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dr = command.ExecuteReader();
           
            if (dr.Read())
            { 
                FrmMainpage fr = new FrmMainpage();
                fr.Userid=(int)dr[0];
                fr.name = TxtUserName.Text.ToUpper();
                fr.Show();
                this.Hide();
            }
            else
            { 
                MessageBox.Show("Incorrect user information.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtPassword.BackColor = Color.IndianRed;
            }
        }
    }
}
