using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBSystemLIBRARY.Models
{
    public class BorrowerModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentID { get; set; }
        public string Course { get; set; }
        public string Year { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string StocksBorrowed { get; set; }
        public List<ItemModel> ItemsBorrowed { get; set; } = new List<ItemModel>();
    }   
}
