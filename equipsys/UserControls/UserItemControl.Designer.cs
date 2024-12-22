namespace equipsys
{
    partial class UserItemControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserItemControl));
            UimageBox = new PictureBox();
            UNamelbl = new Label();
            UStocklbl = new Label();
            UAvailability = new Label();
            UItemIDlbl = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            UDescriptionlbl = new Label();
            BorrowingButton = new Button();
            ((System.ComponentModel.ISupportInitialize)UimageBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UimageBox
            // 
            UimageBox.Image = (Image)resources.GetObject("UimageBox.Image");
            UimageBox.Location = new Point(28, 10);
            UimageBox.Name = "UimageBox";
            UimageBox.Size = new Size(199, 147);
            UimageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            UimageBox.TabIndex = 0;
            UimageBox.TabStop = false;
            // 
            // UNamelbl
            // 
            UNamelbl.AutoSize = true;
            UNamelbl.BackColor = Color.Transparent;
            UNamelbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            UNamelbl.ForeColor = Color.FromArgb(32, 33, 35);
            UNamelbl.Location = new Point(259, 22);
            UNamelbl.Name = "UNamelbl";
            UNamelbl.Size = new Size(51, 20);
            UNamelbl.TabIndex = 3;
            UNamelbl.Text = "NAME";
            // 
            // UStocklbl
            // 
            UStocklbl.AutoSize = true;
            UStocklbl.BackColor = Color.Transparent;
            UStocklbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            UStocklbl.ForeColor = Color.FromArgb(32, 33, 35);
            UStocklbl.Location = new Point(259, 57);
            UStocklbl.Name = "UStocklbl";
            UStocklbl.Size = new Size(53, 20);
            UStocklbl.TabIndex = 4;
            UStocklbl.Text = "STOCK";
            // 
            // UAvailability
            // 
            UAvailability.AutoSize = true;
            UAvailability.BackColor = Color.Transparent;
            UAvailability.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            UAvailability.ForeColor = Color.FromArgb(32, 33, 35);
            UAvailability.Location = new Point(259, 89);
            UAvailability.Name = "UAvailability";
            UAvailability.Size = new Size(97, 20);
            UAvailability.TabIndex = 5;
            UAvailability.Text = "AVAILABILITY";
            UAvailability.Click += UAvailability_Click;
            // 
            // UItemIDlbl
            // 
            UItemIDlbl.AutoSize = true;
            UItemIDlbl.BackColor = Color.Transparent;
            UItemIDlbl.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            UItemIDlbl.ForeColor = Color.FromArgb(32, 33, 35);
            UItemIDlbl.Location = new Point(259, 142);
            UItemIDlbl.Name = "UItemIDlbl";
            UItemIDlbl.Size = new Size(18, 13);
            UItemIDlbl.TabIndex = 10;
            UItemIDlbl.Text = "ID";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(28, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(259, 22);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 3;
            label3.Text = "NAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(259, 57);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 4;
            label2.Text = "STOCK";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(259, 89);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 5;
            label1.Text = "AVAILABILITY";
            // 
            // UDescriptionlbl
            // 
            UDescriptionlbl.BackColor = Color.Transparent;
            UDescriptionlbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            UDescriptionlbl.ForeColor = Color.FromArgb(32, 33, 35);
            UDescriptionlbl.Location = new Point(420, 22);
            UDescriptionlbl.MaximumSize = new Size(300, 0);
            UDescriptionlbl.MinimumSize = new Size(100, 100);
            UDescriptionlbl.Name = "UDescriptionlbl";
            UDescriptionlbl.Size = new Size(192, 100);
            UDescriptionlbl.TabIndex = 8;
            UDescriptionlbl.Text = "DESCRIPTION";
            UDescriptionlbl.Click += UDescriptionlbl_Click;
            // 
            // BorrowingButton
            // 
            BorrowingButton.BackColor = Color.Teal;
            BorrowingButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BorrowingButton.ForeColor = Color.White;
            BorrowingButton.Location = new Point(511, 127);
            BorrowingButton.Margin = new Padding(3, 2, 3, 2);
            BorrowingButton.Name = "BorrowingButton";
            BorrowingButton.Size = new Size(101, 30);
            BorrowingButton.TabIndex = 10;
            BorrowingButton.Text = "BORROW";
            BorrowingButton.UseVisualStyleBackColor = false;
            BorrowingButton.Click += BorrowingButton_Click;
            // 
            // UserItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(UItemIDlbl);
            Controls.Add(UAvailability);
            Controls.Add(UStocklbl);
            Controls.Add(UNamelbl);
            Controls.Add(UimageBox);
            Controls.Add(BorrowingButton);
            Controls.Add(UDescriptionlbl);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Name = "UserItemControl";
            Size = new Size(634, 172);
            Load += UserItemControl_Load;
            ((System.ComponentModel.ISupportInitialize)UimageBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox UimageBox;
        public Label UNamelbl;
        public Label UStocklbl;
        public Label UAvailability;
        public Label UItemIDlbl;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label UDescriptionlbl;
        private Button BorrowingButton;
    }
}
