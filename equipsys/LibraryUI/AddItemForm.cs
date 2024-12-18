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
using System.Windows.Forms.VisualStyles;

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
                try
                {
                    BorrowingImageBox.Image = new Bitmap(openFileDialog.FileName);
                    selectedImagePath = openFileDialog.FileName;
                }
                catch
                {
                    MessageBox.Show("The image you are trying to upload can not be processed");
                }
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

                AdminMainForm adminMainForm = new AdminMainForm();
                adminMainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show($"There are invalid entries detected in the form");
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
                MessageBox.Show("Name can not be empty");
                return false;
            }

            if (IsDuplicateItem(ItemNameBox.Text))
            {
                MessageBox.Show("Item already exists");
                return false;
            }

            if (!IsValidItemStock(ItemStockBox.Text))
            {
                MessageBox.Show("Stock is not a valid number");
                return false;
            }

            if (ItemDescriptionBox.Text.Length == 0)
                ItemDescriptionBox.Text = "No Description Provided.";

            return true;
        }

        private bool IsDuplicateItem(string name)
        {
            using SqlConnection sql = new SqlConnection(GlobalConfig.ConnectionString);
            sql.Open();
            string retrieveItemQuery = "SELECT Count(*) FROM Items WHERE ItemName = @ITEMNAME";
            SqlCommand cmd = new SqlCommand(retrieveItemQuery, sql);
            cmd.Parameters.AddWithValue("@ITEMNAME", name);
            if ((int)cmd.ExecuteScalar() > 0)
            {
                sql.Close();
                return true;
            }
            else
            {
                sql.Close();
                return false;
            }
        }
    }
}
