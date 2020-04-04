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

namespace School_Project
{
    public partial class FrmClub : Form
    {
        public FrmClub()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-IGQJ2MA;Initial Catalog=BonusOkul;Integrated Security=True");
        void list()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_CLUBS", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FrcClub_Load(object sender, EventArgs e)
        {
            list();

        }
        private void BtnList_Click(object sender, EventArgs e)
        {
            list();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TBL_CLUBS (CLUBNAME) VALUES (@p1)",baglanti);
            komut.Parameters.AddWithValue("@p1",TxtClubname.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Club added to list", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.LightYellow;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtClubid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtClubname.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From TBL_CLUBS where CLUBID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtClubid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Clup deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update TBL_CLUBS set CLUBNAME=@p1 where CLUBID=@p2",baglanti);
            komut.Parameters.AddWithValue("@p1", TxtClubname.Text);
            komut.Parameters.AddWithValue("@p2", TxtClubid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Clup updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmTeacher fr = new FrmTeacher();
            fr.Show();
        }
    }
}
