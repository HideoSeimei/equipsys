using Microsoft.Data.SqlClient;
namespace equipsys
{
    public partial class LoginForm : Form
    {
        public string Role;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // changes the label depending on the role
            if (Role == "admin")
            {
                RoleLbl.Text = "LOGIN AS ADMIN";
            }
            else
            {
                RoleLbl.Text = "LOGIN AS STAFF";
            }
            //
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)// SIGN UP BUTTON
        {
            RegistrationForm registration = new RegistrationForm();
            registration.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)// LOGIN BUTTON
        {
            string username = usernamebox.Text.Trim();
            string password = passwordbox.Text.Trim();


            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QE9SO2J;Initial Catalog=EquipmentBorrowingSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            conn.Open();
            string query = "Select role from accounts where username = @username and password = @password"; // sql query for identifying the role of the account
            string query2 = "Select account_id from accounts where username = @username and password = @password";//sql query to get the user account id
            string query3 = "Select username from Accounts where username = @username and password = @password";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            SqlCommand cmd3 = new SqlCommand(query3, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd2.Parameters.AddWithValue("@username", username);
            cmd2.Parameters.AddWithValue("@password", password);
            AdminMainForm adminForm = new AdminMainForm();
            string result = (string)cmd.ExecuteScalar(); // variable for the role
            object userid = cmd2.ExecuteScalar();// variable for the userid 
            //string retrievedUsername = (string)cmd3.ExecuteScalar();
            //retrievedUsername = adminForm.AccountName;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))// CHECKS IF THERES A VALUE INSIDE THE USERNAME OR PASSWORD TEXTBOX
            {
                accountChecker.Text = "Enter username and password";//INPUTS THIS IF THE USER AND PASSWORD TEXTBOX ARE EMPTY
            }
            else if (result == "user")
            {
                MAIN mainUser = new MAIN();
                mainUser.Show();
                this.Hide();

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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // reveal password toggle
            if (passwordbox.UseSystemPasswordChar == true) // if password is hidden
            {
                passwordbox.UseSystemPasswordChar = false;
            }
            else // if password is not hidden
            {
                passwordbox.UseSystemPasswordChar = true;
            }
            //
        }

        private void usernamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void RoleLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
