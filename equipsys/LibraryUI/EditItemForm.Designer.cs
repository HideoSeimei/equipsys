namespace equipsys
{
    partial class EditItemForm
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
<<<<<<< HEAD:equipsys/EditItemForm.Designer.cs
            button3 = new Button();
            button2 = new Button();
            NewImagePath = new PictureBox();
            button1 = new Button();
            StockBox = new TextBox();
            DescriptionBox = new TextBox();
=======
            pictureBox2 = new PictureBox();
            ReturnButton = new Button();
            SaveButton = new Button();
            NewImagePath = new PictureBox();
            BrowseImageButton = new Button();
            ItemStockBox = new TextBox();
            label2 = new Label();
            ItemDescriptionBox = new TextBox();
>>>>>>> 1daeb0249e797aa50fc4235f8904033dfac45c6c:equipsys/LibraryUI/EditItemForm.Designer.cs
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
<<<<<<< HEAD:equipsys/EditItemForm.Designer.cs
            ItemBox = new TextBox();
=======
            pictureBox1 = new PictureBox();
            pictureBox5 = new PictureBox();
            ItemNameBox = new TextBox();
>>>>>>> 1daeb0249e797aa50fc4235f8904033dfac45c6c:equipsys/LibraryUI/EditItemForm.Designer.cs
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)NewImagePath).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
<<<<<<< HEAD:equipsys/EditItemForm.Designer.cs
            // button3
=======
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(41, 141);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 49;
            pictureBox2.TabStop = false;
            // 
            // ReturnButton
>>>>>>> 1daeb0249e797aa50fc4235f8904033dfac45c6c:equipsys/LibraryUI/EditItemForm.Designer.cs
            // 
            ReturnButton.Cursor = Cursors.Hand;
            ReturnButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ReturnButton.ForeColor = Color.ForestGreen;
            ReturnButton.Location = new Point(380, 284);
            ReturnButton.Margin = new Padding(3, 2, 3, 2);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(109, 22);
            ReturnButton.TabIndex = 9;
            ReturnButton.Text = "Back";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.ForestGreen;
            SaveButton.Cursor = Cursors.Hand;
            SaveButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(500, 284);
            SaveButton.Margin = new Padding(3, 2, 3, 2);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(109, 22);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
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
            // BrowseImageButton
            // 
            BrowseImageButton.Cursor = Cursors.Hand;
            BrowseImageButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BrowseImageButton.ForeColor = Color.ForestGreen;
            BrowseImageButton.Location = new Point(95, 211);
            BrowseImageButton.Margin = new Padding(3, 2, 3, 2);
            BrowseImageButton.Name = "BrowseImageButton";
            BrowseImageButton.Size = new Size(109, 22);
            BrowseImageButton.TabIndex = 6;
            BrowseImageButton.Text = "Browse";
            BrowseImageButton.UseVisualStyleBackColor = true;
            BrowseImageButton.Click += BrowseImageButton_Click;
            // 
            // ItemStockBox
            // 
            ItemStockBox.Location = new Point(285, 174);
            ItemStockBox.Margin = new Padding(3, 2, 3, 2);
            ItemStockBox.Name = "ItemStockBox";
            ItemStockBox.Size = new Size(86, 23);
            ItemStockBox.TabIndex = 5;
            // 
<<<<<<< HEAD:equipsys/EditItemForm.Designer.cs
            // DescriptionBox
=======
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
>>>>>>> 1daeb0249e797aa50fc4235f8904033dfac45c6c:equipsys/LibraryUI/EditItemForm.Designer.cs
            // 
            ItemDescriptionBox.Location = new Point(285, 114);
            ItemDescriptionBox.Margin = new Padding(3, 2, 3, 2);
            ItemDescriptionBox.Name = "ItemDescriptionBox";
            ItemDescriptionBox.Size = new Size(324, 23);
            ItemDescriptionBox.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.ForestGreen;
            label5.Location = new Point(285, 146);
            label5.Name = "label5";
            label5.Size = new Size(50, 17);
            label5.TabIndex = 2;
            label5.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.ForestGreen;
            label4.Location = new Point(285, 89);
            label4.Name = "label4";
            label4.Size = new Size(92, 17);
            label4.TabIndex = 1;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(285, 37);
            label3.Name = "label3";
            label3.Size = new Size(40, 17);
            label3.TabIndex = 0;
            label3.Text = "Item";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(191, 31);
            label1.Name = "label1";
            label1.Size = new Size(55, 26);
            label1.TabIndex = 52;
            label1.Text = "Edit";
            // 
<<<<<<< HEAD:equipsys/EditItemForm.Designer.cs
            // ItemBox
=======
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
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
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(41, 268);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(37, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 54;
            pictureBox5.TabStop = false;
            // 
            // ItemNameBox
>>>>>>> 1daeb0249e797aa50fc4235f8904033dfac45c6c:equipsys/LibraryUI/EditItemForm.Designer.cs
            // 
            ItemNameBox.Location = new Point(285, 64);
            ItemNameBox.Margin = new Padding(3, 2, 3, 2);
            ItemNameBox.Name = "ItemNameBox";
            ItemNameBox.Size = new Size(324, 23);
            ItemNameBox.TabIndex = 3;
            // 
            // guna2Panel1
            // 
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
            guna2Panel1.Location = new Point(191, 76);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(659, 334);
            guna2Panel1.TabIndex = 53;
            // 
            // EditItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(886, 441);
            Controls.Add(label1);
            Controls.Add(guna2Panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EditItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EDIT_ITEMS";
            Load += EditItemForm_Load;
            ((System.ComponentModel.ISupportInitialize)NewImagePath).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
<<<<<<< HEAD:equipsys/EditItemForm.Designer.cs
        public Button button3;
        public Button button2;
=======
        private PictureBox pictureBox3;
        public Button ReturnButton;
        public Button SaveButton;
>>>>>>> 1daeb0249e797aa50fc4235f8904033dfac45c6c:equipsys/LibraryUI/EditItemForm.Designer.cs
        public PictureBox NewImagePath;
        public Button BrowseImageButton;
        public TextBox ItemStockBox;
        public TextBox ItemDescriptionBox;
        public Label label5;
        public Label label4;
        public Label label3;
        public TextBox ItemNameBox;
    }
}