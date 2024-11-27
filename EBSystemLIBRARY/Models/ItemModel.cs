using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public ItemModel(string name,string description,int stock,string imagepath)
        {
            ItemName = name;
            ItemDescription = description;
            ItemStock = stock;
            ImagePath = imagepath;


        }


        //METHODS
        public bool Additem()




    }
}
