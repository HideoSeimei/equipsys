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
{

    public partial class MAIN_ADMIN : Form
    {

        public MAIN_ADMIN()
        {
            InitializeComponent();

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
            ITEMS items = new ITEMS() { TopLevel = false, TopMost = true };
            items.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(items);
            items.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // for loging out (will send you back to login form)
            LOGIN login = new LOGIN();
            login.Show();
            this.Hide();
            //

        }

        private void record_Click(object sender, EventArgs e)
        {
            //for opening the records form
            RECORD record = new RECORD() { TopLevel = false, TopMost = true };
            record.FormBorderStyle = FormBorderStyle.None;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(record);
            record.Show();
            //

        }
    }
}
