using equipsys.LibraryUI;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace equipsys
{
    public partial class BorrowingForm : Form
    {
        SqlConnection sql = new SqlConnection(GlobalConfig.ConnectionString);
        public string ItemName { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public string Stock {  get; set; }
        public string BorrowingImageDisplay {  get; set; }

        string randomID = GenerateRandomID(4); 

        DateTime TimeNow = DateTime.Now;


        public BorrowingForm()
        {
            InitializeComponent();
        }

        private void BORROWING_Load(object sender, EventArgs e)
        {
          
            BorrowingItemName.Text = ItemName;
            BorrowingDescription.Text = Description;
            BorrowingStock.Text = Stock;
            BorrowingImage.Image = new Bitmap(BorrowingImageDisplay);

        }

        private void yearReg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql.Open();
            SqlCommand cmd = sql.CreateCommand();
            SqlCommand cmd2 = sql.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd2.CommandType = System.Data.CommandType.Text;
            //change table name
            cmd.CommandText = "insert into BorrowerHistory values ('" + firstnameReg.Text + "', '" + lastnameReg.Text + "', '" + courseBox.Text + "', '" + yearBox.Text + "','" + SectionBox.Text + "','" + studentidReg.Text + "','" + contactBox.Text + "', '" + EmailBox.Text + "', '" + BorrowingItemName.Text + "', '" + Int32.Parse(comboBox7.Text) + "', '"+ TimeNow +"', '" + EndTime.Text + "','"+ randomID +"', 'Ongoing')";
            cmd2.CommandText = "UPDATE Items set Stock = (Stock - " + Int32.Parse(comboBox7.Text) + ") WHERE ItemName = '"+ BorrowingItemName.Text +"'";
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            sql.Close();
            MessageBox.Show("Record Inserted Successfully \n Your Transaction ID is: " + randomID );

            MAIN mainForm = new MAIN();
            mainForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MAIN mainForm = new MAIN();
            mainForm.Show();
            this.Hide();
        }

        static string GenerateRandomID(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            char[] idArray = new char[length];

            for (int i = 0; i < length; i++)
            {
                idArray[i] = chars[random.Next(chars.Length)];
            }

            return new string(idArray);
        }

        private void courseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (courseBox.SelectedIndex == 0)
                courseBox.Text = "BSCS";
            if (courseBox.SelectedIndex == 1)
                courseBox.Text = "BSEMC";
            if (courseBox.SelectedIndex == 2)
                courseBox.Text = "BSIS";
            if (courseBox.SelectedIndex == 3)
                courseBox.Text = "BSIT";

        }

        private void yearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (yearBox.SelectedIndex == 0)
                yearBox.Text = "1";
            if (yearBox.SelectedIndex == 1)
                yearBox.Text = "2";
            if (yearBox.SelectedIndex == 2)
                yearBox.Text = "3";
            if (yearBox.SelectedIndex == 3)
                yearBox.Text = "4";

        }

        private void SectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (SectionBox.SelectedIndex == 0)
                SectionBox.Text = "A";
            if (SectionBox.SelectedIndex == 1)
                SectionBox.Text = "B";
        }

        private void studentidReg_TextChanged(object sender, EventArgs e)
        {
            studentidReg.Text.ToUpper();
            studentidReg.Text.Trim();
        }

        /// <summary>
        /// Validates the Borrower's Information. 
        /// </summary>
        /// <returns></returns>
        private bool ValidateForm()
        {
            // Helper Methods for Validation

            bool IsValidName(string name) =>
                !string.IsNullOrWhiteSpace(name) && (name.All(char.IsLetter) || name.Contains(" "));

            bool IsValidStudentID(string id) =>
                id.Length == 10 &&
                id.StartsWith("2") &&
                (id.EndsWith("-N") || id.EndsWith("-S")) &&
                id.Substring(1, 7).All(char.IsDigit);

            bool IsValidContactNumber(string number) =>
                number.Length == 10 && number.All(char.IsDigit);

            bool IsValidEmail(string email) =>
                !string.IsNullOrWhiteSpace(email) &&
                Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            bool isValidCount(string number) =>
                number.Length != 0 &&
                number.All(char.IsDigit);

            // Validation Process

            if (!IsValidName(firstnameReg.Text) || !IsValidName(lastnameReg.Text))
                return false;

            if (courseBox.SelectedIndex < 0 || yearBox.SelectedIndex < 0 || SectionBox.SelectedIndex < 0)
                return false;

            if (!IsValidStudentID(studentidReg.Text))
                return false;

            if (!IsValidContactNumber(contactBox.Text))
                return false;

            if (!IsValidEmail(EmailBox.Text))
                return false;

            if (!isValidCount(BorrowCount.Text))
                return false;

            return true;
        }
    }
}

