using equipsys.LibraryUI;
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
        public string imagePath { get; set; }
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

        private void ReturningButton_Click(object sender, EventArgs e)
        {
            ReturningForm returningForm = new ReturningForm();
            returningForm.Show();
            this.Hide();
        }

        private void BorrowingButton_Click(object sender, EventArgs e)//BORROW
        {

            BorrowingForm borrowingForm = new BorrowingForm();
            borrowingForm.ItemName = UNamelbl.Text;
            borrowingForm.Description = UDescriptionlbl.Text;
            borrowingForm.Stock = UStocklbl.Text;
            borrowingForm.BorrowingImageDisplay = UimageBox.ImageLocation;
            borrowingForm.Show();
            this.Parent.Hide();
        }

        private void UserItemControl_Load(object sender, EventArgs e)
        {

        }
    }
}
