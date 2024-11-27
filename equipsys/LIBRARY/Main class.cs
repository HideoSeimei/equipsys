//using EBSystemLIBRARY.Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using equipsys;
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
        public bool Additem(string name, string description, int stock)
        {
            try
            {

                ADD_ITEMS additem = new ADD_ITEMS();
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QE9SO2J;Initial Catalog=EquipmentBorrowingSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into Items (ItemName, Description, Stock) Values(@Item_Name , @Description, @Stock)", conn);
                cmd.Parameters.AddWithValue("Item_Name", name);
                cmd.Parameters.AddWithValue("Description", description);
                cmd.Parameters.AddWithValue("Stock", stock);
                //cmd.Parameters.AddWithValue("Image", additem.openFileDialog1.FileName);
              
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
                
                return true;

            }
            catch (Exception ex)/// just incase theres an error 
            {
                
                MessageBox.Show($"{ex}");

            }
            return false;
        }




    }
}
