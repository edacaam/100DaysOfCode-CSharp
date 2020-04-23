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
    public partial class FrmListView : Form
    {
        public FrmListView()
        {
            InitializeComponent();
        }
        Connection bgl = new Connection();
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMainpage.mpg.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void list()
        {
            try
            {
                if (FrmMainpage.type == "Movies")
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.Columns.Clear();
                    int i = 0;
                    SqlCommand command1 = new SqlCommand("SELECT Tbl_Movies.ID, Tbl_Movies.MovieName,Tbl_Movies.MoviePhoto FROM Tbl_ListContents,Tbl_Lists,Tbl_Movies WHERE Tbl_ListContents.Listid=Tbl_Lists.ID AND Tbl_ListContents.Movieid=Tbl_Movies.ID And Tbl_Lists.ID=@p1", bgl.connection());
                    command1.Parameters.AddWithValue("@p1", FrmMainpage.Listid);
                    SqlDataAdapter da = new SqlDataAdapter(command1);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    Bitmap img;
                    DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                    imageCol.HeaderText = "Movie Photo";
                    imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    imageCol.Width = 100;
                    dataGridView1.Columns.Add(imageCol);

                    foreach (DataRow dr in dt.Rows)
                    {
                        img = new Bitmap(dr[2].ToString());
                        dataGridView1.Rows[i].Cells[3].Value = img;
                        dataGridView1.Rows[i].Height = 100;
                        i++;
                    }
                    this.dataGridView1.Columns[0].Visible = false;
                    this.dataGridView1.Columns[2].Visible = false;
                    bgl.connection().Close();
                }
                else if (FrmMainpage.type == "Books")
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.Columns.Clear();
                    int i = 0;
                    SqlCommand command1 = new SqlCommand("SELECT Tbl_Books.ID,Tbl_Books.BookName,Tbl_Books.BookPhoto FROM Tbl_ListContents,Tbl_Lists,Tbl_Books WHERE Tbl_ListContents.Listid=Tbl_Lists.ID AND Tbl_ListContents.Bookid=Tbl_Books.ID And Tbl_Lists.ID=@p1", bgl.connection());
                    command1.Parameters.AddWithValue("@p1", FrmMainpage.Listid);
                    SqlDataAdapter da = new SqlDataAdapter(command1);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    Bitmap img;
                    DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                    imageCol.HeaderText = "Book Photo";
                    imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    imageCol.Width =100;
                    dataGridView1.Columns.Add(imageCol);

                    foreach (DataRow dr in dt.Rows)
                    {
                        img = new Bitmap(dr[2].ToString());
                        dataGridView1.Rows[i].Cells[3].Value = img;
                        dataGridView1.Rows[i].Height = 100;
                        i++;
                    }
                    this.dataGridView1.Columns[0].Visible = false;
                    this.dataGridView1.Columns[2].Visible = false;
                    bgl.connection().Close();
                }
                else if (FrmMainpage.type == "Series")
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.Columns.Clear();
                    int i = 0;
                    SqlCommand command1 = new SqlCommand("SELECT Tbl_Series.ID,Tbl_Series.SeriesName,Tbl_Series.SeriesPhoto FROM Tbl_ListContents,Tbl_Lists,Tbl_Series WHERE Tbl_ListContents.Listid=Tbl_Lists.ID AND Tbl_ListContents.Seriesid=Tbl_Series.ID And Tbl_Lists.ID=@p1", bgl.connection());
                    command1.Parameters.AddWithValue("@p1", FrmMainpage.Listid);
                    SqlDataAdapter da = new SqlDataAdapter(command1);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    Bitmap img;
                    DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                    imageCol.HeaderText = "Series Photo";
                    imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    imageCol.Width = 100;
                    dataGridView1.Columns.Add(imageCol);

                    foreach (DataRow dr in dt.Rows)
                    {
                        img = new Bitmap(dr[2].ToString());
                        dataGridView1.Rows[i].Cells[3].Value = img;
                        dataGridView1.Rows[i].Height = 75;
                        i++;
                    }
                    this.dataGridView1.Columns[0].Visible = false;
                    this.dataGridView1.Columns[2].Visible = false;
                    bgl.connection().Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrmListView_Load(object sender, EventArgs e)
        {
            list();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            if (FrmMainpage.type == "Movies")
            {
                SqlCommand command = new SqlCommand("Delete from Tbl_ListContents where Listid=@p1 AND Movieid=@p2", bgl.connection());
                command.Parameters.AddWithValue("@p1", FrmMainpage.Listid);
                command.Parameters.AddWithValue("@p2", Lblid.Text);
                command.ExecuteNonQuery();
                bgl.connection().Close();
                MessageBox.Show("Movie deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (FrmMainpage.type == "Books")
            {
                SqlCommand command = new SqlCommand("Delete from Tbl_ListContents where Listid=@p1 AND Bookid=@p2", bgl.connection());
                command.Parameters.AddWithValue("@p1", FrmMainpage.Listid);
                command.Parameters.AddWithValue("@p2", Lblid.Text);
                command.ExecuteNonQuery();
                bgl.connection().Close();
                MessageBox.Show("Book deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (FrmMainpage.type == "Series")
            {
                SqlCommand command = new SqlCommand("Delete from Tbl_ListContents where Listid=@p1 AND Seriesid=@p2", bgl.connection());
                command.Parameters.AddWithValue("@p1", FrmMainpage.Listid);
                command.Parameters.AddWithValue("@p2", Lblid.Text);
                command.ExecuteNonQuery();
                bgl.connection().Close();
                MessageBox.Show("Series deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            list();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Lblid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                TxtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please click on the cell", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (FrmMainpage.type == "Movies")
            {
                SqlCommand command1 = new SqlCommand("SELECT Tbl_Movies.ID, Tbl_Movies.MovieName FROM Tbl_ListContents,Tbl_Lists,Tbl_Movies WHERE Tbl_ListContents.Listid=Tbl_Lists.ID AND Tbl_ListContents.Movieid=Tbl_Movies.ID And Tbl_Lists.ID=@p1 And MovieName like '" + TxtSearch.Text + "%'", bgl.connection());
                command1.Parameters.AddWithValue("@p1", FrmMainpage.Listid);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command1);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (FrmMainpage.type == "Books")
            {
                SqlCommand command1 = new SqlCommand("SELECT Tbl_Books.ID, Tbl_Books.BookName FROM Tbl_ListContents,Tbl_Lists,Tbl_Books WHERE Tbl_ListContents.Listid=Tbl_Lists.ID AND Tbl_ListContents.Bookid=Tbl_Books.ID And Tbl_Lists.ID=@p1 And BookName like '" + TxtSearch.Text + "%'", bgl.connection());
                command1.Parameters.AddWithValue("@p1", FrmMainpage.Listid);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command1);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (FrmMainpage.type == "Series")
            {
                SqlCommand command1 = new SqlCommand("SELECT Tbl_Series.ID, Tbl_Series.SeriesName FROM Tbl_ListContents,Tbl_Lists,Tbl_Series WHERE Tbl_ListContents.Listid=Tbl_Lists.ID AND Tbl_ListContents.Seriesid=Tbl_Series.ID And Tbl_Lists.ID=@p1 And SeriesName like '" + TxtSearch.Text + "%'", bgl.connection());
                command1.Parameters.AddWithValue("@p1", FrmMainpage.Listid);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command1);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            this.dataGridView1.Columns[0].Visible = false;
            bgl.connection().Close();
        }
    }
}
