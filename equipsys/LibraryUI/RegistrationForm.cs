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
        private void BackBTN_Click(object sender, EventArgs e)
        {
            AdminMainForm adminMainForm = new AdminMainForm();
            adminMainForm.Show();
            this.Hide();
        }

        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            if (ValidateAccount())
            {
                AccountModel newAccountModel = new(UsernameValue.Text, PasswordValue.Text, FirstNameValue.Text, LastNameValue.Text, CourseValue.Text, YearValue.Text, SectionValue.Text, StudentIDValue.Text);
                newAccountModel.AddAccount(UsernameValue.Text, PasswordValue.Text, FirstNameValue.Text, LastNameValue.Text, CourseValue.Text, YearValue.Text, SectionValue.Text, StudentIDValue.Text);

                UsernameValue.Text = "";
                PasswordValue.Text = "";
                FirstNameValue.Text = "";
                LastNameValue.Text = "";
                CourseValue.Text = "Course";
                CourseValue.SelectedIndex = -1;
                YearValue.Text = "Year";
                YearValue.SelectedIndex = -1;
                SectionValue.Text = "Section";
                SectionValue.SelectedIndex = -1;
                StudentIDValue.Text = "";

                AdminMainForm adminMainForm = new AdminMainForm();
                adminMainForm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Invalid Entries Detected, Try again.");
        }

        private bool ValidateAccount()
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

            if (!IsValidName(FirstNameValue.Text) || !IsValidName(LastNameValue.Text))
            {
                MessageBox.Show("Invalid first or last name");
                return false;
            }

            if (CourseValue.SelectedIndex < 0 || YearValue.SelectedIndex < 0 || SectionValue.SelectedIndex < 0)
            {
                MessageBox.Show("Invalid Course/Yr/Sec");
                return false;
            }

            if (!IsValidStudentID(StudentIDValue.Text))
            {
                MessageBox.Show("Invalid Student ID");
                return false;
            }

            if (!IsValidUsername(UsernameValue.Text))
            {
                MessageBox.Show("Invalid Username");
                return false;
            }

            if (!IsValidPassword(PasswordValue.Text))
            {
                MessageBox.Show("Invalid Password");
                return false;
            }

            return true;
        }

        private void CourseValue_SelectedIndexChanged(object sender, EventArgs e)
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

        private void YearValue_SelectedIndexChanged(object sender, EventArgs e)
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

        private void SectionValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SectionValue.SelectedIndex == 0)
                SectionValue.Text = "A";
            if (SectionValue.SelectedIndex == 1)
                SectionValue.Text = "B";
        }

        
    }
}
