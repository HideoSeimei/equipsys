using Microsoft.Data.SqlClient;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EBSystemLIBRARY.Models
{
    public class AccountModel
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Course { get; set; }
        public string Year { get; set; }
        public string StudentID { get; set; }

        // CONSTRUCTORS
        public AccountModel()
        {

        }

        public AccountModel(string username, string password, string firstname, string lastname, string course, string year, string studentid)
        {
            Username = username;
            Password = password;
            FirstName = firstname;
            LastName = lastname;
            Course = course;
            Year = year;
            StudentID = studentid;
        }

        // METHODS

        // Saves this AccountModel to database
        public bool SaveAccount(string username, string password, string firstname, string lastname, string course, string year, string studentid)
        {
            // TODO - CHANGE SqlConnection's CONSTRUCTOR TO YOUR DATA SOURCE AND DB
            // Opens a sql connection and execute an insert query to table Accounts
            SqlConnection sql = new SqlConnection("Data Source=ACERRYZEN;Initial Catalog=equipmentsys;Integrated Security=True;Trust Server Certificate=True");
            string query = "INSERT INTO Accounts(username, password, role, firstname, lastname, course, year, student_id) VALUES(@USERNAME, @PASSWORD, 'user', @FIRSTNAME, @LASTNAME, @COURSE, @YEAR, @STUDENT_ID)";
            sql.Open();
            SqlCommand cmd = new SqlCommand(query, sql);
            cmd.Parameters.AddWithValue("@USERNAME", username);
            cmd.Parameters.AddWithValue("@PASSWORD", password);
            cmd.Parameters.AddWithValue("@FIRSTNAME", firstname);
            cmd.Parameters.AddWithValue("@LASTNAME", lastname);
            cmd.Parameters.AddWithValue("@COURSE", course);
            cmd.Parameters.AddWithValue("@YEAR", year);
            cmd.Parameters.AddWithValue("@STUDENT_ID", studentid);

            // Validation for change in database
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Registration Complete!");
                sql.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Registration Failed!");
                sql.Close();
                return false;
            }
        }
    }
}
