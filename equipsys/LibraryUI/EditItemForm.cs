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
using equipsys.Models;
using equipsys.Data_Access;

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
        private FlowLayoutPanel _flowLayoutPanel; // Store the reference // unused?
        public EditItemForm()
        {
            InitializeComponent();

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            AdminMainForm adminMainForm = new AdminMainForm();
            adminMainForm.Show();
            this.Hide();

        }

        private void EditItemForm_Load(object sender, EventArgs e)
        {
            ItemModel itemmodel = new ItemModel();
            ItemNameBox.Text = ItemName;
            ItemDescriptionBox.Text = ItemDescription;
            ItemStockBox.Text = ItemStock.ToString();
            NewImagePath.Image = new Bitmap(NewSelectedImage); // TODO -  handle this error when image is empty
            MessageBox.Show(ItemName);
        }

        private void SaveButton_Click(object sender, EventArgs e)// SAVE BUTTON
        {
            if (ValidateItem())
            {
                using (SqlConnection con = new SqlConnection())
                {
                    ItemModel itemmodel = new ItemModel();
                    itemmodel.EditItem(ItemID, ItemNameBox.Text, ItemDescriptionBox.Text, Int32.Parse(ItemStockBox.Text), NewSelectedImage);
                    ItemForm itemform = new ItemForm();
                    ItemLoader itemLoader = new ItemLoader(itemform.flowLayoutPanel1);
                    itemLoader.LoadToPanel();
                }

                AdminMainForm adminMainForm = new AdminMainForm();
                adminMainForm.Show();
                this.Hide();
            }
        }

        private bool ValidateItem()
        {
            if (ItemNameBox.Text.Length == 0)
                return false;

            int stockNumber = 0;
            bool stockNumberValidNumber = int.TryParse(ItemStockBox.Text, out stockNumber);
            if (stockNumberValidNumber == false)
                return false;
            if (stockNumber < 1)
                return false;
            if (ItemDescriptionBox.Text.Length == 0)
                ItemDescriptionBox.Text = "No Description Provided";

            return true;
        }

        private void BrowseImageButton_Click(object sender, EventArgs e)// BROWSE BUTTON
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
