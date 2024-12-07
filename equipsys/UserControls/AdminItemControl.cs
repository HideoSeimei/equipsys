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
        public int ID;
        
        public void SetItemData(int itemId, string itemName, string description, int stocks, string imagePath)
        {
            // Set the controls with the values from your data
            ItemIdlbl.Text = itemId.ToString();
            Namelbl.Text = itemName;
            Descriptionlbl.Text = description;
            Stocklbl.Text = $"Stocks: {stocks}";
            int ID = itemId;//variable for getting the ID
            int stock = stocks;//for stocks
            if (stocks > 0)
            {
                Availability.BackColor = Color.LightGreen;
            }
            else
            {
                Availability.BackColor = Color.Pink;
            }


            // Load the image into the PictureBox if imagePath is valid
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                imageBox.Image = Image.FromFile(imagePath);
                imageBox.ImageLocation = imagePath;
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

        private void button1_Click(object sender, EventArgs e)// EDIT BUTTON
        {
            // Create an instance of the EditItemForm
            EditItemForm editItemForm = new EditItemForm();

            // Pass the data from the UserControl to the EditItemForm
            editItemForm.ItemID = int.Parse(ItemIdlbl.Text); 
            editItemForm.ItemName = Namelbl.Text;
            editItemForm.ItemDescription = Descriptionlbl.Text;
            editItemForm.ItemStock = int.Parse(Stocklbl.Text.Replace("Stocks: ", "")); // Parse the stock value
            editItemForm.NewSelectedImage = imageBox.ImageLocation;
            // Show the EditItemForm
            editItemForm.Show();
            AdminMainForm admin = new AdminMainForm();
            admin.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)// DELETE BUTTON
        {
            ItemModel itemmodel = new ItemModel();
            
            itemmodel.Delete(Int32.Parse(ItemIdlbl.Text));
            this.Hide();// this is used to hide the deleted usercontrol(adminitemcontrol)
        }

        private void Descriptionlbl_Click(object sender, EventArgs e)
        {

        }

        private void Descriptionlbl_Click_1(object sender, EventArgs e)
        {

        }
    }
}
