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
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
            UserItems useritems = new UserItems() { TopLevel = false, TopMost = true };
            useritems.FormBorderStyle = FormBorderStyle.None;
            useritems.Size = mainPanel.ClientSize;
            useritems.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(useritems);
            useritems.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UserItems useritems = new UserItems() { TopLevel = false, TopMost = true };
            useritems.FormBorderStyle = FormBorderStyle.None;
            useritems.Size = mainPanel.ClientSize;
            useritems.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(useritems);
            useritems.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //for opening the records form
            HistoryLogForm record = new HistoryLogForm() { TopLevel = false, TopMost = true };
            record.FormBorderStyle = FormBorderStyle.None;
            record.Size = mainPanel.ClientSize;
            record.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(record);
            record.Show();
            //
        }

        private void MAIN_Load(object sender, EventArgs e)
        {
            UserProfileName.Text = $"Welcome STAFF";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
