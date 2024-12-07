using Microsoft.Data.SqlClient;
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
    // TODO - add function to retrieve items from database, make sure it refreshes every new item or everytime the page loads or home is clicked.
{


    public partial class AdminMainForm : Form
    {
        public Panel MainPanel => mainPanel; // Make mainPanel accessible
        public string searchBox;
        private System.Windows.Forms.Timer timer;

        public AdminMainForm()
        {
            InitializeComponent();//to immediately show the itemform in the panel
            ItemForm items = new ItemForm() { TopLevel = false, TopMost = true };
            items.FormBorderStyle = FormBorderStyle.None;
            items.Size = mainPanel.ClientSize;
            items.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(items);
            items.Show();
            //for timer 
            // Initialize the Timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Code to refresh data or UI
            ItemForm itemform = new ItemForm();
            itemform.ReloadFlowLayoutPanel();
        }
        private void MAIN_ADMIN_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void items_Click(object sender, EventArgs e)// ITEMS BUTTON
        {
            //for opening the items form
            ItemForm items = new ItemForm() { TopLevel = false, TopMost = true };
            items.FormBorderStyle = FormBorderStyle.None;
            items.Size = mainPanel.ClientSize;
            items.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(items);
            items.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // for loging out (will send you back to login form)
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
            //

        }

        private void record_Click(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //for displaying itemform inside the panel
            ItemForm items = new ItemForm() { TopLevel = false, TopMost = true };
            items.FormBorderStyle = FormBorderStyle.None;
            items.Size = mainPanel.ClientSize;
            items.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(items);
            items.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //for opening the Add item  form
            AddItemForm add_item_form = new AddItemForm();
            add_item_form.Show();
            this.Hide();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
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

        private void AccountsButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)// SEARCH BOX
        {
            searchBox = search.Text.Trim();
            MessageBox.Show(searchBox);
        }
    }
}
