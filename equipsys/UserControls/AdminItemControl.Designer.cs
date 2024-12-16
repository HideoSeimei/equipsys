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
            Availability = new Label();
            button1 = new Button();
            button2 = new Button();
            Descriptionlbl = new Label();
            ItemIdlbl = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)imageBox).BeginInit();
            SuspendLayout();
            // 
            // imageBox
            // 
            imageBox.Image = (Image)resources.GetObject("imageBox.Image");
            imageBox.Location = new Point(12, 11);
            imageBox.Name = "imageBox";
            imageBox.Size = new Size(199, 147);
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
            Namelbl.ForeColor = Color.FromArgb(32, 33, 35);
            Namelbl.Location = new Point(233, 22);
            Namelbl.Name = "Namelbl";
            Namelbl.Size = new Size(51, 20);
            Namelbl.TabIndex = 3;
            Namelbl.Text = "NAME";
            Namelbl.Click += label3_Click;
            // 
            // Stocklbl
            // 
            Stocklbl.AutoSize = true;
            Stocklbl.BackColor = Color.Transparent;
            Stocklbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Stocklbl.ForeColor = Color.FromArgb(32, 33, 35);
            Stocklbl.Location = new Point(233, 57);
            Stocklbl.Name = "Stocklbl";
            Stocklbl.Size = new Size(53, 20);
            Stocklbl.TabIndex = 4;
            Stocklbl.Text = "STOCK";
            Stocklbl.Click += label2_Click_1;
            // 
            // Availability
            // 
            Availability.AutoSize = true;
            Availability.BackColor = Color.Transparent;
            Availability.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Availability.ForeColor = Color.FromArgb(32, 33, 35);
            Availability.Location = new Point(233, 89);
            Availability.Name = "Availability";
            Availability.Size = new Size(97, 20);
            Availability.TabIndex = 5;
            Availability.Text = "AVAILABILITY";
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(413, 127);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(89, 30);
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
            button2.Location = new Point(513, 127);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(86, 30);
            button2.TabIndex = 7;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Descriptionlbl
            // 
            Descriptionlbl.BackColor = Color.Transparent;
            Descriptionlbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Descriptionlbl.ForeColor = Color.FromArgb(32, 33, 35);
            Descriptionlbl.Location = new Point(402, 24);
            Descriptionlbl.MaximumSize = new Size(300, 0);
            Descriptionlbl.MinimumSize = new Size(100, 100);
            Descriptionlbl.Name = "Descriptionlbl";
            Descriptionlbl.Size = new Size(148, 100);
            Descriptionlbl.TabIndex = 8;
            Descriptionlbl.Text = "DESCRIPTION";
            Descriptionlbl.Click += Descriptionlbl_Click_1;
            // 
            // ItemIdlbl
            // 
            ItemIdlbl.AutoSize = true;
            ItemIdlbl.BackColor = Color.Transparent;
            ItemIdlbl.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ItemIdlbl.ForeColor = Color.FromArgb(32, 33, 35);
            ItemIdlbl.Location = new Point(257, 136);
            ItemIdlbl.Name = "ItemIdlbl";
            ItemIdlbl.Size = new Size(18, 13);
            ItemIdlbl.TabIndex = 9;
            ItemIdlbl.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(32, 33, 35);
            label1.Location = new Point(217, 136);
            label1.Name = "label1";
            label1.Size = new Size(49, 13);
            label1.TabIndex = 10;
            label1.Text = "Item ID: ";
            // 
            // AdminItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(label1);
            Controls.Add(ItemIdlbl);
            Controls.Add(Descriptionlbl);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Availability);
            Controls.Add(Stocklbl);
            Controls.Add(Namelbl);
            Controls.Add(imageBox);
            Name = "AdminItemControl";
            Size = new Size(622, 172);
            Load += ItemUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)imageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imageBox;
        private Label Namelbl;
        private Label Stocklbl;
        private Label Availability;
        private Button button1;
        private Button button2;
        public Label Descriptionlbl;
        private Label ItemIdlbl;
        private Label label1;
    }
}
