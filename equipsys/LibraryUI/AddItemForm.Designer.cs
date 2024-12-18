namespace equipsys
{
    partial class AddItemForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemForm));
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ReturnButton = new Button();
            SaveItemButton = new Button();
            BorrowingImageBox = new PictureBox();
            AddImageButton = new Button();
            ItemStockBox = new TextBox();
            ItemDescriptionBox = new TextBox();
            ItemNameBox = new TextBox();
            StockLabel = new Label();
            DescriptionLabel = new Label();
            ItemNameLabel = new Label();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BorrowingImageBox).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.LightGray;
            guna2Panel1.Controls.Add(ReturnButton);
            guna2Panel1.Controls.Add(SaveItemButton);
            guna2Panel1.Controls.Add(BorrowingImageBox);
            guna2Panel1.Controls.Add(AddImageButton);
            guna2Panel1.Controls.Add(ItemStockBox);
            guna2Panel1.Controls.Add(ItemDescriptionBox);
            guna2Panel1.Controls.Add(ItemNameBox);
            guna2Panel1.Controls.Add(StockLabel);
            guna2Panel1.Controls.Add(DescriptionLabel);
            guna2Panel1.Controls.Add(ItemNameLabel);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(651, 352);
            guna2Panel1.TabIndex = 46;
            // 
            // ReturnButton
            // 
            ReturnButton.Cursor = Cursors.Hand;
            ReturnButton.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ReturnButton.ForeColor = Color.FromArgb(32, 33, 35);
            ReturnButton.Location = new Point(394, 319);
            ReturnButton.Margin = new Padding(3, 2, 3, 2);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(118, 22);
            ReturnButton.TabIndex = 4;
            ReturnButton.Text = "Back";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Visible = false;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // SaveItemButton
            // 
            SaveItemButton.BackColor = Color.FromArgb(32, 33, 35);
            SaveItemButton.Cursor = Cursors.Hand;
            SaveItemButton.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            SaveItemButton.ForeColor = Color.White;
            SaveItemButton.Location = new Point(518, 319);
            SaveItemButton.Margin = new Padding(3, 2, 3, 2);
            SaveItemButton.Name = "SaveItemButton";
            SaveItemButton.Size = new Size(121, 22);
            SaveItemButton.TabIndex = 5;
            SaveItemButton.Text = "Save";
            SaveItemButton.UseVisualStyleBackColor = false;
            SaveItemButton.Click += SaveButton_Click;
            // 
            // BorrowingImageBox
            // 
            BorrowingImageBox.Image = (Image)resources.GetObject("BorrowingImageBox.Image");
            BorrowingImageBox.Location = new Point(48, 36);
            BorrowingImageBox.Margin = new Padding(3, 2, 3, 2);
            BorrowingImageBox.Name = "BorrowingImageBox";
            BorrowingImageBox.Size = new Size(208, 158);
            BorrowingImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            BorrowingImageBox.TabIndex = 7;
            BorrowingImageBox.TabStop = false;
            // 
            // AddImageButton
            // 
            AddImageButton.Cursor = Cursors.Hand;
            AddImageButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddImageButton.ForeColor = Color.FromArgb(32, 33, 35);
            AddImageButton.Location = new Point(95, 211);
            AddImageButton.Margin = new Padding(3, 2, 3, 2);
            AddImageButton.Name = "AddImageButton";
            AddImageButton.Size = new Size(109, 22);
            AddImageButton.TabIndex = 3;
            AddImageButton.Text = "Browse";
            AddImageButton.UseVisualStyleBackColor = true;
            AddImageButton.Click += AddImageButton_Click;
            // 
            // ItemStockBox
            // 
            ItemStockBox.Location = new Point(285, 105);
            ItemStockBox.Margin = new Padding(3, 2, 3, 2);
            ItemStockBox.Name = "ItemStockBox";
            ItemStockBox.Size = new Size(86, 23);
            ItemStockBox.TabIndex = 1;
            // 
            // ItemDescriptionBox
            // 
            ItemDescriptionBox.Location = new Point(285, 152);
            ItemDescriptionBox.Margin = new Padding(3, 2, 3, 2);
            ItemDescriptionBox.Multiline = true;
            ItemDescriptionBox.Name = "ItemDescriptionBox";
            ItemDescriptionBox.Size = new Size(303, 137);
            ItemDescriptionBox.TabIndex = 2;
            // 
            // ItemNameBox
            // 
            ItemNameBox.Location = new Point(285, 58);
            ItemNameBox.Margin = new Padding(3, 2, 3, 2);
            ItemNameBox.Name = "ItemNameBox";
            ItemNameBox.Size = new Size(303, 23);
            ItemNameBox.TabIndex = 0;
            // 
            // StockLabel
            // 
            StockLabel.AutoSize = true;
            StockLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            StockLabel.ForeColor = Color.FromArgb(32, 33, 35);
            StockLabel.Location = new Point(285, 83);
            StockLabel.Name = "StockLabel";
            StockLabel.Size = new Size(46, 20);
            StockLabel.TabIndex = 2;
            StockLabel.Text = "Stock";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            DescriptionLabel.ForeColor = Color.FromArgb(32, 33, 35);
            DescriptionLabel.Location = new Point(285, 130);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(87, 20);
            DescriptionLabel.TabIndex = 1;
            DescriptionLabel.Text = "Description";
            // 
            // ItemNameLabel
            // 
            ItemNameLabel.AutoSize = true;
            ItemNameLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ItemNameLabel.ForeColor = Color.FromArgb(32, 33, 35);
            ItemNameLabel.Location = new Point(285, 36);
            ItemNameLabel.Name = "ItemNameLabel";
            ItemNameLabel.Size = new Size(84, 20);
            ItemNameLabel.TabIndex = 0;
            ItemNameLabel.Text = "Item Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 350);
            label2.Name = "label2";
            label2.Size = new Size(50, 14);
            label2.TabIndex = 44;
            label2.Text = "Log out";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 352);
            Controls.Add(guna2Panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADD_ITEMS";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BorrowingImageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label2;
        private Button AddImageButton;
        private Button ReturnButton;
        private Button SaveItemButton;
        private OpenFileDialog openFileDialog1;
        public Label ItemNameLabel;
        public TextBox ItemStockBox;
        public TextBox ItemDescriptionBox;
        public TextBox ItemNameBox;
        public Label StockLabel;
        public Label DescriptionLabel;
        public PictureBox BorrowingImageBox;
    }
}