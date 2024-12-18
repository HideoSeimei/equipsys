using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipsys
{
    public static class GlobalConfig
    {
        // TODO - Change these strings to your local device/database 
        /// <summary>
        /// ConnectionString used by all SqlConnections, change string value to your device locale.
        /// </summary>

        public static string ConnectionString = "Data Source=DESKTOP-QE9SO2J;Initial Catalog=EquipmentBorrowingSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";  
        public static string UserReposString = "itiw";

    }
}
