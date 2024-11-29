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
using System.IO;

namespace equipsys
{
    public partial class ADD_ITEMS : Form
    {
        public string _imagePath; // make it a class level variable so i can access
        public ADD_ITEMS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //BROWSE BUTTON
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string imagePath = null; // the imagePath is null at first because theres no value yet
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                pictureBox4.Image = new Bitmap(openFileDialog.FileName);
                imagePath = openFileDialog.FileName;// here is the new imagePath 
                _imagePath = imagePath;
                
            }
            //MessageBox.Show(_imagePath); // for testing
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)// SAVE BUTTON
        {
           
            ItemModel itemmodel = new ItemModel();
            itemmodel.Additem(textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text),_imagePath);// method for adding item to the database
            
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
