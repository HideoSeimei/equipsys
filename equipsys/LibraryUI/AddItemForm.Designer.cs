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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemForm));
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            BackButton = new Button();
            SaveItemButton = new Button();
            ImagePictureBox = new PictureBox();
            AddImageButton = new Button();
            ItemStockTextBox = new TextBox();
            ItemDescriptionTextBox = new TextBox();
            ItemNameTextBox = new TextBox();
            ItemStockLabel = new Label();
            ItemDescriptionLabel = new Label();
            ItemNameLabel = new Label();
            AddItemLabel = new Label();
            LogOutLabel = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox5 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImagePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(BackButton);
            guna2Panel1.Controls.Add(SaveItemButton);
            guna2Panel1.Controls.Add(ImagePictureBox);
            guna2Panel1.Controls.Add(AddImageButton);
            guna2Panel1.Controls.Add(ItemStockTextBox);
            guna2Panel1.Controls.Add(ItemDescriptionTextBox);
            guna2Panel1.Controls.Add(ItemNameTextBox);
            guna2Panel1.Controls.Add(ItemStockLabel);
            guna2Panel1.Controls.Add(ItemDescriptionLabel);
            guna2Panel1.Controls.Add(ItemNameLabel);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Location = new Point(186, 76);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(659, 334);
            guna2Panel1.TabIndex = 46;
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.ForeColor = Color.ForestGreen;
            BackButton.Location = new Point(380, 284);
            BackButton.Margin = new Padding(3, 2, 3, 2);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(109, 22);
            BackButton.TabIndex = 9;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // SaveItemButton
            // 
            SaveItemButton.BackColor = Color.ForestGreen;
            SaveItemButton.Cursor = Cursors.Hand;
            SaveItemButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SaveItemButton.ForeColor = Color.White;
            SaveItemButton.Location = new Point(500, 284);
            SaveItemButton.Margin = new Padding(3, 2, 3, 2);
            SaveItemButton.Name = "SaveItemButton";
            SaveItemButton.Size = new Size(109, 22);
            SaveItemButton.TabIndex = 8;
            SaveItemButton.Text = "Save";
            SaveItemButton.UseVisualStyleBackColor = false;
            SaveItemButton.Click += SaveButton_Click;
            // 
            // ImagePictureBox
            // 
            ImagePictureBox.Image = (Image)resources.GetObject("ImagePictureBox.Image");
            ImagePictureBox.Location = new Point(48, 36);
            ImagePictureBox.Margin = new Padding(3, 2, 3, 2);
            ImagePictureBox.Name = "ImagePictureBox";
            ImagePictureBox.Size = new Size(208, 158);
            ImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ImagePictureBox.TabIndex = 7;
            ImagePictureBox.TabStop = false;
            // 
            // AddImageButton
            // 
            AddImageButton.Cursor = Cursors.Hand;
            AddImageButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddImageButton.ForeColor = Color.ForestGreen;
            AddImageButton.Location = new Point(95, 211);
            AddImageButton.Margin = new Padding(3, 2, 3, 2);
            AddImageButton.Name = "AddImageButton";
            AddImageButton.Size = new Size(109, 22);
            AddImageButton.TabIndex = 6;
            AddImageButton.Text = "Browse";
            AddImageButton.UseVisualStyleBackColor = true;
            AddImageButton.Click += AddImageButton_Click;
            // 
            // ItemStockTextBox
            // 
            ItemStockTextBox.Location = new Point(285, 99);
            ItemStockTextBox.Margin = new Padding(3, 2, 3, 2);
            ItemStockTextBox.Name = "ItemStockTextBox";
            ItemStockTextBox.Size = new Size(50, 23);
            ItemStockTextBox.TabIndex = 5;
            // 
            // ItemDescriptionTextBox
            // 
            ItemDescriptionTextBox.Location = new Point(285, 142);
            ItemDescriptionTextBox.Margin = new Padding(3, 2, 3, 2);
            ItemDescriptionTextBox.Multiline = true;
            ItemDescriptionTextBox.Name = "ItemDescriptionTextBox";
            ItemDescriptionTextBox.Size = new Size(324, 138);
            ItemDescriptionTextBox.TabIndex = 4;
            // 
            // ItemNameTextBox
            // 
            ItemNameTextBox.Location = new Point(285, 55);
            ItemNameTextBox.Margin = new Padding(3, 2, 3, 2);
            ItemNameTextBox.Name = "ItemNameTextBox";
            ItemNameTextBox.Size = new Size(324, 23);
            ItemNameTextBox.TabIndex = 3;
            // 
            // ItemStockLabel
            // 
            ItemStockLabel.AutoSize = true;
            ItemStockLabel.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ItemStockLabel.ForeColor = Color.ForestGreen;
            ItemStockLabel.Location = new Point(285, 80);
            ItemStockLabel.Name = "ItemStockLabel";
            ItemStockLabel.Size = new Size(50, 17);
            ItemStockLabel.TabIndex = 2;
            ItemStockLabel.Text = "Stock";
            // 
            // ItemDescriptionLabel
            // 
            ItemDescriptionLabel.AutoSize = true;
            ItemDescriptionLabel.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ItemDescriptionLabel.ForeColor = Color.ForestGreen;
            ItemDescriptionLabel.Location = new Point(285, 124);
            ItemDescriptionLabel.Name = "ItemDescriptionLabel";
            ItemDescriptionLabel.Size = new Size(92, 17);
            ItemDescriptionLabel.TabIndex = 1;
            ItemDescriptionLabel.Text = "Description";
            // 
            // ItemNameLabel
            // 
            ItemNameLabel.AutoSize = true;
            ItemNameLabel.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ItemNameLabel.ForeColor = Color.ForestGreen;
            ItemNameLabel.Location = new Point(285, 36);
            ItemNameLabel.Name = "ItemNameLabel";
            ItemNameLabel.Size = new Size(86, 17);
            ItemNameLabel.TabIndex = 0;
            ItemNameLabel.Text = "Item Name";
            // 
            // AddItemLabel
            // 
            AddItemLabel.AutoSize = true;
            AddItemLabel.BackColor = Color.Transparent;
            AddItemLabel.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddItemLabel.ForeColor = Color.ForestGreen;
            AddItemLabel.Location = new Point(186, 31);
            AddItemLabel.Name = "AddItemLabel";
            AddItemLabel.Size = new Size(108, 26);
            AddItemLabel.TabIndex = 45;
            AddItemLabel.Text = "Add item";
            // 
            // LogOutLabel
            // 
            LogOutLabel.AutoSize = true;
            LogOutLabel.BackColor = Color.Transparent;
            LogOutLabel.Cursor = Cursors.Hand;
            LogOutLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LogOutLabel.ForeColor = Color.White;
            LogOutLabel.Location = new Point(40, 418);
            LogOutLabel.Name = "LogOutLabel";
            LogOutLabel.Size = new Size(50, 14);
            LogOutLabel.TabIndex = 44;
            LogOutLabel.Text = "Log out";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(36, 141);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 42;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 77);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(36, 268);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(37, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 47;
            pictureBox5.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(886, 441);
            Controls.Add(guna2Panel1);
            Controls.Add(AddItemLabel);
            Controls.Add(LogOutLabel);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox5);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADD_ITEMS";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImagePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label AddItemLabel;
        private Label LogOutLabel;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private Button AddImageButton;
        private Button BackButton;
        private Button SaveItemButton;
        private OpenFileDialog openFileDialog1;
        public Label ItemNameLabel;
        public TextBox ItemStockTextBox;
        public TextBox ItemDescriptionTextBox;
        public TextBox ItemNameTextBox;
        public Label ItemStockLabel;
        public Label ItemDescriptionLabel;
        public PictureBox ImagePictureBox;
    }
}