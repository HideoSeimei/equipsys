using Microsoft.Data.SqlClient;
namespace equipsys
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)// SIGN UP BUTTON
        {
            REGISTRATION registration = new REGISTRATION();
            registration.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)// LOGIN BUTTON
        {
            string username = usernamebox.Text.Trim();
            string password = passwordbox.Text.Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))// CHECKS IF THERES A VALUE INSIDE THE USERNAME OR PASSWORD TEXTBOX
            {
                accountChecker.Text = "INVALID ACCOUNT";//INPUTS THIS IF THE USER AND PASSWORD TEXTBOX ARE EMPTY
            }

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QE9SO2J;Initial Catalog=EquipmentBorrowingSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            conn.Open();
            string query = "Select role from accounts where username = @username and password = @password"; // sql query for identifying the role of the account
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            string result = (string)cmd.ExecuteScalar(); // variable for the role
            string userId = (string)cmd.ExecuteScalar();// variable for the userid 

            if (result == "user")
            {
                MessageBox.Show("user\n" + userId);

            }
            else if (result == "admin")
            {
                MessageBox.Show("Admin\n" + userId);
            }


        }
    }
}
