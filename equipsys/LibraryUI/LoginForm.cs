using Microsoft.Data.SqlClient;
namespace equipsys
{
    public partial class LoginForm : Form
    {
        public LoginForm()
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
            RegistrationForm registration = new RegistrationForm();
            registration.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)// LOGIN BUTTON
        {
            string username = usernamebox.Text.Trim();
            string password = passwordbox.Text.Trim();


            SqlConnection sql = new SqlConnection(GlobalConfig.ConnectionString);
            sql.Open();
            string loginQuery = "Select Role, Account_id from accounts where username = @username and password = @password"; // sql query for identifying the role of the account
            SqlCommand cmd = new SqlCommand(loginQuery, sql);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            string result = (string)cmd.ExecuteScalar();// variable for the userid
            // TODO - make sure userID is returned as well
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
                AdminMainForm mainAdminForm = new AdminMainForm();
                mainAdminForm.Show();
                this.Hide();
            }
            else
            {
                accountChecker.Text = "Invalid account";
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // password reveal toggle
            if (passwordbox.UseSystemPasswordChar == true)
                passwordbox.UseSystemPasswordChar = false;
            else 
                passwordbox.UseSystemPasswordChar = true;
        }
    }
}
