using equipsys.Data_Access;
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

        }
    }
}
