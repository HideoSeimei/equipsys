﻿namespace equipsys
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            panel2 = new Panel();
            pictureBox6 = new PictureBox();
            passwordbox = new TextBox();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            usernamebox = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            accountChecker = new Label();
            label3 = new Label();
            RoleLbl = new Label();
            pictureBox5 = new PictureBox();
            panel3 = new Panel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ExitBTN = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExitBTN).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(665, 297);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 20;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.ForestGreen;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.DisabledLinkColor = Color.FromArgb(32, 33, 35);
            linkLabel1.ForeColor = Color.FromArgb(32, 33, 35);
            linkLabel1.LinkColor = Color.FromArgb(32, 33, 35);
            linkLabel1.Location = new Point(858, 357);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(125, 20);
            linkLabel1.TabIndex = 19;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password?";
            linkLabel1.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(32, 33, 35);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(649, 396);
            button1.Name = "button1";
            button1.Size = new Size(333, 45);
            button1.TabIndex = 15;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(passwordbox);
            panel2.Controls.Add(pictureBox4);
            panel2.Location = new Point(654, 285);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 59);
            panel2.TabIndex = 17;
            // 
            // pictureBox6
            // 
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(291, 21);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(20, 19);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // passwordbox
            // 
            passwordbox.BackColor = Color.WhiteSmoke;
            passwordbox.BorderStyle = BorderStyle.None;
            passwordbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            passwordbox.ForeColor = Color.DimGray;
            passwordbox.Location = new Point(64, 17);
            passwordbox.Name = "passwordbox";
            passwordbox.PlaceholderText = " Password";
            passwordbox.Size = new Size(253, 23);
            passwordbox.TabIndex = 1;
            passwordbox.UseSystemPasswordChar = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-1, -1);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(59, 60);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(usernamebox);
            panel1.Location = new Point(654, 205);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 59);
            panel1.TabIndex = 16;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-1, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(59, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // usernamebox
            // 
            usernamebox.BackColor = Color.WhiteSmoke;
            usernamebox.BorderStyle = BorderStyle.None;
            usernamebox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            usernamebox.ForeColor = Color.DimGray;
            usernamebox.Location = new Point(64, 17);
            usernamebox.Name = "usernamebox";
            usernamebox.PlaceholderText = " Username";
            usernamebox.Size = new Size(253, 23);
            usernamebox.TabIndex = 1;
            usernamebox.TextChanged += usernamebox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(32, 33, 35);
            label1.Location = new Point(643, 97);
            label1.Name = "label1";
            label1.Size = new Size(340, 34);
            label1.TabIndex = 21;
            label1.Text = "Login to Your Account";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(309, 484);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(247, 484);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(65, 81);
            label6.Name = "label6";
            label6.Size = new Size(465, 64);
            label6.TabIndex = 27;
            label6.Text = "Management Information System\r\n(Borrowing System)";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // accountChecker
            // 
            accountChecker.AutoSize = true;
            accountChecker.BackColor = Color.Transparent;
            accountChecker.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            accountChecker.ForeColor = Color.Crimson;
            accountChecker.Location = new Point(702, 346);
            accountChecker.Name = "accountChecker";
            accountChecker.Size = new Size(14, 20);
            accountChecker.TabIndex = 29;
            accountChecker.Text = " ";
            accountChecker.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(123, 403);
            label3.Name = "label3";
            label3.Size = new Size(367, 51);
            label3.TabIndex = 31;
            label3.Text = "Our MIS Borrowing System makes borrowing items a breeze!\r\nRequest, track, and return with ease—all while keeping\r\neverything organized and hassle-free.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RoleLbl
            // 
            RoleLbl.AutoSize = true;
            RoleLbl.BackColor = Color.Transparent;
            RoleLbl.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RoleLbl.ForeColor = Color.FromArgb(32, 33, 35);
            RoleLbl.Location = new Point(741, 155);
            RoleLbl.Name = "RoleLbl";
            RoleLbl.Size = new Size(141, 23);
            RoleLbl.TabIndex = 32;
            RoleLbl.Text = "Login as staff";
            RoleLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(195, 185);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(205, 189);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 33;
            pictureBox5.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(32, 33, 35);
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(label6);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(-1, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(603, 591);
            panel3.TabIndex = 34;
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.Gainsboro;
            guna2Button1.Cursor = Cursors.Hand;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Gray;
            guna2Button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(651, 460);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(333, 36);
            guna2Button1.TabIndex = 35;
            guna2Button1.Text = "Back to Role Selection";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // ExitBTN
            // 
            ExitBTN.BackgroundImage = (Image)resources.GetObject("ExitBTN.BackgroundImage");
            ExitBTN.Cursor = Cursors.Hand;
            ExitBTN.Location = new Point(979, 12);
            ExitBTN.Name = "ExitBTN";
            ExitBTN.Size = new Size(22, 23);
            ExitBTN.SizeMode = PictureBoxSizeMode.StretchImage;
            ExitBTN.TabIndex = 64;
            ExitBTN.TabStop = false;
            ExitBTN.Click += ExitBTN_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1013, 587);
            Controls.Add(ExitBTN);
            Controls.Add(guna2Button1);
            Controls.Add(panel3);
            Controls.Add(RoleLbl);
            Controls.Add(accountChecker);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff Login";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ExitBTN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private LinkLabel linkLabel1;
        private Button button1;
        private Panel panel2;
        private TextBox passwordbox;
        private PictureBox pictureBox4;
        private Panel panel1;
        private PictureBox pictureBox3;
        private TextBox usernamebox;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label6;
        private PictureBox pictureBox6;
        private Label accountChecker;
        private Label label3;
        private Label RoleLbl;
        private PictureBox pictureBox5;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private PictureBox ExitBTN;
    }
}
