using Microsoft.Data.SqlClient;
using System.Data.SqlTypes;

namespace equipsys.Models
{
    public class AccountModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Course { get; set; }
        public string Year { get; set; }
        public string StudentID { get; set; }

        // CONSTRUCTORS
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

        /// <summary>
        /// Saves information of new object into table Accounts
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="course"></param>
        /// <param name="year"></param>
        /// <param name="studentid"></param>
        /// <returns></returns>
        public bool AddAccount(string username, string password, string firstname, string lastname, string course, string year, string studentid)
        {
            SqlConnection sql = new SqlConnection(GlobalConfig.ConnectionString);
            string saveAccountQuery = "INSERT INTO Accounts (username, password, role, firstname, lastname, course, year, student_id) VALUES(@USERNAME, @PASSWORD, 'user', @FIRSTNAME, @LASTNAME, @COURSE, @YEAR, @STUDENTID)";
            sql.Open();
            SqlCommand cmd = new SqlCommand(saveAccountQuery, sql);
            cmd.Parameters.AddWithValue("@USERNAME", username);
            cmd.Parameters.AddWithValue("@PASSWORD", password);
            cmd.Parameters.AddWithValue("@FIRSTNAME", firstname);
            cmd.Parameters.AddWithValue("@LASTNAME", lastname);
            cmd.Parameters.AddWithValue("@COURSE", course);
            cmd.Parameters.AddWithValue("@YEAR", year);
            cmd.Parameters.AddWithValue("@STUDENTID", studentid);

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Account registered successfully");
                sql.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Failed to register account");
                sql.Close();
                return false;
            }
        }
    }
}
