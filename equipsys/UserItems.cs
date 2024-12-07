using EBSystemLIBRARY.Models;
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
    public partial class UserItems : Form
    {
        public UserItems()
        {
            InitializeComponent();
            UserItemsPanel.FlowDirection = FlowDirection.TopDown;
            UserItemsPanel.WrapContents = false;
            UserItemsPanel.Width = 300;

            //for (int i = 0; i < 11; i++)
            //{
            //    int yOffset = 0;
            //    UserItemControl useritem = new UserItemControl();
            //    useritem.Location = new Point(10, yOffset);  // Set unique location for each item
            //    UserItemsPanel.Controls.Add(useritem);
            //    yOffset += useritem.Height + 50;  // Adjust for next item
            //}
            ItemLoader itemloader = new ItemLoader(UserItemsPanel);
            itemloader.ULoadItemsToFlowLayoutPanel();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
