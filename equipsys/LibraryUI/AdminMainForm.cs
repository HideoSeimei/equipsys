﻿using equipsys.LibraryUI;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace equipsys
    // TODO - add function to retrieve items from database, make sure it refreshes every new item or everytime the page loads or home is clicked.
{


    public partial class AdminMainForm : Form
    {
        public Panel MainPanel => mainPanel; // Make mainPanel accessible
        public string searchBox;
        private System.Windows.Forms.Timer timer;
        public int AccountId;
        public string AccountName;

        public AdminMainForm()
        {
            InitializeComponent();//to immediately show the itemform in the panel
            OpenEquipment();
            //for timer 
            // Initialize the Timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();
            //

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Code to refresh data or UI
            ItemForm itemform = new ItemForm();
            itemform.ReloadFlowLayoutPanel();
        }
        private void items_Click(object sender, EventArgs e)// ITEMS BUTTON
        {
            //for opening the items form
            ItemForm items = new ItemForm() { TopLevel = false, TopMost = true };
            items.FormBorderStyle = FormBorderStyle.None;
            items.Size = mainPanel.ClientSize;
            items.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(items);
            items.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // for loging out (will send you back to login form)
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
            //

        }

        private void record_Click(object sender, EventArgs e)
        {
            //for opening the records form
            HistoryLogForm record = new HistoryLogForm() { TopLevel = false, TopMost = true };
            record.FormBorderStyle = FormBorderStyle.None;
            record.Size = mainPanel.ClientSize;
            record.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(record);
            record.Show();
            //

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //for displaying itemform inside the panel
            ItemForm items = new ItemForm() { TopLevel = false, TopMost = true };
            items.FormBorderStyle = FormBorderStyle.None;
            items.Size = mainPanel.ClientSize;
            items.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(items);
            items.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //for opening the Add item  form
            AddItemForm add_item_form = new AddItemForm();
            add_item_form.Show();
            this.Hide();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //for opening the records form
            HistoryLogForm record = new HistoryLogForm() { TopLevel = false, TopMost = true };
            record.FormBorderStyle = FormBorderStyle.None;
            record.Size = mainPanel.ClientSize;
            record.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(record);
            record.Show();
            //
        }


        private void pictureBox5_Click(object sender, EventArgs e)// REGISTER BUTTON
        {

            //OPEN THE REGISTRATION FORM
            RegistrationForm registration = new RegistrationForm();
            registration.Show();
        }

        private void AccountsButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }

        private void AccountsButton_Click_1(object sender, EventArgs e)
        {
            RegistrationForm regform = new RegistrationForm();
            regform.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
        //                =================================================== THIS ARE ALL THE NEW BUTTONS ===================================================
        private void button4_Click(object sender, EventArgs e)// HOME
        {
            //for opening the items form
            OpenEquipment();
            AdminTitlelbl.Text = "Equipment";// to change the label base on what panel are you on
        }


        private void button8_Click(object sender, EventArgs e)// HISTORY/RECORDS
        {
            OpenRecords();
            AdminTitlelbl.Text = "Records";// to change the label base on what panel are you on
        }

        private void button10_Click(object sender, EventArgs e)// SIGN IN 
        {
            // For opening the registration form
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)// ADD ITEM
        {
            OpenAddItem();
            AdminTitlelbl.Text = "Add Item";// to change the label base on what panel are you on
        }

        private void button13_Click(object sender, EventArgs e)// LOGOUT BUTTON
        {
            // for loging out (will send you back to Admin login form)
            LoginFormAdmin loginAdmin = new LoginFormAdmin();
            loginAdmin.Show();
            this.Hide();
            //
        }
        private void button1_Click(object sender, EventArgs e)//ARCHIVE BUTTON
        {
            OpenArchive();
            AdminTitlelbl.Text = "Archive";
        }
        //=====================================================================================================METHODS============================================================
        public void OpenEquipment()// for opening the itemsform
        {
            ItemForm items = new ItemForm() { TopLevel = false, TopMost = true };
            items.FormBorderStyle = FormBorderStyle.None;
            items.Size = mainPanel.ClientSize;
            items.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(items);
            items.Show();
        }
        public void OpenAddItem()// for opening add item form
        {
            //for opening the add item form
            AddItemForm Additem = new AddItemForm() { TopLevel = false, TopMost = true };
            Additem.FormBorderStyle = FormBorderStyle.None;
            Additem.Size = mainPanel.ClientSize;
            Additem.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(Additem);
            Additem.Show();
            //
        }
        public void OpenRecords()// for opening records/history
        {
            //for opening the records form
            HistoryLogForm record = new HistoryLogForm() { TopLevel = false, TopMost = true };
            record.FormBorderStyle = FormBorderStyle.None;
            record.Size = mainPanel.ClientSize;
            record.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(record);
            record.Show();
            //
        }
        public void OpenArchive()// for opening Archive
        {
            //
            ArchiveForm archive = new ArchiveForm() { TopLevel = false, TopMost = true };
            archive.FormBorderStyle = FormBorderStyle.None;
            archive.Size = mainPanel.ClientSize;
            archive.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(archive);
            archive.Show();
            //
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
