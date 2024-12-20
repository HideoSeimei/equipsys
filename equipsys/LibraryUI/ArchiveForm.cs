using equipsys.Data_Access;
using equipsys.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace equipsys.LibraryUI
{
    public partial class ArchiveForm : Form
    {
        public ArchiveForm()
        {
            InitializeComponent();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ArchiveForm_Load(object sender, EventArgs e)
        {
            ItemLoader itemLoader = new ItemLoader(ArchiveDataGridView);

            // Load data into the DataGridView
            itemLoader.LoadItemsToDataGridView();

            ArchiveDataGridView.Columns["Deleted at"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SetupContextMenu();

        }
        private void ArchiveDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ArchiveDataGridView.ClearSelection();
                ArchiveDataGridView.Rows[e.RowIndex].Selected = true; // Select the row that was right-clicked
            }
        }
       
        //=============================================================METHODS ============================================
        private void SetupContextMenu()
        {
            
            ContextMenuStrip contextMenu = new ContextMenuStrip(); // for creting a new contextmenu

            // Create menu items for Delete and Restore
            ToolStripMenuItem deleteItem = new ToolStripMenuItem("Delete");
            ToolStripMenuItem restoreItem = new ToolStripMenuItem("Restore");
            //

            // event handler for clicking delete or restore
            deleteItem.Click += DeleteItem_Click;  // Handler for delete
            restoreItem.Click += RestoreItem_Click;  // Handler for restore

            // Add items to context menu
            contextMenu.Items.Add(deleteItem);
            contextMenu.Items.Add(restoreItem);

            
            ArchiveDataGridView.ContextMenuStrip = contextMenu; // for attaching the contextmenu to datagrid
        }

        private void DeleteItem_Click(object sender, EventArgs e)// FOR DELETING ITEM
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this item\n( Cannot be recovered )",
                                          "Confirmation",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);// delete confirmation
            if (result == DialogResult.Yes) //  If the user clicked YES
            {
                if (ArchiveDataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to delete.");
                    return;
                }

                var selectedRow = ArchiveDataGridView.SelectedRows[0];  // Get the first selected row

                // Try to get the ItemID from the cell and parse it to an int
                string itemIdStr = selectedRow.Cells["Item ID"].Value.ToString();  
                int itemId;

                if (int.TryParse(itemIdStr, out itemId)) // to parse string to int
                {
                    
                    DeleteItemFromDatabase(itemId);// delete method

                    RefreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Invalid Item ID. Could not delete the item.");
                }
            }
            
        }


        private void RestoreItem_Click(object sender, EventArgs e)
        {
            if (ArchiveDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to restore.");
                return;
            }

            var selectedRow = ArchiveDataGridView.SelectedRows[0];  // Get the first selected row

            // Try to get the ItemID from the cell and parse it to an int
            string itemIdStr = selectedRow.Cells["Item ID"].Value.ToString();  
            int itemId;

            if (int.TryParse(itemIdStr, out itemId)) // to parse the string as int
            {
               
                RestoreItemToDatabase(itemId);//Restore method

                
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Invalid Item ID. Could not restore the item.");
            }
        }

        private void DeleteItemFromDatabase(int itemId)
        {
            using (var connection = new SqlConnection(GlobalConfig.ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM Archive WHERE archive_id = @ItemID", connection);
                command.Parameters.AddWithValue("@ItemID", itemId);
                command.ExecuteNonQuery();
            }
        }

        private void RestoreItemToDatabase(int itemId)
        {
            using (var connection = new SqlConnection(GlobalConfig.ConnectionString))
            {
                connection.Open();

                // Insert data into the Items table from the Archive table, excluding ItemID and added_at 
                var restoreCommand = new SqlCommand(
                    "INSERT INTO Items (ItemName, Description, Stock, ImagePath) " +
                    "SELECT ItemName, Description, Stock, ImagePath " +
                    "FROM Archive WHERE archive_id = @ItemID", connection);
                restoreCommand.Parameters.AddWithValue("@ItemID", itemId);
                restoreCommand.ExecuteNonQuery();
                //

                // code for deleting the item in the archive once it is transferred into items table
                var deleteCommand = new SqlCommand("DELETE FROM Archive WHERE archive_id = @ItemID", connection);
                deleteCommand.Parameters.AddWithValue("@ItemID", itemId);
                deleteCommand.ExecuteNonQuery();
                MessageBox.Show("Item Restored");
                //
            }
        }

        private void RefreshDataGridView()// for refresing the items
        {
            
            ItemLoader itemLoader = new ItemLoader(ArchiveDataGridView);

            // Load data into the DataGridView
            itemLoader.LoadItemsToDataGridView();
        }

        
    }
}
