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
        public static FrmMainpage mpg;
        //public static int test;
        public FrmMainpage()
        {
            mpg = this;
            InitializeComponent();
        }
        public string name;
        public int Userid;
        public static int Listid;
        public static string type;
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
            LblVisible.Visible = false;
            PicMovies.Visible = false;
            PicSeries.Visible = false;
           // LblUser.Text = name.ToString();
        }

        private void PicSettings_Click(object sender, EventArgs e)
        {
            try
            {
                Listid = Convert.ToInt32(TxtListid.Text);
                this.Hide();
                FrmMovies fr = new FrmMovies();
                fr.ShowDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("Error! Make sure to fill all the columns", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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
                //test = Convert.ToInt32(TxtListid.Text);
                ////while (dr.Read())
                //{
                //    test = (int)dr[0];
                //}
            }

        }
        private void BtnList_Click(object sender, EventArgs e)
        {
            label3.Text = Userid.ToString();
            if (CmbListType.SelectedItem == null)
                MessageBox.Show("Please select a list type!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                SqlCommand command1 = new SqlCommand("Select ID,ListName From Tbl_Lists Where ListType=@p1 and Userid=@p2", bgl.connection());
                command1.Parameters.AddWithValue("@p1", CmbListType.SelectedItem.ToString());
                command1.Parameters.AddWithValue("@p2", Userid.ToString());
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
                    LblVisible.Visible = true;
                    PicBooks.Visible = true;
                    LblVisible.Text = "BOOKS";
                    PicMovies.Visible = false;
                    PicSeries.Visible = false;
                    
                }
                else if (CmbListType.SelectedItem.ToString() == "Movies")
                {
                    LblVisible.Visible = true;
                    PicMovies.Visible = true;
                    PicBooks.Visible = false;
                    LblVisible.Text ="MOVIES";
                    PicSeries.Visible = false;
                   

                }
                else if (CmbListType.SelectedItem.ToString() == "Series")
                {
                    LblVisible.Visible = true;
                    PicBooks.Visible = false;
                    LblVisible.Text ="SERIES";
                    PicMovies.Visible = false;
                    PicSeries.Visible = true;
                }
                SqlCommand command1 = new SqlCommand("Select ID,ListName From Tbl_Lists Where ListType=@p1 and Userid=@p2", bgl.connection());
                command1.Parameters.AddWithValue("@p1", CmbListType.SelectedItem.ToString());
                command1.Parameters.AddWithValue("@p2",Userid.ToString());
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

        private void PicBooks_Click(object sender, EventArgs e)
        {
            Listid = Convert.ToInt32(TxtListid.Text);
            this.Hide();
            FrmBooks fr = new FrmBooks();
            fr.Show();
        }

        private void PicSeries_Click(object sender, EventArgs e)
        {
            Listid = Convert.ToInt32(TxtListid.Text);
            this.Hide();
            FrmSeries fr = new FrmSeries();
            fr.Show();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            try
            {
                Listid = Convert.ToInt32(TxtListid.Text);
                type = CmbListType.SelectedItem.ToString();
                if (CmbListType.SelectedItem == null)
                    MessageBox.Show("Please select a list type!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    this.Hide();
                    FrmListView fr = new FrmListView();
                    fr.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata!");
            }
          
        }
    }

}


