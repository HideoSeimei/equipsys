using EBSystemLIBRARY.Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBSystemLIBRARY
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections = new List<IDataConnection>();

        public static void InitializeConnections ()
        {

        }
    }
}
