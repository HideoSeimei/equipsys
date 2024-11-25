using EBSystemLIBRARY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBSystemLIBRARY.Data_Access
{
    public interface IDataConnection
    {
        ItemModel CreateItem(ItemModel Model);
    }
}
