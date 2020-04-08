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
    public partial class FrmSignup : Form
    {
        public FrmSignup()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin fr = new FrmLogin();
            fr.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Connection bgl = new Connection();
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Insert into Tbl_Users (Username,Userpassword) values (@p1,@p2)",bgl.connection());
            command.Parameters.AddWithValue("@p1", TxtUserName.Text);
            command.Parameters.AddWithValue("@p2", TxtPassword.Text);
            command.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Your registration has been completed","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
