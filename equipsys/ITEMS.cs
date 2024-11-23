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
    public partial class ITEMS : Form
    {
        public ITEMS()
        {
            InitializeComponent();
            //ItemUserControl item = new ItemUserControl();
            //flowLayoutPanel1.Controls.Add(item);
            //flowLayoutPanel1.Controls.Add(item);
            //flowLayoutPanel1.Controls.Add(item);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;

            for (int i = 0; i < 11; i++)
            {
                int yOffset = 0;
                ItemUserControl item = new ItemUserControl();
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
