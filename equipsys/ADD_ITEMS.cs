using EBSystemLIBRARY.Models;
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
    public partial class ADD_ITEMS : Form
    {
        public ADD_ITEMS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                pictureBox4.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            ItemModel itemmodel = new ItemModel();
            itemmodel.Additem(textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text));// method for adding item to the database
            // used to return to MAIN_ADMIN form

            MAIN_ADMIN mainadminform = new MAIN_ADMIN();
            mainadminform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MAIN_ADMIN mainadminform = new MAIN_ADMIN();
            mainadminform.Show();
            this.Hide();
        }

        private void ADD_ITEMS_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
