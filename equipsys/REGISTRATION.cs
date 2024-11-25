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
    public partial class REGISTRATION : Form
    {
        public REGISTRATION()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();
            login.Show();
            this.Hide();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)// REGISTER BUTTON
        {
            SqlConnection conn = new SqlConnection("Data Source=ACERRYZEN;Initial Catalog=equipmentsys;Integrated Security=True;Trust Server Certificate=True");
            conn.Open();
            string query = "insert into Accounts(username,password,role,firstname,lastname,course,year,student_id) values(@username,@password,'user',@firstname,@lastname,@course,@year,@student_id)"; // query for inserting the registration data to the database
            SqlCommand cmd = new SqlCommand(query, conn);// the command 
            cmd.Parameters.AddWithValue("@username", usernameReg.Text);
            cmd.Parameters.AddWithValue("@password", passwordReg.Text);
            cmd.Parameters.AddWithValue("@firstname", firstnameReg.Text);
            cmd.Parameters.AddWithValue("@lastname", lastnameReg.Text);
            cmd.Parameters.AddWithValue("@course", courseReg.Text);
            cmd.Parameters.AddWithValue("@year", yearReg.Text);
            cmd.Parameters.AddWithValue("@student_id", studentidReg.Text);
            cmd.ExecuteNonQuery(); // line for executing the command(query) to the database
            MessageBox.Show("Registered Succesfully");
            conn.Close();

            LOGIN login = new LOGIN();
            login.Show();
            this.Hide();    

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
