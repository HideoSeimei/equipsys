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
        private readonly ItemLoader _itemLoader;

        //CONSTRUCTOR
        
        public ItemModel(ItemLoader itemLoader)
        {
            _itemLoader = itemLoader;
        }

        public ItemModel()
        {
            //    ItemName = name;
            //    ItemDescription = description;
            //    ItemStock = stock;
            //    ImagePath = imagepath;


        }


        //METHODS
        public bool Additem(string name, string description, int stock,string image)
        {
            try
            {
                //ADD_ITEMS additem = new ADD_ITEMS();

                string finalImagePath = image;
                if (string.IsNullOrEmpty(image)) // if the image is null it will become the "default image" in the folder
                {
                    finalImagePath = @".\Images\default_image.png";
                }
                else
                {
                    // for transferring the selected image locally
                    string imageFolder = @"C:\Users\itiw\source\repos\equipsys\equipsys\Images\";
                    string imageFileName = Path.GetFileName(image);
                    finalImagePath = Path.Combine(imageFolder, imageFileName);
                    if (File.Exists(finalImagePath))
                    {
                        finalImagePath = Path.Combine(imageFolder, imageFileName);
                    }
                    else
                    {
                        File.Copy(image, finalImagePath, true);
                        
                    }
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
        public void Delete(int id)// Method for deleting items in the database
        {
            using (var conn = new SqlConnection("Data Source=DESKTOP-QE9SO2J;Initial Catalog=EquipmentBorrowingSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
            {
                MessageBox.Show($"Attempting to delete item with ID: {id}");
                string query = "delete from Items where item_id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id",id);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("DeletedSuccefully");
             
                

            }
        }
        public void EditItem(int id,string ItemName,string Description,int Stock,string NewImage)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-QE9SO2J;Initial Catalog=EquipmentBorrowingSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
            {
                string query = "update Items set ItemName = @itemName,Description = @description,Stock = @stock,ImagePath = @imagePath where item_id = @id";
                SqlCommand cmd = new SqlCommand(query,con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@itemName",ItemName);
                cmd.Parameters.AddWithValue("@description",Description);
                cmd.Parameters.AddWithValue("@stock", Stock);
                cmd.Parameters.AddWithValue("@imagePath",NewImage);
                con.Open();
                MessageBox.Show($"ID: {id}, ItemName: {ItemName}, Description: {Description}, Stock: {Stock}");
                //for transfering the new image to the local storage
                string finalImagePath = "";
                string imageFolder = @"C:\Users\itiw\source\repos\equipsys\equipsys\Images\";
                string imageFileName = Path.GetFileName(NewImage);
                finalImagePath = Path.Combine(imageFolder, imageFileName);
                if (File.Exists(finalImagePath))
                {
                    finalImagePath = Path.Combine(imageFolder, imageFileName);
                }
                else
                {
                    File.Copy(NewImage, finalImagePath, true);
                    MessageBox.Show("Copied");

                }
                cmd.ExecuteNonQuery(); // for updating the database
                ItemForm itemform = new ItemForm();
                itemform.ReloadFlowLayoutPanel();
                itemform.Show();
                






            }
        }




    }
    public class ItemLoader
    {
        private readonly FlowLayoutPanel _flowLayoutPanel;

        //CONSTRUCTOR
        public ItemLoader(FlowLayoutPanel flowLayoutPanel)
        {
            _flowLayoutPanel = flowLayoutPanel;
        }
        public ItemLoader()
        {

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
        //overloading for loadintitems
        public void LoadItemsToFlowLayoutPanel(FlowLayoutPanel flp)
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


    }
}
