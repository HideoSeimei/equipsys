using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipsys.Models
{
    public class BorrowerModel
    {
        public int BorrowerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Course { get; set; }
        public string Year { get; set; }
        public string Section { get; set; }
        public string StudentID { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        // public List<ItemModel> ItemsBorrowed { get; set; } = new List<ItemModel>();

        // Constructors

        public BorrowerModel(string firstName, string lastName, string course, string year, string section, string studentID, string contactNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Course = course;
            Year = year;
            Section = section;
            StudentID = studentID;
            ContactNumber = contactNumber;
            Email = email;
        }

        // Methods

        public bool AddBorrower()
        {
            SqlConnection sql = new SqlConnection(GlobalConfig.ConnectionString);
            string saveBorrowerQuery = "INSERT INTO Borrowers (FirstName, LastName, Course, Year, Section, StudentID, ContactNumber, Email) " +
                "VALUES (@FIRSTNAME, @LASTNAME, @COURSE, @YEAR, @SECTION, @STUDENTID, @CONTACTNUMBER, @EMAIL)";
            sql.Open();
            SqlCommand cmd = new SqlCommand(saveBorrowerQuery, sql);
            cmd.Parameters.AddWithValue("@FIRSTNAME", FirstName);
            cmd.Parameters.AddWithValue("@LASTNAME", LastName);
            cmd.Parameters.AddWithValue("@COURSE", Course);
            cmd.Parameters.AddWithValue("@YEAR", Year);
            cmd.Parameters.AddWithValue("@SECTION", Section);
            cmd.Parameters.AddWithValue("@STUDENTID", StudentID);
            cmd.Parameters.AddWithValue("@CONTACTNUMBER", ContactNumber);
            cmd.Parameters.AddWithValue("@EMAIL", Email);

            // confirmation that the borrower data is saved into db.

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Borrower Information Saved");
                sql.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Borrower failed to save, something went wrong.");
                sql.Close();
                return false;
            }
        }
    }   
}
