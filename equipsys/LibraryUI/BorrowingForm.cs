using equipsys.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace equipsys
{
    public partial class BorrowingForm : Form
    {
        public BorrowingForm()
        {
            InitializeComponent();
        }

        // Validates the form's contents to see if the form has any incorrect data. If valid, creates the transaction
        private void BorrowButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                BorrowerModel newBorrowerModel = new BorrowerModel(FirstNameTextBox.Text, LastNameTextBox.Text, CourseComboBox.Text, YearComboBox.Text, SectionComboBox.Text, StudentIDTextBox.Text, ContactNumberTextBox.Text, EmailTextBox.Text);
                newBorrowerModel.AddBorrower();

                FirstNameTextBox.Text = "";
                LastNameTextBox.Text = "";
                CourseComboBox.Text = "Course";
                CourseComboBox.SelectedIndex = -1;
                YearComboBox.Text = "Yr";
                YearComboBox.SelectedIndex = -1;
                SectionComboBox.Text = "Sec";
                SectionComboBox.SelectedIndex = -1;
                ContactNumberTextBox.Text = "";
                EmailTextBox.Text = "";

                AdminMainForm adminMainForm = new();
                adminMainForm.Show();
                this.Hide();
            }
        }

        // Returns the form to UserMainForm
        private void BackButton_Click(object sender, EventArgs e)
        {
            MAIN userMainForm = new MAIN();
            userMainForm.Show();
            this.Hide();
        }

        private void CourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CourseComboBox.SelectedIndex == 0)
                CourseComboBox.Text = "BSCS";
            if (CourseComboBox.SelectedIndex == 1)
                CourseComboBox.Text = "BSEMC";
            if (CourseComboBox.SelectedIndex == 2)
                CourseComboBox.Text = "BSIS";
            if (CourseComboBox.SelectedIndex == 3)
                CourseComboBox.Text = "BSIT";

        }

        private void YearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (YearComboBox.SelectedIndex == 0)
                YearComboBox.Text = "1";
            if (YearComboBox.SelectedIndex == 1)
                YearComboBox.Text = "2";
            if (YearComboBox.SelectedIndex == 2)
                YearComboBox.Text = "3";
            if (YearComboBox.SelectedIndex == 3)
                YearComboBox.Text = "4";

        }

        private void SectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (SectionComboBox.SelectedIndex == 0)
                SectionComboBox.Text = "A";
            if (SectionComboBox.SelectedIndex == 1)
                SectionComboBox.Text = "B";
        }

        private void StudentIDTextBox_TextChanged(object sender, EventArgs e)
        {
            StudentIDTextBox.Text.ToUpper();
            StudentIDTextBox.Text.Trim();
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

            // Validation Process

            if (!IsValidName(FirstNameTextBox.Text) || !IsValidName(LastNameTextBox.Text))
                return false;
               
            if (CourseComboBox.SelectedIndex < 0 || YearComboBox.SelectedIndex < 0 || SectionComboBox.SelectedIndex < 0)
                return false;

            if (!IsValidStudentID(StudentIDTextBox.Text))
                return false;
                
            if (!IsValidContactNumber(ContactNumberTextBox.Text))
                return false;

            if (!IsValidEmail(EmailTextBox.Text))
                return false;

            return true;
        }

        
    }
}
