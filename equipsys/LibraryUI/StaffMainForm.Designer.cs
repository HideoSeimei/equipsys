namespace equipsys
{
    partial class MAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            UserTitlelbl = new Label();
            mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            UserProfileName = new Label();
            panel = new Panel();
            panel10 = new Panel();
            button13 = new Button();
            panel11 = new Panel();
            pictureBox5 = new PictureBox();
            profileName = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            button8 = new Button();
            button9 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            search = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox6 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            mainPanel.SuspendLayout();
            panel.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(73, 38);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(138, 38);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(382, 50);
            label2.Name = "label2";
            label2.Size = new Size(50, 14);
            label2.TabIndex = 4;
            label2.Text = "Log out";
            label2.Click += label2_Click;
            // 
            // UserTitlelbl
            // 
            UserTitlelbl.AutoSize = true;
            UserTitlelbl.BackColor = Color.Transparent;
            UserTitlelbl.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            UserTitlelbl.ForeColor = Color.FromArgb(32, 33, 35);
            UserTitlelbl.Location = new Point(224, 28);
            UserTitlelbl.Name = "UserTitlelbl";
            UserTitlelbl.Size = new Size(127, 26);
            UserTitlelbl.TabIndex = 7;
            UserTitlelbl.Text = "Equipment";
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(pictureBox1);
            mainPanel.Controls.Add(UserProfileName);
            mainPanel.Controls.Add(pictureBox2);
            mainPanel.Controls.Add(label2);
            mainPanel.CustomizableEdges = customizableEdges3;
            mainPanel.Location = new Point(224, 72);
            mainPanel.Name = "mainPanel";
            mainPanel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            mainPanel.Size = new Size(651, 352);
            mainPanel.TabIndex = 21;
            // 
            // UserProfileName
            // 
            UserProfileName.AutoSize = true;
            UserProfileName.BackColor = Color.Black;
            UserProfileName.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UserProfileName.ForeColor = Color.White;
            UserProfileName.Location = new Point(215, 46);
            UserProfileName.Name = "UserProfileName";
            UserProfileName.Size = new Size(99, 28);
            UserProfileName.TabIndex = 23;
            UserProfileName.Text = "Welcome {Role}\r\n{Name}";
            UserProfileName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(32, 33, 35);
            panel.Controls.Add(panel10);
            panel.Controls.Add(pictureBox5);
            panel.Controls.Add(profileName);
            panel.Controls.Add(panel1);
            panel.Controls.Add(panel3);
            panel.Location = new Point(0, 0);
            panel.Margin = new Padding(3, 2, 3, 2);
            panel.Name = "panel";
            panel.Size = new Size(206, 442);
            panel.TabIndex = 46;
            // 
            // panel10
            // 
            panel10.Controls.Add(button13);
            panel10.Controls.Add(panel11);
            panel10.Cursor = Cursors.Hand;
            panel10.Location = new Point(29, 400);
            panel10.Margin = new Padding(3, 2, 3, 2);
            panel10.Name = "panel10";
            panel10.Size = new Size(141, 32);
            panel10.TabIndex = 51;
            // 
            // button13
            // 
            button13.BackgroundImageLayout = ImageLayout.None;
            button13.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button13.ForeColor = Color.White;
            button13.Image = (Image)resources.GetObject("button13.Image");
            button13.ImageAlign = ContentAlignment.MiddleLeft;
            button13.Location = new Point(-6, -18);
            button13.Margin = new Padding(3, 2, 3, 2);
            button13.Name = "button13";
            button13.Padding = new Padding(22, 0, 0, 0);
            button13.Size = new Size(166, 56);
            button13.TabIndex = 45;
            button13.Text = "   Log out";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // panel11
            // 
            panel11.Location = new Point(-17, 6);
            panel11.Margin = new Padding(3, 2, 3, 2);
            panel11.Name = "panel11";
            panel11.Size = new Size(164, 38);
            panel11.TabIndex = 47;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(72, 21);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(54, 43);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 46;
            pictureBox5.TabStop = false;
            // 
            // profileName
            // 
            profileName.AutoSize = true;
            profileName.BackColor = Color.Transparent;
            profileName.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            profileName.ForeColor = Color.White;
            profileName.Location = new Point(49, 368);
            profileName.Name = "profileName";
            profileName.Size = new Size(44, 14);
            profileName.TabIndex = 32;
            profileName.Text = "Profile";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(11, 90);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(141, 38);
            panel1.TabIndex = 46;
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Location = new Point(7, 6);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(141, 38);
            panel2.TabIndex = 47;
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-6, -9);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Padding = new Padding(22, 0, 0, 0);
            button4.Size = new Size(186, 56);
            button4.TabIndex = 45;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-23, -9);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Padding = new Padding(22, 0, 0, 0);
            button2.Size = new Size(186, 56);
            button2.TabIndex = 46;
            button2.Text = "Home";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-6, -9);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Padding = new Padding(22, 0, 0, 0);
            button1.Size = new Size(186, 56);
            button1.TabIndex = 45;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button6);
            panel3.Cursor = Cursors.Hand;
            panel3.Location = new Point(23, 146);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(141, 44);
            panel3.TabIndex = 48;
            // 
            // panel5
            // 
            panel5.Controls.Add(button8);
            panel5.Controls.Add(button9);
            panel5.Location = new Point(14, 12);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(141, 38);
            panel5.TabIndex = 49;
            // 
            // button8
            // 
            button8.BackgroundImageLayout = ImageLayout.None;
            button8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(-23, -9);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Padding = new Padding(22, 0, 0, 0);
            button8.Size = new Size(186, 56);
            button8.TabIndex = 46;
            button8.Text = " History";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackgroundImageLayout = ImageLayout.None;
            button9.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = Color.White;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(-6, -9);
            button9.Margin = new Padding(3, 2, 3, 2);
            button9.Name = "button9";
            button9.Padding = new Padding(22, 0, 0, 0);
            button9.Size = new Size(186, 56);
            button9.TabIndex = 45;
            button9.Text = "Home";
            button9.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(7, 6);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(141, 38);
            panel4.TabIndex = 47;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-6, -9);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Padding = new Padding(22, 0, 0, 0);
            button3.Size = new Size(186, 56);
            button3.TabIndex = 45;
            button3.Text = "  History";
            button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-23, -9);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Padding = new Padding(22, 0, 0, 0);
            button5.Size = new Size(186, 56);
            button5.TabIndex = 46;
            button5.Text = "Home";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackgroundImageLayout = ImageLayout.None;
            button6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(-6, -9);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Padding = new Padding(22, 0, 0, 0);
            button6.Size = new Size(186, 56);
            button6.TabIndex = 45;
            button6.Text = "Home";
            button6.UseVisualStyleBackColor = false;
            // 
            // search
            // 
            search.ForeColor = Color.DimGray;
            search.Location = new Point(393, 30);
            search.Margin = new Padding(3, 2, 3, 2);
            search.Name = "search";
            search.Size = new Size(200, 23);
            search.TabIndex = 48;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(598, 30);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 22);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 47;
            pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(829, 31);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(24, 20);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 50;
            pictureBox6.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(32, 33, 35);
            label3.Location = new Point(691, 33);
            label3.Name = "label3";
            label3.Size = new Size(127, 18);
            label3.TabIndex = 49;
            label3.Text = "Welcome Staff!";
            // 
            // MAIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 441);
            Controls.Add(pictureBox6);
            Controls.Add(label3);
            Controls.Add(search);
            Controls.Add(pictureBox3);
            Controls.Add(panel);
            Controls.Add(mainPanel);
            Controls.Add(UserTitlelbl);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MAIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MAIN";
            Load += MAIN_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label UserTitlelbl;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Label UserProfileName;
        private Panel panel;
        private Panel panel10;
        private Button button13;
        private Panel panel11;
        private PictureBox pictureBox5;
        private Label profileName;
        private Panel panel1;
        private Panel panel2;
        private Button button4;
        private Button button2;
        private Button button1;
        private Panel panel3;
        private Panel panel5;
        private Button button8;
        private Button button9;
        private Panel panel4;
        private Button button3;
        private Button button5;
        private Button button6;
        public TextBox search;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private Label label3;
    }
}