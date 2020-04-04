using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Project
{
    public partial class FrmLesson : Form
    {
        public FrmLesson()
        {
            InitializeComponent();
        }

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
        DataSet1TableAdapters.TBL_LECTURESTableAdapter ds = new DataSet1TableAdapters.TBL_LECTURESTableAdapter();
        void list()
        {
            dataGridView1.DataSource = ds.DersListesi();
        }
        private void FrmLesson_Load(object sender, EventArgs e)
        {
            list();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ds.AddLesson(TxtLessonname.Text);
            MessageBox.Show("Lesson added to the list", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            list();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ds.DeleteLesson(byte.Parse(TxtLessonid.Text));
            MessageBox.Show("Lesson deleted to the list", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            ds.UpdateLesson(TxtLessonname.Text,(byte.Parse(TxtLessonid.Text)));
            MessageBox.Show("Lesson updated to the list", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtLessonid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtLessonname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
