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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            AddStaffBTN = new Button();
            button13 = new Button();
            HistoryBTN = new Button();
            AddItemBTN = new Button();
            pictureBox6 = new PictureBox();
            HomeBTN = new Button();
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
            NewImagePath.Location = new Point(48, 36);
            NewImagePath.Margin = new Padding(3, 2, 3, 2);
            NewImagePath.Name = "NewImagePath";
            NewImagePath.Size = new Size(208, 158);
            NewImagePath.SizeMode = PictureBoxSizeMode.StretchImage;
            NewImagePath.TabIndex = 7;
            NewImagePath.TabStop = false;
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
            StockBox.Size = new Size(100, 23);
            StockBox.TabIndex = 0;
            // 
            // DescriptionBox
            // 
            DescriptionBox.Location = new Point(0, 0);
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(100, 23);
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
            ReturnButton.Location = new Point(368, 294);
            ReturnButton.Margin = new Padding(3, 2, 3, 2);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(122, 22);
            ReturnButton.TabIndex = 4;
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
            SaveButton.Location = new Point(496, 294);
            SaveButton.Margin = new Padding(3, 2, 3, 2);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(115, 22);
            SaveButton.TabIndex = 5;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // BrowseImageButton
            // 
            BrowseImageButton.Cursor = Cursors.Hand;
            BrowseImageButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BrowseImageButton.ForeColor = Color.FromArgb(32, 33, 35);
            BrowseImageButton.Location = new Point(95, 211);
            BrowseImageButton.Margin = new Padding(3, 2, 3, 2);
            BrowseImageButton.Name = "BrowseImageButton";
            BrowseImageButton.Size = new Size(109, 22);
            BrowseImageButton.TabIndex = 3;
            BrowseImageButton.Text = "Browse";
            BrowseImageButton.UseVisualStyleBackColor = true;
            BrowseImageButton.Click += BrowseImageButton_Click;
            // 
            // ItemStockBox
            // 
            ItemStockBox.Location = new Point(285, 100);
            ItemStockBox.Margin = new Padding(3, 2, 3, 2);
            ItemStockBox.Name = "ItemStockBox";
            ItemStockBox.Size = new Size(86, 23);
            ItemStockBox.TabIndex = 1;
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
            ItemDescriptionBox.Location = new Point(285, 144);
            ItemDescriptionBox.Margin = new Padding(3, 2, 3, 2);
            ItemDescriptionBox.Multiline = true;
            ItemDescriptionBox.Name = "ItemDescriptionBox";
            ItemDescriptionBox.Size = new Size(324, 144);
            ItemDescriptionBox.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(32, 33, 35);
            label5.Location = new Point(285, 80);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 2;
            label5.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(32, 33, 35);
            label4.Location = new Point(285, 123);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 1;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(32, 33, 35);
            label3.Location = new Point(285, 36);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 0;
            label3.Text = "Item";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(32, 33, 35);
            label1.Location = new Point(231, 28);
            label1.Name = "label1";
            label1.Size = new Size(108, 26);
            label1.TabIndex = 52;
            label1.Text = "Edit Item";
            // 
            // ItemBox
            // 
            ItemBox.Location = new Point(0, 0);
            ItemBox.Name = "ItemBox";
            ItemBox.Size = new Size(100, 23);
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
            ItemNameBox.Location = new Point(285, 57);
            ItemNameBox.Margin = new Padding(3, 2, 3, 2);
            ItemNameBox.Name = "ItemNameBox";
            ItemNameBox.Size = new Size(324, 23);
            ItemNameBox.TabIndex = 0;
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
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Location = new Point(231, 80);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(627, 334);
            guna2Panel1.TabIndex = 53;
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(32, 33, 35);
            panel.Controls.Add(AddStaffBTN);
            panel.Controls.Add(button13);
            panel.Controls.Add(HistoryBTN);
            panel.Controls.Add(AddItemBTN);
            panel.Controls.Add(pictureBox6);
            panel.Controls.Add(HomeBTN);
            panel.Location = new Point(0, -1);
            panel.Margin = new Padding(3, 2, 3, 2);
            panel.Name = "panel";
            panel.Size = new Size(206, 442);
            panel.TabIndex = 54;
            // 
            // AddStaffBTN
            // 
            AddStaffBTN.BackgroundImageLayout = ImageLayout.None;
            AddStaffBTN.Cursor = Cursors.Hand;
            AddStaffBTN.FlatAppearance.BorderSize = 0;
            AddStaffBTN.FlatStyle = FlatStyle.Flat;
            AddStaffBTN.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddStaffBTN.ForeColor = Color.White;
            AddStaffBTN.Image = (Image)resources.GetObject("AddStaffBTN.Image");
            AddStaffBTN.ImageAlign = ContentAlignment.MiddleLeft;
            AddStaffBTN.Location = new Point(10, 265);
            AddStaffBTN.Margin = new Padding(3, 2, 3, 2);
            AddStaffBTN.Name = "AddStaffBTN";
            AddStaffBTN.Padding = new Padding(22, 0, 0, 0);
            AddStaffBTN.Size = new Size(186, 56);
            AddStaffBTN.TabIndex = 9;
            AddStaffBTN.Text = "Add Staff";
            AddStaffBTN.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            button13.BackgroundImageLayout = ImageLayout.None;
            button13.Cursor = Cursors.Hand;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button13.ForeColor = Color.White;
            button13.Image = (Image)resources.GetObject("button13.Image");
            button13.ImageAlign = ContentAlignment.MiddleLeft;
            button13.Location = new Point(19, 358);
            button13.Margin = new Padding(3, 2, 3, 2);
            button13.Name = "button13";
            button13.Padding = new Padding(22, 0, 0, 0);
            button13.Size = new Size(166, 56);
            button13.TabIndex = 10;
            button13.Text = "   Log out";
            button13.UseVisualStyleBackColor = false;
            // 
            // HistoryBTN
            // 
            HistoryBTN.BackgroundImageLayout = ImageLayout.None;
            HistoryBTN.Cursor = Cursors.Hand;
            HistoryBTN.FlatAppearance.BorderSize = 0;
            HistoryBTN.FlatStyle = FlatStyle.Flat;
            HistoryBTN.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HistoryBTN.ForeColor = Color.White;
            HistoryBTN.Image = (Image)resources.GetObject("HistoryBTN.Image");
            HistoryBTN.ImageAlign = ContentAlignment.MiddleLeft;
            HistoryBTN.Location = new Point(10, 146);
            HistoryBTN.Margin = new Padding(3, 2, 3, 2);
            HistoryBTN.Name = "HistoryBTN";
            HistoryBTN.Padding = new Padding(22, 0, 0, 0);
            HistoryBTN.Size = new Size(186, 56);
            HistoryBTN.TabIndex = 7;
            HistoryBTN.Text = "History";
            HistoryBTN.UseVisualStyleBackColor = false;
            // 
            // AddItemBTN
            // 
            AddItemBTN.BackgroundImageLayout = ImageLayout.None;
            AddItemBTN.Cursor = Cursors.Hand;
            AddItemBTN.FlatAppearance.BorderSize = 0;
            AddItemBTN.FlatStyle = FlatStyle.Flat;
            AddItemBTN.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddItemBTN.ForeColor = Color.White;
            AddItemBTN.Image = (Image)resources.GetObject("AddItemBTN.Image");
            AddItemBTN.ImageAlign = ContentAlignment.MiddleLeft;
            AddItemBTN.Location = new Point(10, 204);
            AddItemBTN.Margin = new Padding(3, 2, 3, 2);
            AddItemBTN.Name = "AddItemBTN";
            AddItemBTN.Padding = new Padding(22, 0, 0, 0);
            AddItemBTN.Size = new Size(186, 56);
            AddItemBTN.TabIndex = 8;
            AddItemBTN.Text = "Add Item";
            AddItemBTN.UseVisualStyleBackColor = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(74, 31);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(54, 43);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 46;
            pictureBox6.TabStop = false;
            // 
            // HomeBTN
            // 
            HomeBTN.BackgroundImageLayout = ImageLayout.None;
            HomeBTN.Cursor = Cursors.Hand;
            HomeBTN.FlatAppearance.BorderSize = 0;
            HomeBTN.FlatStyle = FlatStyle.Flat;
            HomeBTN.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HomeBTN.ForeColor = Color.White;
            HomeBTN.Image = (Image)resources.GetObject("HomeBTN.Image");
            HomeBTN.ImageAlign = ContentAlignment.MiddleLeft;
            HomeBTN.Location = new Point(8, 82);
            HomeBTN.Margin = new Padding(3, 2, 3, 2);
            HomeBTN.Name = "HomeBTN";
            HomeBTN.Padding = new Padding(22, 0, 0, 0);
            HomeBTN.Size = new Size(186, 56);
            HomeBTN.TabIndex = 6;
            HomeBTN.Text = "Home";
            HomeBTN.UseVisualStyleBackColor = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(830, 32);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(25, 19);
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
            label6.Location = new Point(678, 33);
            label6.Name = "label6";
            label6.Size = new Size(140, 18);
            label6.TabIndex = 55;
            label6.Text = "Welcome Admin!";
            // 
            // EditItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 441);
            Controls.Add(pictureBox7);
            Controls.Add(label6);
            Controls.Add(panel);
            Controls.Add(label1);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
        private Button AddItemBTN;
        private Button AddStaffBTN;
        private Button HomeBTN;
        private Button HistoryBTN;
        private PictureBox pictureBox7;
        private Label label6;
    }
}