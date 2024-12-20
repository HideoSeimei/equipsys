using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using equipsys.Models;
using System.Runtime.CompilerServices;
using System.Data;
using System.Data; // Required for DataTable
using System.Windows.Forms;
using equipsys.LibraryUI; // Required for DataGridView

namespace equipsys.Data_Access
{
    public class ItemLoader
    {
        private readonly FlowLayoutPanel _flowLayoutPanel;
        private readonly DataGridView _dataGridView;
        //=========== FLOWLAYOUTPANEL
        public ItemLoader(FlowLayoutPanel flowLayoutPanel)
        {
            _flowLayoutPanel = flowLayoutPanel;
        }
        //=========== DATAGRIDVIEW
        public ItemLoader(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
        }

        public ItemLoader()
        {

        }
        //============================================================ ITEMS ======================================================================
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
        // ============================================================== ARCHIVE ===================================================================
        public List<ItemModel> RetrieveArchive()
        {
            var items = new List<ItemModel>();

            using (var sql = new SqlConnection(GlobalConfig.ConnectionString))
            {
                sql.Open();
                string selectQuery = "SELECT Archive_id, ItemName, Description, Stock,deleted_at FROM Archive";
                SqlCommand cmd = new SqlCommand(selectQuery, sql);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // TODO - fix this error
                        items.Add(new ItemModel
                        {
                            ID = reader.GetInt32(0),
                            ItemName = reader.GetString(1),
                            ItemDescription = reader.GetString(2),
                            ItemStock = reader.GetInt32(3),
                            DeletedAt = reader.GetDateTime(4)

                        });
                    }
                }

            }
            return items;
        }
        public void LoadItemsToDataGridView()
        {
            // Create a new DataTable to hold the data
            DataTable dataTable = new DataTable();

            // Retrieve the items from the database
            List<ItemModel> items = RetrieveArchive();

            // Set up the columns in the DataTable
            dataTable.Columns.Add("Item ID");
            dataTable.Columns.Add("Item Name");
            dataTable.Columns.Add("Description");
            dataTable.Columns.Add("Stock");
            dataTable.Columns.Add("Deleted at");
            


            // Add the rows to the DataTable
            foreach (var item in items)
            {
                dataTable.Rows.Add(item.ID, item.ItemName, item.ItemDescription, item.ItemStock,item.DeletedAt);
            }

            // Bind the DataTable to the DataGridView
            _dataGridView.DataSource = dataTable;
        }
    }
}
