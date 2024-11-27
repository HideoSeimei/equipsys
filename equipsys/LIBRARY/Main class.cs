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
        public bool Additem(string name, string description, int stock,string image)
        {
            try
            {
                ADD_ITEMS additem = new ADD_ITEMS();
                // for transferring the selected image locally
                //string imageFolder = @"C:\Users\itiw\source\repos\equipsys\EquipmentBorrowingSystem\equipsys\Images";
                //File.Copy(image, imageFolder, true);
                //string imageFileName = Path.GetFileName(image);
                //string finalImagePath = Path.Combine(imageFolder, imageFileName);
                //

                if (image == null)
                {
                    image = @".\default_image.png";
                }


                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QE9SO2J;Initial Catalog=EquipmentBorrowingSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into Items (ItemName, Description, Stock, ImagePath) Values(@Item_Name , @Description, @Stock, @Image)", conn);
                cmd.Parameters.AddWithValue("Item_Name", name);
                cmd.Parameters.AddWithValue("Description", description);
                cmd.Parameters.AddWithValue("Stock", stock);
                cmd.Parameters.AddWithValue("Image", image);
              
                int rowsAffected = cmd.ExecuteNonQuery();
                //MessageBox.Show($"Item Name: {itemName}, Description: {description}, Stock: {stock}");


                if (rowsAffected > 0)
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
}
