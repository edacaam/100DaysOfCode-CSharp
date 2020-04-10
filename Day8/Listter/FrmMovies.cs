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
    public partial class FrmMovies : Form
    {
        public FrmMovies()
        {
            InitializeComponent();
        }
        Connection bgl = new Connection();
        void list()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Movies", bgl.connection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void PicList_Click(object sender, EventArgs e)
        {
            list();
        }

        private void PicAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Insert into Tbl_Movies (MovieName,MovieTime,MovieYear,MovieDirector,MovieLanguage,MovieStarsID,MovieType) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.connection());
            command.Parameters.AddWithValue("@p1",TxtName.Text);
            command.Parameters.AddWithValue("@p2",MtxtTime.Text);
            command.Parameters.AddWithValue("@p3", CmbYear.Text);
            command.Parameters.AddWithValue("@p4", TxtDirector.Text);
            command.Parameters.AddWithValue("@p5", CmbLanguage.Text);
            command.Parameters.AddWithValue("@p6", TxtStars.Text);
            command.Parameters.AddWithValue("@p7", CmbType.Text);
            command.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Your registration has been completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PicExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PicBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMainpage fr = new FrmMainpage();
            fr.Show();
        }
        private void TxtSearch_TextChanged_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select *From Tbl_Movies where MovieName like '" + TxtSearch.Text + "%'", bgl.connection());
            command.Parameters.AddWithValue("@p1", TxtSearch.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void PicUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Tbl_Movies set MovieName=@p1,MovieTime=@p2,MovieYear=@p3,MovieDirector=@p4,MovieLanguage=@p5,MovieStarsID=@p6,MovieType=@p7 where ID=@p8",bgl.connection());
            command.Parameters.AddWithValue("@p1", TxtName.Text);
            command.Parameters.AddWithValue("@p2", MtxtTime.Text);
            command.Parameters.AddWithValue("@p3", CmbYear.Text);
            command.Parameters.AddWithValue("@p4", TxtDirector.Text);
            command.Parameters.AddWithValue("@p5", CmbLanguage.Text);
            command.Parameters.AddWithValue("@p6", TxtStars.Text);
            command.Parameters.AddWithValue("@p7", CmbType.Text);
            command.Parameters.AddWithValue("@p8", TxtMovieid.Text);
            command.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Movie updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
            
        }

        private void PicDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from Tbl_Movies where ID=@p1", bgl.connection());
            command.Parameters.AddWithValue("@p1", TxtMovieid.Text);
            command.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Movie deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtMovieid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtName.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            MtxtTime.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            CmbYear.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtDirector.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            CmbLanguage.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            TxtStars.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            CmbType.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }
    }
}
