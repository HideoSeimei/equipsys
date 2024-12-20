using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using Microsoft.Data.SqlClient;

namespace equipsys.Models
{
    public class ItemModel
    {
        public int ID { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int ItemStock { get; set; }
        public string ImagePath { get; set; }
        public DateTime? DeletedAt { get; set; }

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
        // CRUD FUNCTIONS

        public bool AddItem(string name, string description, int stock, string image)
        {
            try
            {
                string finalImagePath = image;
                // when no image is added, default image displays.
                if (string.IsNullOrEmpty(image))

                    finalImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Images\default image.png"); 
                // when image is added, find the folder and the image path for the item.
                else
                {
                    string imageFolder = @"C:\Users\"+(GlobalConfig.UserReposString)+@"\source\repos\equipsys\equipsys\Images\";
                    string imageFileName = Path.GetFileName(image);
                    finalImagePath = Path.Combine(imageFolder, imageFileName);

                    if (File.Exists(finalImagePath))
                        finalImagePath = Path.Combine(imageFolder, imageFileName);
                    else
                        File.Copy(image, finalImagePath, true);
                }

                SqlConnection sql = new SqlConnection(GlobalConfig.ConnectionString);
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

        public void EditItem(int id, string itemname, string description, int stock, string newImage)
        {
            using (SqlConnection sql = new SqlConnection(GlobalConfig.ConnectionString))
            {
                sql.Open();
                string editQuery = "UPDATE Items SET ItemName = @ITEMNAME, Description = @DESCRIPTION, Stock = @STOCK, ImagePath = @IMAGEPATH WHERE item_id = @ID";
                SqlCommand cmd = new SqlCommand(editQuery, sql);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@ITEMNAME", itemname);
                cmd.Parameters.AddWithValue("@DESCRIPTION", description);
                cmd.Parameters.AddWithValue("@STOCK", stock);
                cmd.Parameters.AddWithValue("@IMAGEPATH", newImage);
                

                string finalImagePath = "";
                string imageFolder = @"C:\Users\"+(GlobalConfig.UserReposString)+@"\source\repos\equipsys\equipsys\Images\";
                string imageFileName = Path.GetFileName(newImage);
                finalImagePath = Path.Combine(imageFolder, imageFileName);

                if (File.Exists(finalImagePath))
                    finalImagePath = Path.Combine(imageFolder, imageFileName);
                else
                {
                    try
                    {
                        File.Copy(newImage, finalImagePath, true);
                    }
                    catch
                    {
                        MessageBox.Show("Something went wrong trying to copy image to system");
                    }
                }
                cmd.ExecuteNonQuery();
                ItemForm itemForm = new ItemForm();
                itemForm.ReloadFlowLayoutPanel();
                sql.Close();
            }
        }

        public void DeleteItem(int id)
        {
            using (var sql = new SqlConnection(GlobalConfig.ConnectionString))
            {
                string deleteQuery = "DELETE FROM Items WHERE item_id = @Id";
                SqlCommand cmd = new SqlCommand(deleteQuery, sql);
                cmd.Parameters.AddWithValue("@Id", id);
                sql.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item archived");
            }
        }

        public void AddToArchive(string ItemName,string Description,int Stock,string ImagePath)
        {
            using (var sql = new SqlConnection(GlobalConfig.ConnectionString))
            {
                if (string.IsNullOrEmpty(ImagePath))
                {
                    ImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Images\default image.png");
                }
                string insertQuery = "Insert into Archive(ItemName,Description,Stock,ImagePath) values (@ItemName,@Description,@Stock,@ImagePath);";
                SqlCommand cmd = new SqlCommand(insertQuery, sql);
                cmd.Parameters.AddWithValue("@ItemName", ItemName);
                cmd.Parameters.AddWithValue("@Description", Description);
                cmd.Parameters.AddWithValue("@Stock", Stock);
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
                sql.Open();
                cmd.ExecuteNonQuery();
                sql.Close();
                
            }
        }
    }
}
