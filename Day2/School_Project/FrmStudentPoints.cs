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
            SqlCommand komut1 = new SqlCommand("Select * From TBL_POINTS where STDID=@p1", baglanti);
            komut1.Parameters.AddWithValue("@p1", number);
            this.Text = number.ToString();
            SqlDataAdapter da = new SqlDataAdapter(komut1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
