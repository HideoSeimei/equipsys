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

namespace equipsys
{
    public partial class ADD_ITEMS : Form
    {
        public ADD_ITEMS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=ACERRYZEN;Initial Catalog=equipmentsys;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand cmd = new SqlCommand("Insert into ItemStockList (ItemName, Description, Stock, ImagePath) Values(@Item_Name, @D_escription, @S_tock, @Image_Path)", conn);
            cmd.Parameters.AddWithValue("Item_Name", textBox1.Text);
            cmd.Parameters.AddWithValue("D_escription", textBox2.Text);
            cmd.Parameters.AddWithValue("S_tock", textBox3.Text);
            cmd.Parameters.AddWithValue("Image_Path", openFileDialog1.FileName);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Saved Successfully");

            // used to return to MAIN_ADMIN form

            MAIN_ADMIN mainadminform = new MAIN_ADMIN();
            mainadminform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MAIN_ADMIN mainadminform = new MAIN_ADMIN();
            mainadminform.Show();
            this.Hide();
        }

        private void ADD_ITEMS_Load(object sender, EventArgs e)
        {

        }
    }
}
