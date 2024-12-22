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
using System.Linq.Expressions;

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

        private void EditItemForm_Load(object sender, EventArgs e)
        {
            ItemModel itemmodel = new ItemModel();
            ItemNameBox.Text = ItemName;
            ItemDescriptionBox.Text = ItemDescription;
            ItemStockBox.Text = ItemStock.ToString();
            try
            {
                NewImagePath.Image = new Bitmap(NewSelectedImage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            AdminMainForm adminMainForm = new AdminMainForm();
            adminMainForm.Hide();
            adminMainForm.Show();
            this.Hide();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ValidateItem())
            {
                using (SqlConnection con = new SqlConnection())
                {
                    ItemModel itemmodel = new ItemModel();
                    itemmodel.EditItem(ItemID, ItemNameBox.Text, ItemDescriptionBox.Text, Int32.Parse(ItemStockBox.Text), NewSelectedImage);
                    MessageBox.Show("Saved Successfully");
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
            bool IsValidItemName(string name) =>
                !string.IsNullOrWhiteSpace(name);

            bool IsValidItemStock(string stock) =>
                stock.Length != 0 &&
                stock.All(char.IsDigit) &&
                (int.Parse(stock) > 0 ||
                int.Parse(stock) == 0);


            if (!IsValidItemName(ItemNameBox.Text))
            {
                MessageBox.Show("Name can not be empty");
                return false;
            }

            if (!IsDuplicateItem(ItemNameBox.Text))
            {
                MessageBox.Show("Invalid item name");
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
            if (ItemName == ItemNameBox.Text)
            {
                return true;
            }
            else
            {
                using SqlConnection sql = new SqlConnection(GlobalConfig.ConnectionString);
                sql.Open();
                string retrieveUsernameQuery = "SELECT Count(*) FROM Items WHERE ItemName = @ITEMNAME";
                SqlCommand cmd = new SqlCommand(retrieveUsernameQuery, sql);
                cmd.Parameters.AddWithValue("@ITEMNAME", name);
                if ((int)cmd.ExecuteScalar() > 0)
                {
                    sql.Close();
                    return false;
                }
                else
                {
                    sql.Close();
                    return true;
                }
            }
            
        }

        private void BrowseImageButton_Click(object sender, EventArgs e)
        {
            // Opens File Explorer for image selection
            NewSelectedImage = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    NewImagePath.Image = new Bitmap(openFileDialog.FileName);
                    NewSelectedImage = openFileDialog.FileName;
                }
                catch
                {
                    MessageBox.Show("The image you are trying to upload can not be processed");
                }
            }
        }

        private void HomeBTN_Click(object sender, EventArgs e)
        {

        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
