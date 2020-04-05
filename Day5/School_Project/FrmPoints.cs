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
    public partial class FrmPoints : Form
    {

        public FrmPoints()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.TBL_POINTSTableAdapter ds = new DataSet1TableAdapters.TBL_POINTSTableAdapter();

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.PointList(int.Parse(TxtStudentid.Text));
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-IGQJ2MA;Initial Catalog=BonusOkul;Integrated Security=True");
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmTeacher fr = new FrmTeacher();
            fr.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPoints_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBL_LECTURES", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbLesson.DisplayMember = "LECTURENAME";
            CmbLesson.ValueMember = "LECTUREID";
            CmbLesson.DataSource = dt;
            baglanti.Close();
        }
        int notid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notid=int.Parse( dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            TxtStudentid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
           CmbLesson.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtExam1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtExam2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtExam3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            TxtProject.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            TxtAverage.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            TxtStatus.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
        int exam1, exam2, exam3, project;

        private void BtnClean_Click(object sender, EventArgs e)
        {
            TxtStudentid.Text =" " ;
            CmbLesson.Text = " ";
            TxtExam1.Text = " ";
            TxtExam2.Text =" " ;
            TxtExam3.Text = " ";
            TxtProject.Text =" " ;
            TxtAverage.Text =" " ;
            TxtStatus.Text =" " ;
        }

        double avg;
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
           
            exam1 = Convert.ToInt32(TxtExam1.Text);
            exam2 = Convert.ToInt32(TxtExam2.Text);
            exam3 = Convert.ToInt32(TxtExam3.Text);
            project = Convert.ToInt32(TxtProject.Text);
            avg = (exam1 + exam2 + exam3 + project) / 4;
            TxtAverage.Text = avg.ToString();
            if (avg >= 50)
            {
                TxtStatus.Text = "True";
            }
            else
                TxtStatus.Text = "False";

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            ds.UpdatePoint(byte.Parse(CmbLesson.SelectedValue.ToString()),int.Parse(TxtStudentid.Text),byte.Parse(TxtExam1.Text), byte.Parse(TxtExam2.Text), byte.Parse(TxtExam3.Text), byte.Parse(TxtProject.Text),decimal.Parse(TxtAverage.Text),bool.Parse(TxtStatus.Text),int.Parse(TxtStudentid.Text));
        }
    }
}
