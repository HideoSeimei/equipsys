﻿using EBSystemLIBRARY.Models;
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
            ItemLoader itemloader = new ItemLoader(UserItemsPanel);
            itemloader.ULoadItemsToFlowLayoutPanel();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
