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
        public static string ConnectionString = "Data Source=MSI;Initial Catalog=LogViewHistoryPractice;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
    }
}
