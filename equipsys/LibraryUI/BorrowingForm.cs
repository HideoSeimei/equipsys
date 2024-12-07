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
    public partial class BorrowingForm : Form
    {
        SqlConnection sql = new SqlConnection(GlobalConfig.ConnectionString);
        public BorrowingForm()
        {
            InitializeComponent();
        }

        private void BORROWING_Load(object sender, EventArgs e)
        {

        }

        private void yearReg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql.Open();
        }
    }
}
