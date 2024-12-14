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
        public string Section { get; set; }
        public string StudentID { get; set; }

        // CONSTRUCTORS
        public AccountModel(string username, string password, string firstname, string lastname, string course, string year, string section, string studentid)
        {
            Username = username;
            Password = password;
            FirstName = firstname;
            LastName = lastname;
            Course = course;
            Year = year;
            Section = section;
            StudentID = studentid;
        }

        // METHODS

        /// <summary>
        /// Saves information of new object into table Accounts
        /// </summary>
        /// <param name="Username"></param>
        /// <param name="Password"></param>
        /// <param name="Firstname"></param>
        /// <param name="Lastname"></param>
        /// <param name="Course"></param>
        /// <param name="Year"></param>
        /// <param name="Section"></param>
        /// <param name="Studentid"></param>
        /// <returns></returns>
        public bool SaveAccount()
        {
            SqlConnection sql = new SqlConnection(GlobalConfig.ConnectionString);
            string saveAccountQuery = "INSERT INTO Accounts (Username, Password, Role, FirstName, LastName, Course, Year, Section, StudentID) " +
                "VALUES(@USERNAME, @PASSWORD, 'user', @FIRSTNAME, @LASTNAME, @COURSE, @YEAR, @SECTION, @STUDENTID)";
            sql.Open();
            SqlCommand cmd = new SqlCommand(saveAccountQuery, sql);
            cmd.Parameters.AddWithValue("@USERNAME", Username);
            cmd.Parameters.AddWithValue("@PASSWORD", Password);
            cmd.Parameters.AddWithValue("@FIRSTNAME", FirstName);
            cmd.Parameters.AddWithValue("@LASTNAME", LastName);
            cmd.Parameters.AddWithValue("@COURSE", Course);
            cmd.Parameters.AddWithValue("@YEAR", Year);
            cmd.Parameters.AddWithValue("@SECTION", Section);
            cmd.Parameters.AddWithValue("@STUDENTID", StudentID);

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
