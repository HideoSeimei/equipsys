using EBSystemLIBRARY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBSystemLIBRARY.Data_Access
{
    public class SqlConnector : IDataConnection
    {
        public ItemModel CreateItem(ItemModel Model)
        {
            Model.ID = 1;
            return Model;
        }
    }
}
