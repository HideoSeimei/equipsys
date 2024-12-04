using EBSystemLIBRARY.Models;
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
    public partial class AdminItemControl : UserControl
    {
        public AdminItemControl()
        {
            InitializeComponent();

        }

        public void SetItemData(int itemId, string itemName, string description, int stocks, string imagePath)
        {
            // Set the controls with the values from your data
            ItemIdlbl.Text = $"ID: {itemId}";
            Namelbl.Text = itemName;
            Descriptionlbl.Text = description;
            Stocklbl.Text = $"Stocks: {stocks}";


            // Load the image into the PictureBox if imagePath is valid
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                imageBox.Image = Image.FromFile(imagePath);
            }

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ItemUserControl_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditItemForm editItems = new EditItemForm();
            AdminMainForm mainAdmin = new AdminMainForm();
            editItems.Show();
            mainAdmin.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)// DELETE BUTTON
        {
            ItemModel itemmodel = new ItemModel();
            //itemmodel.DeleteItem(ItemIdlbl.Text);
        }

        private void Descriptionlbl_Click(object sender, EventArgs e)
        {
            
        }
    }
}
