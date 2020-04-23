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
        bool status;
        void repeated()
        {
            SqlCommand command = new SqlCommand("Select * from Tbl_Users where Username=@p1", bgl.connection());
            command.Parameters.AddWithValue("@p1",TxtUserName.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                status = false;
            }
            else
            {
                status = true;
            }
            bgl.connection().Close();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Connection bgl = new Connection();
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            repeated();
            if(status==true)
            {
                SqlCommand command = new SqlCommand("Insert into Tbl_Users (Username,Userpassword) values (@p1,@p2)", bgl.connection());
                command.Parameters.AddWithValue("@p1", TxtUserName.Text);
                command.Parameters.AddWithValue("@p2", TxtPassword.Text);
                command.ExecuteNonQuery();
                bgl.connection().Close();
                MessageBox.Show("Your registration has been completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("This user already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
