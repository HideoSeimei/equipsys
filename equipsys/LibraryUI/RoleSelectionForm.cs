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

        private void AdminBTN_Click(object sender, EventArgs e)
        {
            LoginFormAdmin loginFormAdmin = new LoginFormAdmin();
            loginFormAdmin.Show();
            this.Hide();
        }

        private void StaffBTN_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}