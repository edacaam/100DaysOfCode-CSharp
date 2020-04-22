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
        Connection bgl=new Connection();
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

        private void FrmListView_Load(object sender, EventArgs e)
        {
            try
            {
                if (FrmMainpage.type == "Movies")
                {
                    SqlCommand command1 = new SqlCommand("SELECT Tbl_Movies.MovieName FROM Tbl_ListContents,Tbl_Lists,Tbl_Movies WHERE Tbl_ListContents.Listid=Tbl_Lists.ID AND Tbl_ListContents.Movieid=Tbl_Movies.ID And Tbl_Lists.ID=@p1", bgl.connection());
                    command1.Parameters.AddWithValue("@p1", FrmMainpage.Listid);
                    SqlDataAdapter da = new SqlDataAdapter(command1);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    bgl.connection().Close();
                }
                else if (FrmMainpage.type == "Books")
                {
                    SqlCommand command1 = new SqlCommand("SELECT Tbl_Books.BookName FROM Tbl_ListContents,Tbl_Lists,Tbl_Books WHERE Tbl_ListContents.Listid=Tbl_Lists.ID AND Tbl_ListContents.Bookid=Tbl_Books.ID And Tbl_Lists.ID=@p1", bgl.connection());
                    command1.Parameters.AddWithValue("@p1", FrmMainpage.Listid);
                    SqlDataAdapter da = new SqlDataAdapter(command1);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    bgl.connection().Close();
                }
                else if (FrmMainpage.type == "Series")
                {
                    SqlCommand command1 = new SqlCommand("SELECT Tbl_Series.SeriesName FROM Tbl_ListContents,Tbl_Lists,Tbl_Series WHERE Tbl_ListContents.Listid=Tbl_Lists.ID AND Tbl_ListContents.Seriesid=Tbl_Series.ID And Tbl_Lists.ID=@p1", bgl.connection());
                    command1.Parameters.AddWithValue("@p1", FrmMainpage.Listid);
                    SqlDataAdapter da = new SqlDataAdapter(command1);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    bgl.connection().Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
