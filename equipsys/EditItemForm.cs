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
    public partial class EditItemForm : Form
    {
        public string NewSelectedImage { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int ItemStock { get; set; }
        public string ImagePath { get; set; }
        private FlowLayoutPanel _flowLayoutPanel; // Store the reference
        public EditItemForm()
        {
            InitializeComponent();

        }


        private void button3_Click(object sender, EventArgs e)
        {
            AdminMainForm mainAdmin = new AdminMainForm();
            this.Close();// for closing this form

        }

        private void EditItemForm_Load(object sender, EventArgs e)
        {
            ItemModel itemmodel = new ItemModel();
            ItemBox.Text = ItemName;
            DescriptionBox.Text = ItemDescription;
            StockBox.Text = ItemStock.ToString();
            if (string.IsNullOrEmpty(NewSelectedImage))
            {
                NewImagePath.Image = new Bitmap(@"C:\Users\itiw\source\repos\equipsys\equipsys\Images\default image.png");
            }
            else
            {
                NewImagePath.Image = new Bitmap(NewSelectedImage);
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)// SAVE BUTTON
        {
            using (SqlConnection con = new SqlConnection())
            {
                ItemModel itemmodel = new ItemModel();
                itemmodel.EditItem(ItemID, ItemBox.Text, DescriptionBox.Text, Int32.Parse(StockBox.Text),NewSelectedImage);
                ItemForm itemform = new ItemForm();
                ItemLoader itemLoader = new ItemLoader(itemform.flowLayoutPanel1);
                itemLoader.LoadItemsToFlowLayoutPanel();
            }
            //to close the form
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)// BROWSE BUTTON
        {
            // Opens File Explorer for image selection
            NewSelectedImage = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // obtains the selected image path for this item
                NewImagePath.Image = new Bitmap(openFileDialog.FileName);
                NewSelectedImage = openFileDialog.FileName;
            }
        }
    }
}
