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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN));
            UserTitlelbl = new Label();
            mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            panel = new Panel();
            panel10 = new Panel();
            button13 = new Button();
            panel11 = new Panel();
            pictureBox5 = new PictureBox();
            button4 = new Button();
            button8 = new Button();
            search = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox6 = new PictureBox();
            label3 = new Label();
            panel.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // UserTitlelbl
            // 
            UserTitlelbl.AutoSize = true;
            UserTitlelbl.BackColor = Color.Transparent;
            UserTitlelbl.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            UserTitlelbl.ForeColor = Color.FromArgb(32, 33, 35);
            UserTitlelbl.Location = new Point(256, 37);
            UserTitlelbl.Name = "UserTitlelbl";
            UserTitlelbl.Size = new Size(163, 32);
            UserTitlelbl.TabIndex = 7;
            UserTitlelbl.Text = "Equipment";
            // 
            // mainPanel
            // 
            mainPanel.CustomizableEdges = customizableEdges3;
            mainPanel.Location = new Point(256, 96);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            mainPanel.Size = new Size(744, 469);
            mainPanel.TabIndex = 21;
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(32, 33, 35);
            panel.Controls.Add(button8);
            panel.Controls.Add(panel10);
            panel.Controls.Add(button4);
            panel.Controls.Add(pictureBox5);
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(235, 589);
            panel.TabIndex = 46;
            // 
            // panel10
            // 
            panel10.Controls.Add(button13);
            panel10.Controls.Add(panel11);
            panel10.Cursor = Cursors.Hand;
            panel10.Location = new Point(33, 533);
            panel10.Name = "panel10";
            panel10.Size = new Size(161, 43);
            panel10.TabIndex = 51;
            // 
            // button13
            // 
            button13.BackgroundImageLayout = ImageLayout.None;
            button13.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button13.ForeColor = Color.White;
            button13.Image = (Image)resources.GetObject("button13.Image");
            button13.ImageAlign = ContentAlignment.MiddleLeft;
            button13.Location = new Point(-7, -24);
            button13.Name = "button13";
            button13.Padding = new Padding(25, 0, 0, 0);
            button13.Size = new Size(190, 75);
            button13.TabIndex = 45;
            button13.Text = "   Log out";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // panel11
            // 
            panel11.Location = new Point(-19, 8);
            panel11.Name = "panel11";
            panel11.Size = new Size(187, 51);
            panel11.TabIndex = 47;
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
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(10, 109);
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
            button8.Location = new Point(9, 194);
            button8.Name = "button8";
            button8.Padding = new Padding(25, 0, 0, 0);
            button8.Size = new Size(213, 75);
            button8.TabIndex = 46;
            button8.Text = " History";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // search
            // 
            search.ForeColor = Color.DimGray;
            search.Location = new Point(449, 40);
            search.Name = "search";
            search.Size = new Size(228, 27);
            search.TabIndex = 48;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(683, 40);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 47;
            pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(949, 41);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(27, 27);
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
            label3.Location = new Point(792, 44);
            label3.Name = "label3";
            label3.Size = new Size(158, 23);
            label3.TabIndex = 49;
            label3.Text = "Welcome Staff!";
            // 
            // MAIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 588);
            Controls.Add(pictureBox6);
            Controls.Add(label3);
            Controls.Add(search);
            Controls.Add(pictureBox3);
            Controls.Add(panel);
            Controls.Add(mainPanel);
            Controls.Add(UserTitlelbl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MAIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MAIN";
            panel.ResumeLayout(false);
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label UserTitlelbl;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Panel panel;
        private Panel panel10;
        private Button button13;
        private Panel panel11;
        private PictureBox pictureBox5;
        private Button button4;
        private Button button8;
        public TextBox search;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private Label label3;
    }
}