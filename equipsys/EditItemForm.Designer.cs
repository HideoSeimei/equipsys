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
            button3 = new Button();
            button2 = new Button();
            NewImagePath = new PictureBox();
            button1 = new Button();
            StockBox = new TextBox();
            DescriptionBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            ItemBox = new TextBox();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)NewImagePath).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.ForestGreen;
            button3.Location = new Point(380, 284);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(109, 22);
            button3.TabIndex = 9;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.ForestGreen;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(500, 284);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(109, 22);
            button2.TabIndex = 8;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.ForestGreen;
            button1.Location = new Point(95, 211);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(109, 22);
            button1.TabIndex = 6;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StockBox
            // 
            StockBox.Location = new Point(285, 174);
            StockBox.Margin = new Padding(3, 2, 3, 2);
            StockBox.Name = "StockBox";
            StockBox.Size = new Size(86, 23);
            StockBox.TabIndex = 5;
            // 
            // DescriptionBox
            // 
            DescriptionBox.Location = new Point(285, 114);
            DescriptionBox.Margin = new Padding(3, 2, 3, 2);
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(324, 23);
            DescriptionBox.TabIndex = 4;
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
            // ItemBox
            // 
            ItemBox.Location = new Point(285, 64);
            ItemBox.Margin = new Padding(3, 2, 3, 2);
            ItemBox.Name = "ItemBox";
            ItemBox.Size = new Size(324, 23);
            ItemBox.TabIndex = 3;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(button3);
            guna2Panel1.Controls.Add(button2);
            guna2Panel1.Controls.Add(NewImagePath);
            guna2Panel1.Controls.Add(button1);
            guna2Panel1.Controls.Add(StockBox);
            guna2Panel1.Controls.Add(DescriptionBox);
            guna2Panel1.Controls.Add(ItemBox);
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
        public Button button3;
        public Button button2;
        public PictureBox NewImagePath;
        public Button button1;
        public TextBox StockBox;
        public TextBox DescriptionBox;
        public Label label5;
        public Label label4;
        public Label label3;
        public TextBox ItemBox;
    }
}