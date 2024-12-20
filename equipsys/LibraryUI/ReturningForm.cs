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
        private HistoryLogForm _historyLogForm;
        SqlConnection sql = new SqlConnection(GlobalConfig.ConnectionString);

        public ReturningForm(HistoryLogForm historyLogForm)
        {
            InitializeComponent();
            _historyLogForm = historyLogForm;
        }

        private void ReturningForm_Load(object sender, EventArgs e)
        {

        }

        private void SaveItemButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                sql.Open();
                SqlCommand cmd = sql.CreateCommand();
                SqlCommand cmd2 = sql.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd2.CommandType = CommandType.Text;
                cmd.CommandText = "update BorrowerHistory set Status = 'Returned' WHERE Student_ID = '" + StudentIDValue.Text + "' and Transaction_ID = '" + TransactionIDValue.Text + "'";
                cmd2.CommandText = "UPDATE Items set Stock = Stock + (Select Quantity from BorrowerHistory WHERE Transaction_ID = '" + TransactionIDValue.Text + "') WHERE ItemName = (Select Item_Name From BorrowerHistory WHERE Transaction_ID = '" + TransactionIDValue.Text + "')";
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("Status updated successfully"); 
                _historyLogForm.gridbind();
                this.Hide();
                
            }
            
        }


        private bool ValidateForm()
        {
            bool IsValidStudentID(string id) =>
                id.Length == 10 &&
                id.StartsWith("2") &&
                (id.EndsWith("-N") || id.EndsWith("-S")) &&
                id.Substring(1, 7).All(char.IsDigit);

            bool IsValidTransactionID(string id) =>
                id.Length == 4 &&
                id.All(char.IsLetterOrDigit);

            if (!IsValidStudentID(StudentIDValues.Text))
            {
                MessageBox.Show("Invalid Student ID.");
                return false;
            }

            if (!IsValidTransactionID(TransactionIDValue.Text))
            {
                MessageBox.Show("Invalid Transaction ID.");
                return false;
            }

            return true;
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
