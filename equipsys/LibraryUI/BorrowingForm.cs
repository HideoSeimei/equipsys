﻿using equipsys.LibraryUI;
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
        public string Stock { get; set; }
        public string BorrowingImageDisplay { get; set; }

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
            try
            {
                BorrowingImage.Image = new Bitmap(BorrowingImageDisplay);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void yearReg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                sql.Open();
                SqlCommand cmd = sql.CreateCommand();
                SqlCommand cmd2 = sql.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd2.CommandType = System.Data.CommandType.Text;
                //change table name
                cmd.CommandText = "insert into BorrowerHistory values ('" + FirstNameValue.Text + "', '" + LastNameValue.Text + "', '" + CourseValue.Text + "', '" + YearValue.Text + "','" + SectionValue.Text + "','" + StudentIDValue.Text + "','" + ContactNumberValue.Text + "', '" + EmailValue.Text + "', '" + BorrowingItemName.Text + "', '" + Int32.Parse(BorrowStockValue.Text) + "', '" + TimeNow + "', '" + EndTime.Text + "','" + randomID + "', 'Ongoing')";
                cmd2.CommandText = "UPDATE Items set Stock = (Stock - " + Int32.Parse(BorrowStockValue.Text) + ") WHERE ItemName = '" + BorrowingItemName.Text + "'";
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("Record Inserted Successfully \n Your Transaction ID is: " + randomID);

                MAIN mainForm = new MAIN();
                mainForm.Show();
                this.Close();
            }

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
            if (CourseValue.SelectedIndex == 0)
                CourseValue.Text = "BSCS";
            if (CourseValue.SelectedIndex == 1)
                CourseValue.Text = "BSEMC";
            if (CourseValue.SelectedIndex == 2)
                CourseValue.Text = "BSIS";
            if (CourseValue.SelectedIndex == 3)
                CourseValue.Text = "BSIT";

        }

        private void yearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (YearValue.SelectedIndex == 0)
                YearValue.Text = "1";
            if (YearValue.SelectedIndex == 1)
                YearValue.Text = "2";
            if (YearValue.SelectedIndex == 2)
                YearValue.Text = "3";
            if (YearValue.SelectedIndex == 3)
                YearValue.Text = "4";

        }

        private void SectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (SectionValue.SelectedIndex == 0)
                SectionValue.Text = "A";
            if (SectionValue.SelectedIndex == 1)
                SectionValue.Text = "B";
        }

        private void studentidReg_TextChanged(object sender, EventArgs e)
        {
            StudentIDValue.Text.ToUpper();
            StudentIDValue.Text.Trim();
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
                number.All(char.IsDigit) &&
                int.Parse(number) <= int.Parse(Stock.Substring(8)) &&
                int.Parse(number) > 0;

            // Validation Process

            if (!IsValidName(FirstNameValue.Text) || !IsValidName(LastNameValue.Text))
            {
                MessageBox.Show("Invalid first or last name");
                return false;
            }
            if (CourseValue.SelectedIndex < 0 || YearValue.SelectedIndex < 0 || SectionValue.SelectedIndex < 0)
            {
                MessageBox.Show("Invalid course/year/section");
                return false;
            }
            if (!IsValidStudentID(StudentIDValue.Text))
            {
                MessageBox.Show("Invalid student id.");
                return false;
            }

            if (!IsValidContactNumber(ContactNumberValue.Text))
            {
                MessageBox.Show("Invalid contact number");
                return false;
            }

            if (!IsValidEmail(EmailValue.Text))
            {
                MessageBox.Show("Invalid email");
                return false;
            }

            if (!isValidCount(BorrowStockValue.Text))
            {
                MessageBox.Show("Invalid Stock.");
                return false;
            }

            return true;
        }
        private void BorrowingImage_Click(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

