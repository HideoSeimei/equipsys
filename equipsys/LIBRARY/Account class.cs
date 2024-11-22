using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace equipsys.LIBRARY
{
    
    public class account // CLASS FOR ACCOUNT MANIPULATION
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QE9SO2J;Initial Catalog=EquipmentBorrowingSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        //PROPERTIES
        public int _userId { get; set; }
        public string _username { get; set; }
        public string _password { get; set; }
        public string _role { get; set; }
        //CONSTRUCTOR
        public account(int userId,string username,string password,string role)
        {
            _userId = userId;
            _username = username;
            _password = password;
            _role = role;
        }
        //Methods

        //public bool isAdmin(string username,string password)
        //{
            


        //    return;
        //}

    }
    internal class Account_class
    {

    }
}
