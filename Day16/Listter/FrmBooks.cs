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
    public partial class FrmBooks : Form
    {
        public FrmBooks()
        {
            InitializeComponent();
        }
        Connection bgl = new Connection();
        private void PicBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMainpage.mpg.Show();
            this.Close();
        }
        private void PicExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void list()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Books", bgl.connection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        bool status;
        void repeated()
        {
            SqlCommand command = new SqlCommand("Select * from Tbl_ListContents where Listid=@p1 AND Bookid=@p2", bgl.connection());
            command.Parameters.AddWithValue("@p1", FrmMainpage.Listid);
            command.Parameters.AddWithValue("@p2",bookid);
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
        private void PicList_Click(object sender, EventArgs e)
        {
            list();
        }
        private void PicAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Insert into Tbl_Books (BookName,BookPages,BookAuthor,BookLanguage,BookType,BookPhoto) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.connection());
            command.Parameters.AddWithValue("@p1", TxtName.Text);
            command.Parameters.AddWithValue("@p2", TxtPages.Text);
            command.Parameters.AddWithValue("@p3", TxtAuthor.Text);
            command.Parameters.AddWithValue("@p4", CmbLanguage.Text);
            command.Parameters.AddWithValue("@p5", CmbType.Text);
            command.Parameters.AddWithValue("@p6", TxtPhoto.Text);
            command.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Your registration has been completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void PicUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Tbl_Books set BookName=@p1,BookPages=@p2,BookAuthor=@p3,BookLanguage=@p4,BookType=@p5,BookPhoto=@p6 where ID=@p8", bgl.connection());
            command.Parameters.AddWithValue("@p1", TxtName.Text);
            command.Parameters.AddWithValue("@p2", TxtPages.Text);
            command.Parameters.AddWithValue("@p3", TxtAuthor.Text);
            command.Parameters.AddWithValue("@p4", CmbLanguage.Text);
            command.Parameters.AddWithValue("@p5", CmbType.Text);
            command.Parameters.AddWithValue("@p6", TxtPhoto.Text);
            command.Parameters.AddWithValue("@p8", TxtBookid.Text);
            command.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Book updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }
        private void PicDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from Tbl_Books where ID=@p1", bgl.connection());
            command.Parameters.AddWithValue("@p1", TxtBookid.Text);
            command.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Book deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select *From Tbl_Books where BookName like '" + TxtSearch.Text + "%'", bgl.connection());
            command.Parameters.AddWithValue("@p1", TxtSearch.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void BtnPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            TxtPhoto.Text = openFileDialog1.FileName;
        }
        public int bookid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtBookid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                TxtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtPages.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                TxtAuthor.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                CmbLanguage.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                CmbType.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                TxtPhoto.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                pictureBox1.ImageLocation = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                bookid = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            }
            catch (Exception)
            {
                MessageBox.Show("Please click on the cell", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PicSelect_Click(object sender, EventArgs e)
        {
            repeated();
            if (status == true)
            {
                SqlCommand command = new SqlCommand("Insert into Tbl_ListContents (Listid,Bookid) values (@p1,@p2)", bgl.connection());
                command.Parameters.AddWithValue("@p1", FrmMainpage.Listid);
                command.Parameters.AddWithValue("@p2", bookid);
                command.ExecuteNonQuery();
                bgl.connection().Close();
                MessageBox.Show("Book added to list", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("This book is already added to the list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
