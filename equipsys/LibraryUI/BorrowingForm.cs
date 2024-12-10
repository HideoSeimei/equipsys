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
    public partial class BorrowingForm : Form
    {
        SqlConnection sql = new SqlConnection(GlobalConfig.ConnectionString);
        public string ItemName { get; set; }
        public string ImagePath { get; set; }
        public BorrowingForm()
        {
            InitializeComponent();
        }

        private void BORROWING_Load(object sender, EventArgs e)
        {
          
            BorrowingItemName.Text = ItemName;

        }

        private void yearReg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql.Open();
            SqlCommand cmd = sql.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            //change table name
            cmd.CommandText = "insert into history values ('" + firstnameReg.Text + "', '" + lastnameReg.Text + "', '" + studentidReg.Text + "', '" + yearReg.Text + "','" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "', '" + BorrowingItemName.Text + "', '" + comboBox2.Text + "', '" + textBox3.Text + "', '" + comboBox3.Text + "', '" + comboBox4 + "', 'Ongoing')";
            cmd.ExecuteNonQuery();
            sql.Close();
            MessageBox.Show("Record Inserted Successfully");

            MAIN mainForm = new MAIN();
            mainForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MAIN mainForm = new MAIN();
            mainForm.Show();
            this.Close();
        }

        private bool ValidateForm()
        {
            if (firstnameReg.Text.Length == 0)
                return false;
            if (lastnameReg.Text.Length == 0)
                return false;
            if (studentidReg.Text.Length == 0)
                return false;
            if (textBox1.Text.Length == 0)
                return false;

            return true;
        }
    }
}
