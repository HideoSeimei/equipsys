using equipsys.LibraryUI;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace equipsys
{
    public partial class HistoryLogForm : Form
    {
        SqlConnection sql = new SqlConnection(GlobalConfig.ConnectionString);

        public HistoryLogForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HistoryLogForm_Load(object sender, EventArgs e)
        {
            gridbind();
        }

        private void gridbind()
        {
            sql.Open();
            SqlCommand cmd = new SqlCommand("select * from BorrowerHistory", sql);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            sql.Close();
        }

        private void SaveItemButton_Click(object sender, EventArgs e)
        {
            gridbind();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            ReturningForm returnform = new ReturningForm();
            returnform.Show();
        }
    }
}
