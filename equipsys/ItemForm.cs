using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace equipsys
{
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.Width = 300;

            for (int i = 0; i < 11; i++)
            {
                int yOffset = 0;
                AdminItemControl item = new AdminItemControl();
                item.Location = new Point(10, yOffset);  // Set unique location for each item
                flowLayoutPanel1.Controls.Add(item);
                yOffset += item.Height + 50;  // Adjust for next item
            }
          
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
