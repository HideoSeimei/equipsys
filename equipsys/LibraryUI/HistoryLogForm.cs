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

        DataTable dataTable = new DataTable();

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

        public void gridbind()
        {
            sql.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM BorrowerHistory ORDER BY Start_Time", sql);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            sql.Close();

            dataGridView1.DataSource = dataTable;
        }


        private void SaveItemButton_Click(object sender, EventArgs e)
        {
            gridbind();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            ReturningForm returnform = new ReturningForm(this);
            returnform.Show();
        }

        private void SearchBarValue_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource is DataTable dataTable)
            {
                string filterText = SearchBarValue.Text.Trim();

                string filterExpression = string.IsNullOrEmpty(filterText)
                    ? ""
                    : $"FirstName LIKE '%{filterText}%' OR LastName LIKE '%{filterText}%' OR Course LIKE '%{filterText}%' OR Year LIKE '%{filterText}%' OR Section LIKE '%{filterText}%' OR Student_ID LIKE '%{filterText}%' OR Contact_Number LIKE '%{filterText}%' OR Email LIKE '%{filterText}%' OR Item_Name LIKE '%{filterText}%' OR Start_Time LIKE '%{filterText}%' OR End_Time LIKE '%{filterText}%' OR Transaction_ID LIKE '%{filterText}%' OR Status LIKE '%{filterText}%'";

                (dataTable.DefaultView).RowFilter = filterExpression;
            }
        }
    }
}
