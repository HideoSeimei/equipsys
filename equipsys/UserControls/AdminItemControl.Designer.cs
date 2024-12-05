namespace equipsys
{
    partial class AdminItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminItemControl));
            imageBox = new PictureBox();
            Namelbl = new Label();
            Stocklbl = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            Descriptionlbl = new Label();
            ItemIdlbl = new Label();
            ((System.ComponentModel.ISupportInitialize)imageBox).BeginInit();
            SuspendLayout();
            // 
            // imageBox
            // 
            imageBox.Image = (Image)resources.GetObject("imageBox.Image");
            imageBox.Location = new Point(45, 13);
            imageBox.Margin = new Padding(3, 4, 3, 4);
            imageBox.Name = "imageBox";
            imageBox.Size = new Size(227, 196);
            imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox.TabIndex = 0;
            imageBox.TabStop = false;
            imageBox.Click += pictureBox1_Click;
            // 
            // Namelbl
            // 
            Namelbl.AutoSize = true;
            Namelbl.BackColor = Color.Transparent;
            Namelbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Namelbl.ForeColor = Color.DimGray;
            Namelbl.Location = new Point(296, 29);
            Namelbl.Name = "Namelbl";
            Namelbl.Size = new Size(62, 25);
            Namelbl.TabIndex = 3;
            Namelbl.Text = "NAME";
            Namelbl.Click += label3_Click;
            // 
            // Stocklbl
            // 
            Stocklbl.AutoSize = true;
            Stocklbl.BackColor = Color.Transparent;
            Stocklbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Stocklbl.ForeColor = Color.DimGray;
            Stocklbl.Location = new Point(296, 76);
            Stocklbl.Name = "Stocklbl";
            Stocklbl.Size = new Size(65, 25);
            Stocklbl.TabIndex = 4;
            Stocklbl.Text = "STOCK";
            Stocklbl.Click += label2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(296, 119);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 5;
            label1.Text = "AVAILABILITY";
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(457, 180);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "EDIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Firebrick;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(592, 180);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Descriptionlbl
            // 
            Descriptionlbl.BackColor = Color.Transparent;
            Descriptionlbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Descriptionlbl.ForeColor = Color.DimGray;
            Descriptionlbl.Location = new Point(497, 29);
            Descriptionlbl.MaximumSize = new Size(343, 0);
            Descriptionlbl.MinimumSize = new Size(114, 133);
            Descriptionlbl.Name = "Descriptionlbl";
            Descriptionlbl.Size = new Size(169, 133);
            Descriptionlbl.TabIndex = 8;
            Descriptionlbl.Text = "DESCRIPTION";
            Descriptionlbl.Click += Descriptionlbl_Click_1;
            // 
            // ItemIdlbl
            // 
            ItemIdlbl.AutoSize = true;
            ItemIdlbl.BackColor = Color.Transparent;
            ItemIdlbl.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ItemIdlbl.ForeColor = Color.DimGray;
            ItemIdlbl.Location = new Point(279, 192);
            ItemIdlbl.Name = "ItemIdlbl";
            ItemIdlbl.Size = new Size(58, 19);
            ItemIdlbl.TabIndex = 9;
            ItemIdlbl.Text = "ITEM ID";
            // 
            // AdminItemControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(ItemIdlbl);
            Controls.Add(Descriptionlbl);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Stocklbl);
            Controls.Add(Namelbl);
            Controls.Add(imageBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminItemControl";
            Size = new Size(717, 229);
            Load += ItemUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)imageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imageBox;
        private Label Namelbl;
        private Label Stocklbl;
        private Label label1;
        private Button button1;
        private Button button2;
        public Label Descriptionlbl;
        private Label ItemIdlbl;
    }
}
