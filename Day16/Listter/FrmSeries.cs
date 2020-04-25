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
    public partial class FrmSeries : Form
    {
        public FrmSeries()
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
        private void PicAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Insert into Tbl_Series (SeriesName,EpisodeTime,SeriesDirector,SeriesLanguage,SeriesStars,SeriesType,SeriesStatus,SeriesYear,SeasonNumber,SeriesPhoto) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.connection());
            command.Parameters.AddWithValue("@p1", TxtName.Text);
            command.Parameters.AddWithValue("@p2", MtxtTime.Text);
            command.Parameters.AddWithValue("@p3", TxtDirector.Text);
            command.Parameters.AddWithValue("@p4", CmbLanguage.Text);
            command.Parameters.AddWithValue("@p5", TxtStars.Text);
            command.Parameters.AddWithValue("@p6", CmbType.Text);
            if (RBtnFinal.Checked==true)
            {
                command.Parameters.AddWithValue("@p7",true);
            }
            else
                command.Parameters.AddWithValue("@p7",false);
            command.Parameters.AddWithValue("@p8", CmbYear.Text);
            command.Parameters.AddWithValue("@p9", CmbSeason.Text);
            command.Parameters.AddWithValue("@p10", TxtPhoto.Text);
            command.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Your registration has been completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        bool status;
        void repeated()
        {
            SqlCommand command = new SqlCommand("Select * from Tbl_ListContents where Listid=@p1 AND Seriesid=@p2", bgl.connection());
            command.Parameters.AddWithValue("@p1", FrmMainpage.Listid);
            command.Parameters.AddWithValue("@p2", seriesid);
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
        void list()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Series", bgl.connection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void PicList_Click(object sender, EventArgs e)
        {
            list();
        }
        private void PicUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Tbl_Series set SeriesName=@p1,EpisodeTime=@p2,SeriesDirector=@p3,SeriesLanguage=@p4,SeriesStars=@p5,SeriesType=@p6,SeriesStatus=@p7,SeriesYear=@p8,SeasonNumber=@p9,SeriesPhoto=@p10 where ID=@p11", bgl.connection());
            command.Parameters.AddWithValue("@p1", TxtName.Text);
            command.Parameters.AddWithValue("@p2", MtxtTime.Text);
            command.Parameters.AddWithValue("@p3", TxtDirector.Text);
            command.Parameters.AddWithValue("@p4", CmbLanguage.Text);
            command.Parameters.AddWithValue("@p5", TxtStars.Text);
            command.Parameters.AddWithValue("@p6", CmbType.Text);
            if (RBtnFinal.Checked == true)
            {
                command.Parameters.AddWithValue("@p7", true);
            }
            else
                command.Parameters.AddWithValue("@p7", false);
            command.Parameters.AddWithValue("@p8",CmbYear.Text);
            command.Parameters.AddWithValue("@p9", CmbSeason.Text);
            command.Parameters.AddWithValue("@p10", TxtPhoto.Text);
            command.Parameters.AddWithValue("@p11", TxtSeriesid.Text);
            command.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Series updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }
        public int seriesid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtSeriesid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                TxtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                MtxtTime.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                TxtDirector.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                CmbLanguage.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                TxtStars.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                CmbType.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                if (dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString() == "True")
                    RBtnFinal.Checked = true;
                else if (dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString() == "False")
                    RBtnContinuing.Checked = true;
                CmbYear.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                CmbSeason.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                TxtPhoto.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                pictureBox1.ImageLocation = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                seriesid = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            }
            catch (Exception)
            {
                MessageBox.Show("Please click on the cell", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PicDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from Tbl_Series where ID=@p1", bgl.connection());
            command.Parameters.AddWithValue("@p1", TxtSeriesid.Text);
            command.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Series deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select *From Tbl_Series where SeriesName like '" + TxtSearch.Text + "%'", bgl.connection());
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
        private void PicSelect_Click(object sender, EventArgs e)
        {
            repeated();
            if(status==true)
            {
                SqlCommand command = new SqlCommand("Insert into Tbl_ListContents (Listid,Seriesid) values (@p1,@p2)", bgl.connection());
                command.Parameters.AddWithValue("@p1", FrmMainpage.Listid);
                command.Parameters.AddWithValue("@p2", seriesid);
                command.ExecuteNonQuery();
                bgl.connection().Close();
                MessageBox.Show("Movie added to list", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("This series is already added to the list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
