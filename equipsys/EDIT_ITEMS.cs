﻿using System;
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
    public partial class EDIT_ITEMS : Form
    {
        public EDIT_ITEMS()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MAIN_ADMIN mainAdmin = new MAIN_ADMIN();
            
            this.Close();
        }
    }
}