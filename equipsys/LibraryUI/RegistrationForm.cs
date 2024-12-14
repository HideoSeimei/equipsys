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
using equipsys.Models;

namespace equipsys
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            AdminMainForm adminMainForm = new();
            adminMainForm.Show();
            this.Hide();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                AccountModel newAccountModel = new AccountModel(UsernameTextBox.Text, PasswordTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text, CourseComboBox.Text, YearComboBox.Text, SectionComboBox.Text, StudentIDTextBox.Text);
                newAccountModel.SaveAccount();

                FirstNameTextBox.Text = "";
                LastNameTextBox.Text = "";
                CourseComboBox.Text = "Course";
                CourseComboBox.SelectedIndex = -1;
                YearComboBox.Text = "Yr";
                YearComboBox.SelectedIndex = -1;
                SectionComboBox.Text = "Sec";
                SectionComboBox.SelectedIndex = -1;
                UsernameTextBox.Text = "";
                PasswordTextBox.Text = "";

                AdminMainForm adminMainForm = new();
                adminMainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("There are invalid field(s) detected in the form, try again.");
            }
        }

        private bool ValidateForm()
        {
            bool IsValidName(string name) =>
                !string.IsNullOrWhiteSpace(name) && (name.All(char.IsLetter) || name.Contains(" "));

            bool IsValidStudentID(string id) =>
                id.Length == 10 &&
                id.StartsWith("2") &&
                (id.EndsWith("-N") || id.EndsWith("-S")) &&
                id.Substring(1, 7).All(char.IsDigit);

            bool IsValidUsername(string username) =>
                (username.Length >= 3 && username.Length <= 30) &&
                username.All(char.IsLetterOrDigit);
            // add a way to detect for dupe entries.

            bool IsValidPassword(string password) =>
                password.Length >= 6;

            if (!IsValidName(FirstNameTextBox.Text) || !IsValidName(LastNameTextBox.Text))
                return false;

            if (CourseComboBox.SelectedIndex < 0 || YearComboBox.SelectedIndex < 0 || SectionComboBox.SelectedIndex < 0)
                return false;

            if (!IsValidStudentID(StudentIDTextBox.Text))
                return false;

            if (!IsValidUsername(UsernameTextBox.Text))
                return false;

            if (!IsValidPassword(PasswordTextBox.Text)) 
                return false;
            
            return true;
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

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
// else
// MessageBox.Show("Invalid Entries Detected, Try again.");
