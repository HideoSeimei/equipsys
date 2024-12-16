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
            OpenItems();

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

        private void label2_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
        // ============================================================================= NEW BUTTONS BELOW ====================================================
        private void button4_Click(object sender, EventArgs e) // HOME 
        {
            OpenItems();
            UserTitlelbl.Text = "Equipment";// to change the label base on what panel are you on
        }

        private void button8_Click(object sender, EventArgs e)// HISTORY
        {
            OpenRecords();
            UserTitlelbl.Text = "Records";// to change the label base on what panel are you on
        }

        private void button7_Click(object sender, EventArgs e)// ADD ITEM
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)// LOGOUT
        {
            // for going back to user login form
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
        //============================================================================================METHODS=========================================================================
        public void OpenItems()// for opening items
        {
            //For showing useritems
            UserItems useritems = new UserItems() { TopLevel = false, TopMost = true };
            useritems.FormBorderStyle = FormBorderStyle.None;
            useritems.Size = mainPanel.ClientSize;
            useritems.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(useritems);
            useritems.Show();
        }
        public void OpenRecords()// for opening records/history
        {
            //for opening the records/history form
            HistoryLogForm record = new HistoryLogForm() { TopLevel = false, TopMost = true };
            record.FormBorderStyle = FormBorderStyle.None;
            record.Size = mainPanel.ClientSize;
            record.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(record);
            record.Show();
            //
        }
    }

}
