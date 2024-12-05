using EBSystemLIBRARY.Models;
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

namespace equipsys
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, EventArgs e, LoginForm loginForm)
        {
            LoginForm login_form = new LoginForm();
            login_form.Show();
            this.Hide();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {// If ValidateAccount() == true, then create the account and save to database.
            if (ValidateAccount())
            {
                AccountModel newAccountModel = new(UsernameBox.Text, PasswordBox.Text, FNameBox.Text, LNameBox.Text, CourseBox.Text, YearBox.Text, StudentIDBox.Text);
                newAccountModel.SaveAccount(UsernameBox.Text, PasswordBox.Text, FNameBox.Text, LNameBox.Text, CourseBox.Text, YearBox.Text, StudentIDBox.Text);

                // Resets textboxes to null values.
                UsernameBox.Text = "";
                PasswordBox.Text = "";
                FNameBox.Text = "";
                LNameBox.Text = "";
                CourseBox.Text = "";
                YearBox.Text = "";
                StudentIDBox.Text = "";

                // closes form after saving
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Entries Detected, Try again.");
            }
        }

        private bool ValidateAccount()
        {// Validates RegistrationForm and checks for invalid values.
            if (UsernameBox.Text.Length == 0 || UsernameBox.Text.Length < 30 || UsernameBox.Text.Length > 3)
            {
                MessageBox.Show("Username Must be 3-30 characters long");
                return false;
            }
            if (PasswordBox.Text.Length == 0)
                return false;
            if (FNameBox.Text.Length == 0)
                return false;
            if (LNameBox.Text.Length == 0)
                return false;
            if (CourseBox.Text.Length == 0) // TODO - make sure its a valid course
                return false;
            if (YearBox.SelectedItem == null)
            {
                MessageBox.Show("Select a valid year level.");
                return false;
            }
            if (StudentIDBox.Text.Length == 0)
                return false;

            return true;
        }

        private void YearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string) YearBox.SelectedItem == "1st Year")
                YearBox.Text = "1st Year";
            if ((string) YearBox.SelectedItem == "2nd Year")
                YearBox.Text = "2nd Year";
            if ((string) YearBox.SelectedItem == "3rd Year")
                YearBox.Text = "3rd Year";
            if ((string) YearBox.SelectedItem == "4th Year")
                YearBox.Text = "4th Year";
            else
                YearBox.Text = "";
        }
    }
}
