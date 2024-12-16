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
using equipsys.Models;

namespace equipsys
{
    public partial class AddItemForm : Form
    {
        private string selectedImagePath = "";
        public AddItemForm()
        {
            InitializeComponent();
        }
        private void AddImageButton_Click(object sender, EventArgs e)
        {
            // Opens File Explorer for image selection
            selectedImagePath = @".\Images\default_image.png";
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // obtains the selected image path for this item
                pictureBox4.Image = new Bitmap(openFileDialog.FileName);
                selectedImagePath = openFileDialog.FileName;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ValidateItem())
            {
                // Creates new item object and saves information to database
                ItemModel newItemModel = new ItemModel();
                newItemModel.AddItem(ItemNameBox.Text, ItemDescriptionBox.Text, Int32.Parse(ItemStockBox.Text), selectedImagePath);

                // Resets textboxes to null values.
                ItemNameBox.Text = "";
                ItemDescriptionBox.Text = "";
                ItemStockBox.Text = "0";
                selectedImagePath = "";

                // close form after adding a new item
                AdminMainForm adminMainForm = new AdminMainForm();
                adminMainForm.mainPanel.Controls.Clear();// this is not working
                adminMainForm.OpenEquipment();// this is not working
                
            }
            else
            {
                MessageBox.Show($"Item Name is null or invalid stock value. Try again.");
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            AdminMainForm mainadminform = new AdminMainForm();
            mainadminform.Show();
            this.Hide();
        }

        private bool ValidateItem()
        {
            // Validates ItemName
            if (ItemNameBox.Text.Length == 0)
                return false;

            int stockNumber = 0;
            bool stockNumberValidNumber = int.TryParse(ItemStockBox.Text, out stockNumber);
            // Validates ItemStock is int
            if (stockNumberValidNumber == false)
                return false;
            // Validates Itemstock is not <= 0
            if (stockNumber < 1)
                return false;

            // Replaces null description with a placeholder value
            if (ItemDescriptionBox.Text.Length == 0)
                ItemDescriptionBox.Text = "No Description Provided";

            // returns true if passed all validation
            return true;
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
