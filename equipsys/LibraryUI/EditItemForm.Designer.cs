namespace equipsys
{
    partial class EditItemForm : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditItemForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            openFileDialog1 = new OpenFileDialog();
            button3 = new Button();
            button2 = new Button();
            NewImagePath = new PictureBox();
            button1 = new Button();
            StockBox = new TextBox();
            DescriptionBox = new TextBox();
            pictureBox2 = new PictureBox();
            ReturnButton = new Button();
            SaveButton = new Button();
            BrowseImageButton = new Button();
            ItemStockBox = new TextBox();
            label2 = new Label();
            ItemDescriptionBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            ItemBox = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox5 = new PictureBox();
            ItemNameBox = new TextBox();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            panel = new Panel();
            button10 = new Button();
            button13 = new Button();
            button8 = new Button();
            button7 = new Button();
            pictureBox6 = new PictureBox();
            button4 = new Button();
            pictureBox7 = new PictureBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)NewImagePath).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            guna2Panel1.SuspendLayout();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            // 
            // NewImagePath
            // 
            NewImagePath.Image = (Image)resources.GetObject("NewImagePath.Image");
            NewImagePath.Location = new Point(55, 48);
            NewImagePath.Name = "NewImagePath";
            NewImagePath.Size = new Size(238, 211);
            NewImagePath.SizeMode = PictureBoxSizeMode.StretchImage;
            NewImagePath.TabIndex = 7;
            NewImagePath.TabStop = false;
            NewImagePath.Click += NewImagePath_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // StockBox
            // 
            StockBox.Location = new Point(0, 0);
            StockBox.Name = "StockBox";
            StockBox.Size = new Size(100, 27);
            StockBox.TabIndex = 0;
            // 
            // DescriptionBox
            // 
            DescriptionBox.Location = new Point(0, 0);
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(100, 27);
            DescriptionBox.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Location = new Point(41, 141);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 49;
            pictureBox2.TabStop = false;
            // 
            // ReturnButton
            // 
            ReturnButton.Cursor = Cursors.Hand;
            ReturnButton.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ReturnButton.ForeColor = Color.FromArgb(32, 33, 35);
            ReturnButton.Location = new Point(420, 388);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(139, 29);
            ReturnButton.TabIndex = 9;
            ReturnButton.Text = "Back";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.FromArgb(32, 33, 35);
            SaveButton.Cursor = Cursors.Hand;
            SaveButton.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(565, 388);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(131, 29);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // BrowseImageButton
            // 
            BrowseImageButton.Cursor = Cursors.Hand;
            BrowseImageButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BrowseImageButton.ForeColor = Color.FromArgb(32, 33, 35);
            BrowseImageButton.Location = new Point(109, 281);
            BrowseImageButton.Name = "BrowseImageButton";
            BrowseImageButton.Size = new Size(125, 29);
            BrowseImageButton.TabIndex = 6;
            BrowseImageButton.Text = "Browse";
            BrowseImageButton.UseVisualStyleBackColor = true;
            BrowseImageButton.Click += BrowseImageButton_Click;
            // 
            // ItemStockBox
            // 
            ItemStockBox.Location = new Point(326, 232);
            ItemStockBox.Name = "ItemStockBox";
            ItemStockBox.Size = new Size(98, 27);
            ItemStockBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(37, 350);
            label2.Name = "label2";
            label2.Size = new Size(50, 14);
            label2.TabIndex = 51;
            label2.Text = "Log out";
            // 
            // ItemDescriptionBox
            // 
            ItemDescriptionBox.Location = new Point(326, 152);
            ItemDescriptionBox.Name = "ItemDescriptionBox";
            ItemDescriptionBox.Size = new Size(370, 27);
            ItemDescriptionBox.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(32, 33, 35);
            label5.Location = new Point(326, 195);
            label5.Name = "label5";
            label5.Size = new Size(56, 25);
            label5.TabIndex = 2;
            label5.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(32, 33, 35);
            label4.Location = new Point(326, 119);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 1;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(32, 33, 35);
            label3.Location = new Point(326, 49);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 0;
            label3.Text = "Item";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(32, 33, 35);
            label1.Location = new Point(264, 37);
            label1.Name = "label1";
            label1.Size = new Size(137, 32);
            label1.TabIndex = 52;
            label1.Text = "Edit Item";
            // 
            // ItemBox
            // 
            ItemBox.Location = new Point(0, 0);
            ItemBox.Name = "ItemBox";
            ItemBox.Size = new Size(100, 27);
            ItemBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(41, 77);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Location = new Point(41, 268);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(37, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 54;
            pictureBox5.TabStop = false;
            // 
            // ItemNameBox
            // 
            ItemNameBox.Location = new Point(326, 85);
            ItemNameBox.Name = "ItemNameBox";
            ItemNameBox.Size = new Size(370, 27);
            ItemNameBox.TabIndex = 3;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.LightGray;
            guna2Panel1.Controls.Add(ReturnButton);
            guna2Panel1.Controls.Add(SaveButton);
            guna2Panel1.Controls.Add(NewImagePath);
            guna2Panel1.Controls.Add(BrowseImageButton);
            guna2Panel1.Controls.Add(ItemStockBox);
            guna2Panel1.Controls.Add(ItemDescriptionBox);
            guna2Panel1.Controls.Add(ItemNameBox);
            guna2Panel1.Controls.Add(label5);
            guna2Panel1.Controls.Add(label4);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(264, 107);
            guna2Panel1.Margin = new Padding(3, 4, 3, 4);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(717, 445);
            guna2Panel1.TabIndex = 53;
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(32, 33, 35);
            panel.Controls.Add(button10);
            panel.Controls.Add(button13);
            panel.Controls.Add(button8);
            panel.Controls.Add(button7);
            panel.Controls.Add(pictureBox6);
            panel.Controls.Add(button4);
            panel.Location = new Point(0, -1);
            panel.Name = "panel";
            panel.Size = new Size(235, 589);
            panel.TabIndex = 54;
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
            button13.Location = new Point(22, 478);
            button13.Name = "button13";
            button13.Padding = new Padding(25, 0, 0, 0);
            button13.Size = new Size(190, 75);
            button13.TabIndex = 45;
            button13.Text = "   Log out";
            button13.UseVisualStyleBackColor = false;
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
            button8.Location = new Point(11, 194);
            button8.Name = "button8";
            button8.Padding = new Padding(25, 0, 0, 0);
            button8.Size = new Size(213, 75);
            button8.TabIndex = 46;
            button8.Text = " History";
            button8.UseVisualStyleBackColor = false;
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
            button7.Location = new Point(11, 272);
            button7.Name = "button7";
            button7.Padding = new Padding(25, 0, 0, 0);
            button7.Size = new Size(213, 75);
            button7.TabIndex = 45;
            button7.Text = "     Add Item";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(85, 41);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(62, 57);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 46;
            pictureBox6.TabStop = false;
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
            button4.Location = new Point(9, 110);
            button4.Name = "button4";
            button4.Padding = new Padding(25, 0, 0, 0);
            button4.Size = new Size(213, 75);
            button4.TabIndex = 45;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(949, 43);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(29, 25);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 56;
            pictureBox7.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(32, 33, 35);
            label6.Location = new Point(775, 44);
            label6.Name = "label6";
            label6.Size = new Size(174, 23);
            label6.TabIndex = 55;
            label6.Text = "Welcome Admin!";
            // 
            // EditItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 588);
            Controls.Add(pictureBox7);
            Controls.Add(label6);
            Controls.Add(panel);
            Controls.Add(label1);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EDIT_ITEMS";
            Load += EditItemForm_Load;
            ((System.ComponentModel.ISupportInitialize)NewImagePath).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public Button button3;
        public Button button2;
        private PictureBox pictureBox3;
        public Button ReturnButton;
        public Button SaveButton;
        public PictureBox NewImagePath;
        public Button BrowseImageButton;
        public TextBox ItemStockBox;
        public TextBox ItemDescriptionBox;
        public Label label5;
        public Label label4;
        public Label label3;
        public Label label2;
        public TextBox ItemNameBox;
        public PictureBox pictureBox5;
        public PictureBox pictureBox2;
        public Button button1;
        public TextBox StockBox;
        public TextBox DescriptionBox;
        public TextBox ItemBox;
        private Panel panel;
        private Button button13;
        private PictureBox pictureBox6;
        private Button button7;
        private Button button10;
        private Button button4;
        private Button button8;
        private PictureBox pictureBox7;
        private Label label6;
    }
}