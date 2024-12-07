using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using equipsys.Models;

namespace equipsys.Data_Access
{
    public class ItemLoader
    {
        private readonly FlowLayoutPanel _flowLayoutPanel;

        public ItemLoader(FlowLayoutPanel flowLayoutPanel)
        {
            _flowLayoutPanel = flowLayoutPanel;
        }

        public ItemLoader()
        {

        }

        public List<ItemModel> RetrieveItems()
        {
            var items = new List<ItemModel>();

            using (var sql = new SqlConnection(GlobalConfig.ConnectionString))
            {
                sql.Open();
                string selectQuery = "SELECT item_id, ItemName, Description, Stock, ImagePath FROM Items";
                SqlCommand cmd = new SqlCommand(selectQuery, sql);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        items.Add(new ItemModel
                        {
                            ID = reader.GetInt32(0),
                            ItemName = reader.GetString(1),
                            ItemDescription = reader.GetString(2),
                            ItemStock = reader.GetInt32(3),
                            ImagePath = reader.GetString(4),
                        });
                    }
                }

            }
            return items;
        }

        public void LoadToPanel()
        {
            List<ItemModel> items = RetrieveItems();

            _flowLayoutPanel.Controls.Clear();

            foreach (var item in items)
            {
                var adminItemControl = new AdminItemControl();
                adminItemControl.SetItemData(item.ID, item.ItemName, item.ItemDescription, item.ItemStock, item.ImagePath);

                _flowLayoutPanel.Controls.Add(adminItemControl);
            }
        }

        // what purpose does this serve
        public void LoadtoPanel(FlowLayoutPanel flp)
        {
            List<ItemModel> items = RetrieveItems();
            _flowLayoutPanel.Controls.Clear();

            foreach (var item in items)
            {
                var adminItemControl = new AdminItemControl();
                adminItemControl.SetItemData(item.ID, item.ItemName, item.ItemDescription, item.ItemStock, item.ImagePath);

                _flowLayoutPanel.Controls.Add(adminItemControl);
            }
        }

        public void ULoadItemsToFlowLayoutPanel()
        {
            List<ItemModel> items = RetrieveItems();

            // Clear existing controls in FlowLayoutPanel
            _flowLayoutPanel.Controls.Clear();

            foreach (var item in items)
            {
                var UserItemControl = new UserItemControl();
                UserItemControl.SetItemData(item.ID, item.ItemName, item.ItemDescription, item.ItemStock, item.ImagePath);

                // Add the new UserControl to the FlowLayoutPanel
                _flowLayoutPanel.Controls.Add(UserItemControl);
            }
        }
        //overloading for loadintitems
        public void ULoadItemsToFlowLayoutPanel(FlowLayoutPanel flp)
        {
            List<ItemModel> items = RetrieveItems();

            // Clear existing controls in FlowLayoutPanel
            _flowLayoutPanel.Controls.Clear();

            foreach (var item in items)
            {
                var UserItemControl = new UserItemControl();
                UserItemControl.SetItemData(item.ID, item.ItemName, item.ItemDescription, item.ItemStock, item.ImagePath);

                // Add the new UserControl to the FlowLayoutPanel
                _flowLayoutPanel.Controls.Add(UserItemControl);
            }
        }
    }
}
