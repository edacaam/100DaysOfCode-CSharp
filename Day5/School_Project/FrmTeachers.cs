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
    public partial class FrmTeachers : Form
    {
        public FrmTeachers()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-IGQJ2MA;Initial Catalog=BonusOkul;Integrated Security=True");
        DataSet1TableAdapters.TBL_TEACHERSTableAdapter ds = new DataSet1TableAdapters.TBL_TEACHERSTableAdapter();
        void list()
        {
            DataGridView1.DataSource = ds.TeacherList();
        }
        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmTeacher fr = new FrmTeacher();
            fr.Show();
        }

        private void FrmTeachers_Load(object sender, EventArgs e)
        {
            list();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBL_LECTURES", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbBranch.DisplayMember = "LECTURENAME";
            CmbBranch.ValueMember = "LECTUREID";
            CmbBranch.DataSource = dt;
            baglanti.Close();
        }

        private void BtnList_Click_1(object sender, EventArgs e)
        {
            list();
        }

        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            ds.InsertTeacher(TxtTeachername.Text, byte.Parse(CmbBranch.SelectedValue.ToString()));
            MessageBox.Show("Teacher added to the list", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ds.DeleteTeacher(byte.Parse(TxtTeacherid.Text));
            MessageBox.Show("Teacher deleted to the list", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            ds.UpdateTeacher(TxtTeachername.Text, byte.Parse(CmbBranch.SelectedValue.ToString()), byte.Parse(TxtTeacherid.Text));
            MessageBox.Show("Teacher updated to the list", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtTeacherid.Text = DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtTeachername.Text = DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            CmbBranch.Text = DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
