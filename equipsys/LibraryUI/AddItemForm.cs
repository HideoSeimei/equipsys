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
            selectedImagePath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // obtains the selected image path for this item
                ImagePictureBox.Image = new Bitmap(openFileDialog.FileName);
                selectedImagePath = openFileDialog.FileName;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ValidateItem())
            {
                // Creates new item object and saves information to database
                ItemModel newItemModel = new ItemModel();
                newItemModel.AddItem(ItemNameTextBox.Text, ItemDescriptionTextBox.Text, Int32.Parse(ItemStockTextBox.Text), selectedImagePath);

                // Resets textboxes to null values.
                ItemNameTextBox.Text = "";
                ItemDescriptionTextBox.Text = "";
                ItemStockTextBox.Text = "0";
                selectedImagePath = "";

                // close form after adding a new item
                AdminMainForm adminMainForm = new AdminMainForm();
                adminMainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show($"Item Name is null or invalid stock value. Try again.");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminMainForm mainadminform = new AdminMainForm();
            mainadminform.Show();
            this.Hide();
        }

        private bool ValidateItem()
        {
            // Validates ItemName
            if (ItemNameTextBox.Text.Length == 0)
                return false;

            int stockNumber = 0;
            bool stockNumberValidNumber = int.TryParse(ItemStockTextBox.Text, out stockNumber);
            // Validates ItemStock is int
            if (stockNumberValidNumber == false)
                return false;
            // Validates Itemstock is not <= 0
            if (stockNumber < 1)
                return false;

            // Replaces null description with a placeholder value
            if (ItemDescriptionTextBox.Text.Length == 0)
                ItemDescriptionTextBox.Text = "No Description Provided";

            // returns true if passed all validation
            return true;
        }
    }
}
