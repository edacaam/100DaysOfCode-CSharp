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
    public partial class FrmStudentPoints : Form
    {
        public FrmStudentPoints()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-IGQJ2MA;Initial Catalog=BonusOkul;Integrated Security=True");
        public string number;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FrmStudentPoints_Load(object sender, EventArgs e)
        {
            
            SqlCommand komut1 = new SqlCommand("SELECT LECTURENAME,EXAM1,EXAM2,EXAM3,PROJECT,AVERAGE,STATUS FROM TBL_POINTS INNER JOIN TBL_LECTURES ON TBL_POINTS.LECTUREID = TBL_LECTURES.LECTUREID WHERE STDID = @p1", baglanti);
            komut1.Parameters.AddWithValue("@p1", number);
            SqlDataAdapter da = new SqlDataAdapter(komut1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT STDNAME,STDSURNAME FROM TBL_STUDENTS WHERE STDID=@a1", baglanti);
            komut2.Parameters.AddWithValue("@a1", number);
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
               LblStudentid.Text = dr[0] + " " + dr[1];
            }
            baglanti.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 fr = new Form1();
            fr.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
