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
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        void list()
        {
            dataGridView1.DataSource = ds.StudentList();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmTeacher fr = new FrmTeacher();
            fr.Show();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-IGQJ2MA;Initial Catalog=BonusOkul;Integrated Security=True");
        private void FrmStudent_Load(object sender, EventArgs e)
        {
           list();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBL_CLUBS",baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbClub.DisplayMember = "CLUBNAME";
            CmbClub.ValueMember = "CLUBID";
            CmbClub.DataSource = dt;
            baglanti.Close();

        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            list();
        }
        string gender = " ";
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ds.InsertStudent(TxtCStudentname.Text, TxtStudentsurname.Text, byte.Parse(CmbClub.SelectedValue.ToString()),gender);
            MessageBox.Show("Student added to the list", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ds.DeleteStudent(int.Parse(TxtStudentid.Text));
            list();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtStudentid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtCStudentname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtStudentsurname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            CmbClub.Text= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() == "Boy")
                radioButton2.Checked = true;
            if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() == "Girl")
                radioButton1.Checked = true;


        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            ds.UpdateStudent(TxtCStudentname.Text, TxtStudentsurname.Text,byte.Parse(CmbClub.SelectedValue.ToString()),gender,int.Parse(TxtStudentid.Text));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                gender = "Girl";
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                gender = "Boy";
            }
        }

        private void pictureSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=ds.SearchStudent(TxtSearch.Text);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
