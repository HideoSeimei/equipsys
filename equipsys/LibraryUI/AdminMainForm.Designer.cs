﻿
namespace equipsys
{
    partial class AdminMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            AdminTitlelbl = new Label();
            search = new TextBox();
            pictureBox4 = new PictureBox();
            mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            panel = new Panel();
            button13 = new Button();
            pictureBox5 = new PictureBox();
            button7 = new Button();
            button10 = new Button();
            button4 = new Button();
            button8 = new Button();
            pictureBox6 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // AdminTitlelbl
            // 
            AdminTitlelbl.AutoSize = true;
            AdminTitlelbl.BackColor = Color.Transparent;
            AdminTitlelbl.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            AdminTitlelbl.ForeColor = Color.FromArgb(32, 33, 35);
            AdminTitlelbl.Location = new Point(267, 35);
            AdminTitlelbl.Name = "AdminTitlelbl";
            AdminTitlelbl.Size = new Size(163, 32);
            AdminTitlelbl.TabIndex = 16;
            AdminTitlelbl.Text = "Equipment";
            // 
            // search
            // 
            search.ForeColor = Color.DimGray;
            search.Location = new Point(463, 40);
            search.Name = "search";
            search.Size = new Size(228, 27);
            search.TabIndex = 15;
            search.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(697, 40);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(29, 29);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // mainPanel
            // 
            mainPanel.CustomizableEdges = customizableEdges17;
            mainPanel.Location = new Point(255, 96);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.ShadowDecoration.CustomizableEdges = customizableEdges18;
            mainPanel.Size = new Size(744, 469);
            mainPanel.TabIndex = 20;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(32, 33, 35);
            panel.Controls.Add(button13);
            panel.Controls.Add(button10);
            panel.Controls.Add(pictureBox5);
            panel.Controls.Add(button7);
            panel.Controls.Add(button4);
            panel.Controls.Add(button8);
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(235, 589);
            panel.TabIndex = 45;
            // 
            // button13
            // 
            button13.BackgroundImageLayout = ImageLayout.None;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button13.ForeColor = Color.White;
            button13.Image = (Image)resources.GetObject("button13.Image");
            button13.ImageAlign = ContentAlignment.MiddleLeft;
            button13.Location = new Point(22, 477);
            button13.Name = "button13";
            button13.Padding = new Padding(25, 0, 0, 0);
            button13.Size = new Size(190, 75);
            button13.TabIndex = 45;
            button13.Text = "   Log out";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(82, 28);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(62, 57);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 46;
            pictureBox5.TabStop = false;
            // 
            // button7
            // 
            button7.BackgroundImageLayout = ImageLayout.None;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(10, 272);
            button7.Name = "button7";
            button7.Padding = new Padding(25, 0, 0, 0);
            button7.Size = new Size(213, 75);
            button7.TabIndex = 45;
            button7.Text = "     Add Item";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button10
            // 
            button10.BackgroundImageLayout = ImageLayout.None;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button10.ForeColor = Color.White;
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(12, 353);
            button10.Name = "button10";
            button10.Padding = new Padding(25, 0, 0, 0);
            button10.Size = new Size(213, 75);
            button10.TabIndex = 45;
            button10.Text = " Sign in";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(10, 110);
            button4.Name = "button4";
            button4.Padding = new Padding(25, 0, 0, 0);
            button4.Size = new Size(213, 75);
            button4.TabIndex = 45;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button8
            // 
            button8.BackgroundImageLayout = ImageLayout.None;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(10, 191);
            button8.Name = "button8";
            button8.Padding = new Padding(25, 0, 0, 0);
            button8.Size = new Size(213, 75);
            button8.TabIndex = 46;
            button8.Text = " History";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(949, 45);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(29, 25);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 47;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(32, 33, 35);
            label3.Location = new Point(775, 45);
            label3.Name = "label3";
            label3.Size = new Size(174, 23);
            label3.TabIndex = 46;
            label3.Text = "Welcome Admin!";
            label3.Click += label3_Click;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 588);
            Controls.Add(pictureBox6);
            Controls.Add(label3);
            Controls.Add(panel);
            Controls.Add(mainPanel);
            Controls.Add(AdminTitlelbl);
            Controls.Add(search);
            Controls.Add(pictureBox4);
            ForeColor = Color.DimGray;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MAIN_ADMIN";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Label AdminTitlelbl;
        private PictureBox pictureBox4;
        public TextBox search;
        public Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Panel panel;
        private Button button13;
        private PictureBox pictureBox5;
        private Button button7;
        private Button button10;
        private Button button4;
        private Button button8;
        private PictureBox pictureBox6;
        private Label label3;
    }
}