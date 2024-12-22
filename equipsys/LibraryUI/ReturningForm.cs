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
                cmd2.CommandText = "UPDATE Items set Stock = Stock + (Select Quantity from BorrowerHistory WHERE Transaction_ID = '" + TransactionIDValue.Text + "') WHERE Item_ID = (Select Item_ID From Items WHERE ItemName = (Select Item_Name From BorrowerHistory where Transaction_ID = '" + TransactionIDValue.Text + "'))";
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
            if (!IsValidStudentID(StudentIDValue.Text))
                return false;

            if (!IsValidTransactionID(TransactionIDValue.Text))
                return false;

            if (!IsOngoingTransaction(StudentIDValue.Text, TransactionIDValue.Text))
                return false;

            return true;
        }

        private bool IsValidStudentID(string id)
        {
            using SqlConnection sql = new(GlobalConfig.ConnectionString);
            sql.Open();
            string studentIDQuery = "SELECT Student_ID FROM BorrowerHistory WHERE Student_ID = '" + StudentIDValue.Text + "' and Status = 'Ongoing'";
            SqlCommand cmd = new(studentIDQuery, sql);
            if ((string)cmd.ExecuteScalar() == id)
            {
                sql.Close();
                return true;
            }
            else
            {
                sql.Close();
                MessageBox.Show("Student ID not found");
                return false;
            }
        }

        private bool IsValidTransactionID(string id)
        {
            using SqlConnection sql = new(GlobalConfig.ConnectionString);
            sql.Open();
            string transactionIDQuery = "SELECT Status from BorrowerHistory where Transaction_ID = '" + TransactionIDValue.Text + "'";
            SqlCommand cmd = new(transactionIDQuery, sql);
            if ((string)cmd.ExecuteScalar() == "Ongoing")
            {
                sql.Close();
                return true;
            }
            else if ((string)cmd.ExecuteScalar() == "Returned")
            {
                sql.Close();
                MessageBox.Show("Transaction is not ongoing");
                return false;
            }
            else
            {
                sql.Close();
                MessageBox.Show("Transaction not found");
                return false;
            }
        }

        private bool IsOngoingTransaction(string sID, string tID)
        {
            using SqlConnection sql = new(GlobalConfig.ConnectionString);
            sql.Open();
            string ongoingTransactionQuery = "SELECT Status from BorrowerHistory where Student_ID = '" + sID + "' and Transaction_ID = '" + tID + "'";
            SqlCommand cmd = new(ongoingTransactionQuery, sql);
            if ((string)cmd.ExecuteScalar() == "Ongoing")
            {
                sql.Close();
                return true;
            }
            else if ((string)cmd.ExecuteScalar() == "Returned")
            {
                sql.Close();
                MessageBox.Show("Transaction is not ongoing");
                return false;
            }
            else
            {
                sql.Close();
                MessageBox.Show("Transaction not found");
                return false;
            }
        }
    }
}
