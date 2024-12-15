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
    public partial class LoginFormAdmin : Form
    {
        public LoginFormAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernamebox.Text.Trim();
            string password = passwordbox.Text.Trim();


            SqlConnection sql = new SqlConnection(GlobalConfig.ConnectionString);
            sql.Open();
            string query = "Select role from accounts where username = @username and password = @password"; // sql query for identifying the role of the account
            string query2 = "Select account_id from accounts where username = @username and password = @password";//sql query to get the user account id
            string query3 = "Select username from Accounts where username = @username and password = @password";
            SqlCommand cmd = new SqlCommand(query, sql);
            SqlCommand cmd2 = new SqlCommand(query2, sql);
            SqlCommand cmd3 = new SqlCommand(query3, sql);

            /*SqlCommand cmd = new SqlCommand(query, sql);
            SqlCommand cmd2 = new SqlCommand(query2, sql);
            */
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd2.Parameters.AddWithValue("@username", username);
            cmd2.Parameters.AddWithValue("@password", password);
            AdminMainForm adminForm = new AdminMainForm();
            string result = (string)cmd.ExecuteScalar(); // variable for the role
            //object userid = cmd2.ExecuteScalar();// variable for the userid 
            //string retrievedUsername = (string)cmd3.ExecuteScalar();
            //retrievedUsername = adminForm.AccountName;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))// CHECKS IF THERES A VALUE INSIDE THE USERNAME OR PASSWORD TEXTBOX
            {
                accountChecker.Text = "Enter username and password";//INPUTS THIS IF THE USER AND PASSWORD TEXTBOX ARE EMPTY
            }
            else if (result == "user")// validation if they enter user account
            {
                accountChecker.Text = "Enter Admin account"; 

            }
            else if (result == "admin")
            {
                AdminMainForm mainAdmin = new AdminMainForm();
                mainAdmin.Show();
                this.Hide();
            }
            else
            {
                accountChecker.Text = "Invalid account";
            }
        }
    }
}
