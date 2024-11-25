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
            useritems.Size = UserFormPanel.ClientSize;
            useritems.Dock = DockStyle.Fill;
            UserFormPanel.Controls.Clear();
            UserFormPanel.Controls.Add(useritems);
            useritems.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UserItems useritems = new UserItems() { TopLevel = false, TopMost = true };
            useritems.FormBorderStyle = FormBorderStyle.None;
            useritems.Size = UserFormPanel.ClientSize;
            useritems.Dock = DockStyle.Fill;
            UserFormPanel.Controls.Clear();
            UserFormPanel.Controls.Add(useritems);
            useritems.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void MAIN_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();
            login.Show();
            this.Hide();
        }
    }
}
