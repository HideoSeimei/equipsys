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

namespace equipsys.LibraryUI
{
    public partial class ReturningForm : Form
    {
        SqlConnection sql = new SqlConnection(GlobalConfig.ConnectionString);

        public ReturningForm()
        {
            InitializeComponent();
        }

        private void ReturningForm_Load(object sender, EventArgs e)
        {

        }

        private void SaveItemButton_Click(object sender, EventArgs e)
        {
            sql.Open();
            SqlCommand cmd = sql.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update history set Status = 'Returned' WHERE Student_ID = '" + ItemNameBox.Text + "' and Item_Name = '" + ItemDescriptionBox.Text + "' and Time_Start = '" + ItemStockBox.Text + "'";
            cmd.ExecuteNonQuery();
            sql.Close();
            MessageBox.Show("Status updated successfully");
        }
    }
}
