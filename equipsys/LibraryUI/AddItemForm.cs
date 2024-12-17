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
                BorrowingImageBox.Image = new Bitmap(openFileDialog.FileName);
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

                // Resets textboxes/image to null values.
                ItemNameBox.Text = "";
                ItemDescriptionBox.Text = "";
                ItemStockBox.Text = "0";
                selectedImagePath = "";
                string DefaultimagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Images\default image.png");// here is the path of the default image
                BorrowingImageBox.Image = Image.FromFile(DefaultimagePath);

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
            bool IsValidItemName(string name) =>
                !string.IsNullOrWhiteSpace(name);

            bool IsValidItemStock(string stock) =>
                stock.Length != 0 &&
                stock.All(char.IsDigit) &&
                int.Parse(stock) > 0;

            if (!IsValidItemName(ItemNameBox.Text))
            {
                MessageBox.Show("Item name can not be null");
                return false;
            }

            if (!IsValidItemStock(ItemStockBox.Text))
            {
                MessageBox.Show("Invalid stock number");
                return false;
            }

            if (ItemDescriptionBox.Text.Length == 0)
                ItemDescriptionBox.Text = "No Description Provided.";

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

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
