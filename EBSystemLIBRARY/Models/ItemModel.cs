using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using Microsoft.Data.SqlClient;
using EBSystemLIBRARY;

namespace EBSystemLIBRARY.Models
{
    public class ItemModel
    {
        public int ID { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int ItemStock { get; set; }
        public string ImagePath { get; set; }
        
        // CONSTRUCTORS
        public ItemModel()
        {

        }
        public ItemModel(string name, string description, string stock, string imagepath)
        {
            ItemName = name;
            ItemDescription = description;
            ImagePath = imagepath;

            try
            {
                ItemStock = int.Parse(stock);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        // METHODS

        // Save this ItemModel to database
        public bool SaveItem(string name, string description, int stock, string image)
        {
            try
            {
                string finalImagePath = image;
                // when no image is added, default image displays.
                if (string.IsNullOrEmpty(image))
                    finalImagePath = @".\Images\default_image.png";
                // when image is added, find the folder and the image path for the item.
                else
                {
                    string imageFolder = @".\Images";
                    string imageFileName = Path.GetFileName(image);
                    finalImagePath = Path.Combine(imageFolder, imageFileName);
                    File.Copy(image, finalImagePath, true);
                }

                // TODO - CHANGE SqlConnection's CONSTRUCTOR TO YOUR DATA SOURCE AND DB
                // Opens a sql connection and execute an insert query to table Items
                SqlConnection sql = new SqlConnection("Data Source=DESKTOP-QE9SO2J;Initial Catalog=EquipmentBorrowingSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
                string saveItemQuery = "INSERT INTO Items (ItemName, Description, Stock, ImagePath) VALUES(@ITEMNAME, @ITEMDESCRIPTION, @ITEMSTOCK, @ITEMIMAGEPATH)";
                sql.Open();
                SqlCommand cmd = new SqlCommand(saveItemQuery, sql);
                cmd.Parameters.AddWithValue("@ITEMNAME", name);
                cmd.Parameters.AddWithValue("@ITEMDESCRIPTION", description);
                cmd.Parameters.AddWithValue("@ITEMSTOCK", stock);
                cmd.Parameters.AddWithValue("@ITEMIMAGEPATH", finalImagePath);

                // Validation for change in database
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Item added successfully");
                    sql.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Failed to add Item");
                    sql.Close();
                    return false;
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e}");
            }
            return false;
        }
        // Method for deleting Items
        public void DeleteItem(string id)
        {
            using (var conn = new SqlConnection("Data Source=DESKTOP-QE9SO2J;Initial Catalog=EquipmentBorrowingSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
            {
                string query = "delete from Items where item_id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
