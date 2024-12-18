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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
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
            guna2Panel1.Controls.Add(label5);
            guna2Panel1.Controls.Add(label4);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Margin = new Padding(3, 4, 3, 4);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(744, 469);
            guna2Panel1.TabIndex = 46;
            guna2Panel1.Paint += guna2Panel1_Paint;
            // 
            // ReturnButton
            // 
            ReturnButton.Cursor = Cursors.Hand;
            ReturnButton.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ReturnButton.ForeColor = Color.FromArgb(32, 33, 35);
            ReturnButton.Location = new Point(424, 379);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(135, 29);
            ReturnButton.TabIndex = 9;
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
            SaveItemButton.Location = new Point(565, 379);
            SaveItemButton.Name = "SaveItemButton";
            SaveItemButton.Size = new Size(138, 29);
            SaveItemButton.TabIndex = 8;
            SaveItemButton.Text = "Save";
            SaveItemButton.UseVisualStyleBackColor = false;
            SaveItemButton.Click += SaveButton_Click;
            // 
            // BorrowingImageBox
            // 
            BorrowingImageBox.Image = (Image)resources.GetObject("BorrowingImageBox.Image");
            BorrowingImageBox.Location = new Point(55, 48);
            BorrowingImageBox.Name = "BorrowingImageBox";
            BorrowingImageBox.Size = new Size(238, 211);
            BorrowingImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            BorrowingImageBox.TabIndex = 7;
            BorrowingImageBox.TabStop = false;
            BorrowingImageBox.Click += pictureBox4_Click_1;
            // 
            // AddImageButton
            // 
            AddImageButton.Cursor = Cursors.Hand;
            AddImageButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddImageButton.ForeColor = Color.FromArgb(32, 33, 35);
            AddImageButton.Location = new Point(109, 281);
            AddImageButton.Name = "AddImageButton";
            AddImageButton.Size = new Size(125, 29);
            AddImageButton.TabIndex = 6;
            AddImageButton.Text = "Browse";
            AddImageButton.UseVisualStyleBackColor = true;
            AddImageButton.Click += AddImageButton_Click;
            // 
            // ItemStockBox
            // 
            ItemStockBox.Location = new Point(326, 232);
            ItemStockBox.Name = "ItemStockBox";
            ItemStockBox.Size = new Size(98, 27);
            ItemStockBox.TabIndex = 5;
            // 
            // ItemDescriptionBox
            // 
            ItemDescriptionBox.Location = new Point(326, 192);
            ItemDescriptionBox.Multiline = true;
            ItemDescriptionBox.Name = "ItemDescriptionBox";
            ItemDescriptionBox.Size = new Size(346, 181);
            ItemDescriptionBox.TabIndex = 4;
            // 
            // ItemNameBox
            // 
            ItemNameBox.Location = new Point(326, 85);
            ItemNameBox.Name = "ItemNameBox";
            ItemNameBox.Size = new Size(346, 27);
            ItemNameBox.TabIndex = 3;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(37, 467);
            label2.Name = "label2";
            label2.Size = new Size(62, 17);
            label2.TabIndex = 44;
            label2.Text = "Log out";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 469);
            Controls.Add(guna2Panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADD_ITEMS";
            Load += AddItemForm_Load;
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
        public Label label3;
        public TextBox ItemStockBox;
        public TextBox ItemDescriptionBox;
        public TextBox ItemNameBox;
        public Label label5;
        public Label label4;
        public PictureBox BorrowingImageBox;
    }
}