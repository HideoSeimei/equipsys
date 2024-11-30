//using EBSystemLIBRARY.Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using equipsys;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EBSystemLIBRARY.Models
{
    public class ItemModel
    {
        public int ID { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int ItemStock { get; set; }
        public string ImagePath { get; set; }

        //CONSTRUCTOR

        public ItemModel()
        {
            //    ItemName = name;
            //    ItemDescription = description;
            //    ItemStock = stock;
            //    ImagePath = imagepath;


        }


        //METHODS
        public bool Additem(string name, string description, int stock, string image)
        {
            try
            {
                ADD_ITEMS additem = new ADD_ITEMS();

                string finalImagePath = image;
                if (image == null) // if the image is null it will become the "default image" in the folder
                {
                    finalImagePath = @".\Images\default_image.png";
                }
                else
                {
                    // for transferring the selected image locally
                    string imageFolder = @"C:\Users\itiw\source\repos\equipsys\EquipmentBorrowingSystem\equipsys\Images";
                    string imageFileName = Path.GetFileName(image);
                    finalImagePath = Path.Combine(imageFolder, imageFileName);
                    File.Copy(image, finalImagePath, true);
                    //
                }


                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QE9SO2J;Initial Catalog=EquipmentBorrowingSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into Items (ItemName, Description, Stock, ImagePath) Values(@Item_Name , @Description, @Stock, @Image)", conn);
                cmd.Parameters.AddWithValue("Item_Name", name);
                cmd.Parameters.AddWithValue("Description", description);
                cmd.Parameters.AddWithValue("Stock", stock);
                cmd.Parameters.AddWithValue("Image", finalImagePath);

                int rowsAffected = cmd.ExecuteNonQuery();



                if (rowsAffected > 0) // will check if theres a changes happened inside the database
                {
                    MessageBox.Show("Item added succesfuly");
                    return true;
                }
                else
                {
                    MessageBox.Show("Failed to add the item.");
                    return false;
                }



            }
            catch (Exception ex)/// just incase theres an error 
            {

                MessageBox.Show($"{ex}");

            }
            return false;
        }




    }
    public class ItemLoader
    {
        private readonly FlowLayoutPanel _flowLayoutPanel;

        public ItemLoader(FlowLayoutPanel flowLayoutPanel)
        {
            _flowLayoutPanel = flowLayoutPanel;
        }

        // Method to load items from the database
        public List<ItemModel> GetItemsFromDatabase()
        {
            var items = new List<ItemModel>();

            using (var connection = new SqlConnection("Data Source=DESKTOP-QE9SO2J;Initial Catalog=EquipmentBorrowingSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
            {
                connection.Open();
                var command = new SqlCommand("SELECT item_Id, ItemName, Description, Stock, ImagePath FROM Items", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        items.Add(new ItemModel
                        {
                            ID = reader.GetInt32(0),
                            ItemName = reader.GetString(1),
                            ItemDescription = reader.GetString(2),
                            ItemStock = reader.GetInt32(3),
                            ImagePath = reader.GetString(4)
                        });
                    }
                }
            }

            return items;
        }

        // Method to load items into the FlowLayoutPanel by creating and adding ItemUserControl instances
        public void LoadItemsToFlowLayoutPanel()
        {
            List<ItemModel> items = GetItemsFromDatabase();

            // Clear existing controls in FlowLayoutPanel
            _flowLayoutPanel.Controls.Clear();

            foreach (var item in items)
            {
                var AdminitemControl = new AdminItemControl();
                AdminitemControl.SetItemData(item.ID, item.ItemName, item.ItemDescription, item.ItemStock, item.ImagePath);

                // Add the new UserControl to the FlowLayoutPanel
                _flowLayoutPanel.Controls.Add(AdminitemControl);
            }
        }
        // Method for deleting Items
        public void DeleteItem()
        {
            using (var conn = new SqlConnection("Data Source=DESKTOP-QE9SO2J;Initial Catalog=EquipmentBorrowingSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
            {
                string query = "deleter from Items where item_id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
            }
        }
    }
}