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
    public partial class UserItemControl : UserControl
    {
        public UserItemControl()
        {
            InitializeComponent();
        }
        public void SetItemData(int itemId, string itemName, string description, int stocks, string imagePath)
        {
            // Set the controls with the values from your data
            UItemIDlbl.Text = itemId.ToString();
            UNamelbl.Text = itemName;
            UDescriptionlbl.Text = description;
            UStocklbl.Text = $"Stocks: {stocks}";
            int ID = itemId;//variable for getting the ID
            int stock = stocks;//for stocks
            if (stocks > 0)
            {
                UAvailability.BackColor = Color.LightGreen;
            }
            else
            {
                UAvailability.BackColor = Color.Pink;
            }


            // Load the image into the PictureBox if imagePath is valid
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                UimageBox.Image = Image.FromFile(imagePath);
                UimageBox.ImageLocation = imagePath;
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

        private void Return_Click(object sender, EventArgs e)// RETURN BUTTON
        {

        }

        private void Borrow_Click(object sender, EventArgs e)//BORROW BUTTON
        {

        }
    }
}
