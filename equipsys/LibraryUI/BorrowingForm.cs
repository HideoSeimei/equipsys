using equipsys.Models;
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
            else
                MessageBox.Show("There are invalid field(s) detected in the sheet, try again.");
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

        /// <summary>
        /// Validates the Borrower's Information. 
        /// </summary>
        /// <returns></returns>
        private bool ValidateForm()
        {
            foreach (char c in FirstNameTextBox.Text)
                if (!char.IsLetter(c) || FirstNameTextBox.Text.Length == 0)
                    return false;

            foreach (char c in LastNameTextBox.Text)
                if (!char.IsLetter(c) || LastNameTextBox.Text.Length == 0)
                    return false;

            if (CourseComboBox.Text == "Course")
                return false;

            if (YearComboBox.Text == "Yr")
                return false;

            if (SectionComboBox.Text == "Sec")
                return false;

            if (StudentIDTextBox.Text.Length != 10 || !StudentIDTextBox.Text.StartsWith("2"))
                return false;
            foreach (char c in StudentIDTextBox.Text.Substring(0, 8))
                if (!char.IsDigit(c) || (!StudentIDTextBox.Text.EndsWith("-N") && !StudentIDTextBox.Text.EndsWith("-S")))
                    return false;

            foreach (char c in ContactNumberTextBox.Text)
                if (!char.IsDigit(c) || ContactNumberTextBox.Text.Length != 10)
                    return false;

            if (EmailTextBox.Text.Length == 0 || !EmailTextBox.Text.Contains("@") || !EmailTextBox.Text.EndsWith(".com"))
                return false;

            return true;
        }

        private void StudentIDTextBox_TextChanged(object sender, EventArgs e)
        {
            StudentIDTextBox.Text.ToUpper();
        }
    }
}
