using equipsys;
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
    public partial class RoleSelectionForm : Form
    {
        public RoleSelectionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//STAFF
        {

            LoginForm loginForm = new LoginForm();
            loginForm.Role = "staff";
            loginForm.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)//ADMIN
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Role = "admin";
            loginForm.Show();
            this.Hide();
        }
    }
}