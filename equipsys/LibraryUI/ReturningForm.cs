using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
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
            SqlCommand cmd2 = sql.CreateCommand(); 
            cmd.CommandType = CommandType.Text;
            cmd2.CommandType = CommandType.Text;
            cmd.CommandText = "update BorrowerHistory set Status = 'Returned' WHERE Student_ID = '" + ItemNameBox.Text + "' and Transaction_ID = '" + ItemDescriptionBox.Text + "'";
            cmd2.CommandText = "UPDATE Items set Stock = Stock + (Select Quantity from BorrowerHistory WHERE Transaction_ID = '"+ ItemDescriptionBox.Text +"') WHERE ItemName = (Select Item_Name From BorrowerHistory WHERE Transaction_ID = '"+ItemDescriptionBox.Text+"')";
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            sql.Close();
            MessageBox.Show("Status updated successfully");
        }

        private void ItemDescriptionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ItemNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
