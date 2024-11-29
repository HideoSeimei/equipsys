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
using EBSystemLIBRARY;

namespace equipsys
{
    public partial class AddItemForm : Form
    {
        private string selectedImagePath = "";

        private void AddImageButton_Click(object sender, EventArgs e)
        {
            // Opens File Explorer for image selection
            selectedImagePath = "";
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
                ItemModel newItemModel = new ItemModel(ItemNameBox.Text, ItemStockBox.Text, ItemDescriptionBox.Text, selectedImagePath);
                newItemModel.SaveItem(ItemNameBox.Text, ItemDescriptionBox.Text, Int32.Parse(ItemStockBox.Text), selectedImagePath);

                // Resets textboxes to null values.
                ItemNameBox.Text = "";
                ItemDescriptionBox.Text = "";
                ItemStockBox.Text = "0";
                selectedImagePath = "";

                // close form after adding a new item
                AdminMainForm admin_main_form = new AdminMainForm();
                admin_main_form.Show();
                this.Hide();
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
    }
}
