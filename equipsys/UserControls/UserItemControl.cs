using equipsys.LibraryUI;
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
    public partial class UserItemControl : UserControl
    {
        public UserItemControl()
        {
            InitializeComponent();
        }

        private void ReturningButton_Click(object sender, EventArgs e)
        {
            ReturningForm returningForm = new ReturningForm();
            returningForm.Show();
            this.Hide();
        }

        private void BorrowingButton_Click(object sender, EventArgs e)
        {
            BorrowingForm borrowingForm = new BorrowingForm();
            borrowingForm.Show();
            this.Hide();
        }
    }
}
