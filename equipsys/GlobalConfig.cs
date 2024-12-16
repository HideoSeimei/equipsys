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

        
        /// <summary>
        /// ConnectionString used by all SqlConnections, change string value to your device locale.
        /// </summary>
        public static string ConnectionString = "Data Source=ARKDRAEDON;Initial Catalog=EquipmentBorrowing;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        /// <summary>
        /// UserReposString used by all image sources, change string value to your device locale.
        /// </summary>
        public static string UserReposString = "arkme";
    }
}
