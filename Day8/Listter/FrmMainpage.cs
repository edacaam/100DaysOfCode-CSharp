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
   public partial class FrmMainpage : Form
    {
        public static int test;
        public FrmMainpage()
        {
            InitializeComponent();
        }
        public string name;
        public int Userid;
        public int Listid;
        Connection bgl = new Connection();
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
            PicBooks.Visible = false;
            LblBooks.Visible = false;
            PicMovies.Visible = false;
            LblMovies.Visible = false;
            PicSeries.Visible = false;
            LblSeries.Visible = false;
            //LblUser.Text = name.ToString();
        }

        private void PicSettings_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMovies fr = new FrmMovies();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CmbListType.SelectedItem == null)
                MessageBox.Show("Please select a list type!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                SqlCommand command = new SqlCommand("Insert into Tbl_Lists (Userid,ListName,ListType) values (@p1,@p2,@p3)", bgl.connection());
                command.Parameters.AddWithValue("@p1", Userid.ToString());
                command.Parameters.AddWithValue("@p2", TxtListName.Text.ToString());
                command.Parameters.AddWithValue("@p3", CmbListType.SelectedItem.ToString());
                command.ExecuteNonQuery();
                bgl.connection().Close();
                MessageBox.Show("Your list created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SqlCommand command2 = new SqlCommand("Select ID From Tbl_Lists where Userid=@p1 and ListType=@p3", bgl.connection());
                command2.Parameters.AddWithValue("@p1", Userid.ToString());
                command2.Parameters.AddWithValue("@p2", TxtListName.ToString());
                command2.Parameters.AddWithValue("@p3", CmbListType.SelectedItem.ToString());
                command2.ExecuteNonQuery();
                bgl.connection().Close();
                SqlDataReader dr = command2.ExecuteReader();
                while (dr.Read())
                {
                    test = (int)dr[0];
                }
            }

        }
        private void BtnList_Click(object sender, EventArgs e)
        {
            if (CmbListType.SelectedItem == null)
                MessageBox.Show("Please select a list type!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                SqlCommand command1 = new SqlCommand("Select ID,ListName From Tbl_Lists Where ListType=@p1", bgl.connection());
                command1.Parameters.AddWithValue("@p1", CmbListType.SelectedItem.ToString());
                SqlDataAdapter da = new SqlDataAdapter(command1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bgl.connection().Close();
            }

        }

        private void CmbListType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbListType.SelectedItem == null)
                MessageBox.Show("Please select a list type!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (CmbListType.SelectedItem.ToString() == "Books")
                {
                    PicBooks.Visible = true;
                    LblBooks.Visible = true;
                    PicMovies.Visible = false;
                    LblMovies.Visible = false;
                    PicSeries.Visible = false;
                    LblSeries.Visible = false;
                }
                else if (CmbListType.SelectedItem.ToString() == "Movies")
                {
                    PicMovies.Visible = true;
                    LblMovies.Visible = true;
                    PicBooks.Visible = false;
                    LblBooks.Visible = false;
                    PicSeries.Visible = false;
                    LblSeries.Visible = false;

                }
                else if (CmbListType.SelectedItem.ToString() == "Series")
                {
                    PicBooks.Visible = false;
                    LblBooks.Visible = false;
                    PicMovies.Visible = false;
                    LblMovies.Visible = false;
                    PicSeries.Visible = true;
                    LblSeries.Visible = true;
                }
                SqlCommand command1 = new SqlCommand("Select ID,ListName From Tbl_Lists Where ListType=@p1", bgl.connection());
                command1.Parameters.AddWithValue("@p1", CmbListType.SelectedItem.ToString());
                SqlDataAdapter da = new SqlDataAdapter(command1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bgl.connection().Close();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete From Tbl_Lists Where ID=@p1", bgl.connection());
            command.Parameters.AddWithValue("@p1", TxtListid.Text.ToString());
            command.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("List deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtListid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtListName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Tbl_Lists set ListName=@p1 Where ID=@p2", bgl.connection());
            command.Parameters.AddWithValue("@p1", TxtListName.Text.ToString());
            command.Parameters.AddWithValue("@p2", TxtListid.Text.ToString());
            command.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("List updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}


