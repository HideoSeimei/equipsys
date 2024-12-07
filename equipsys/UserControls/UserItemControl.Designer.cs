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
            UDescriptionlbl = new Label();
            Borrow = new Button();
            UItemIDlbl = new Label();
            ((System.ComponentModel.ISupportInitialize)UimageBox).BeginInit();
            SuspendLayout();
            // 
            // UimageBox
            // 
            UimageBox.Image = (Image)resources.GetObject("UimageBox.Image");
            UimageBox.Location = new Point(39, 10);
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
            UNamelbl.ForeColor = Color.DimGray;
            UNamelbl.Location = new Point(259, 22);
            UNamelbl.Name = "UNamelbl";
            UNamelbl.Size = new Size(51, 20);
            UNamelbl.TabIndex = 3;
            UNamelbl.Text = "NAME";
            UNamelbl.Click += label3_Click;
            // 
            // UStocklbl
            // 
            UStocklbl.AutoSize = true;
            UStocklbl.BackColor = Color.Transparent;
            UStocklbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            UStocklbl.ForeColor = Color.DimGray;
            UStocklbl.Location = new Point(259, 57);
            UStocklbl.Name = "UStocklbl";
            UStocklbl.Size = new Size(53, 20);
            UStocklbl.TabIndex = 4;
            UStocklbl.Text = "STOCK";
            UStocklbl.Click += label2_Click_1;
            // 
            // UAvailability
            // 
            UAvailability.AutoSize = true;
            UAvailability.BackColor = Color.Transparent;
            UAvailability.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            UAvailability.ForeColor = Color.DimGray;
            UAvailability.Location = new Point(259, 89);
            UAvailability.Name = "UAvailability";
            UAvailability.Size = new Size(97, 20);
            UAvailability.TabIndex = 5;
            UAvailability.Text = "AVAILABILITY";
            // 
            // UDescriptionlbl
            // 
            UDescriptionlbl.AutoSize = true;
            UDescriptionlbl.BackColor = Color.Transparent;
            UDescriptionlbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            UDescriptionlbl.ForeColor = Color.DimGray;
            UDescriptionlbl.Location = new Point(494, 22);
            UDescriptionlbl.Name = "UDescriptionlbl";
            UDescriptionlbl.Size = new Size(100, 20);
            UDescriptionlbl.TabIndex = 8;
            UDescriptionlbl.Text = "DESCRIPTION";
            // 
            // Borrow
            // 
            Borrow.BackColor = Color.SteelBlue;
            Borrow.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Borrow.ForeColor = Color.White;
            Borrow.Location = new Point(482, 127);
            Borrow.Margin = new Padding(3, 2, 3, 2);
            Borrow.Name = "Borrow";
            Borrow.Size = new Size(118, 30);
            Borrow.TabIndex = 9;
            Borrow.Text = "BORROW";
            Borrow.UseVisualStyleBackColor = false;
            Borrow.Click += Borrow_Click;
            // 
            // UItemIDlbl
            // 
            UItemIDlbl.AutoSize = true;
            UItemIDlbl.BackColor = Color.Transparent;
            UItemIDlbl.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            UItemIDlbl.ForeColor = Color.DimGray;
            UItemIDlbl.Location = new Point(244, 137);
            UItemIDlbl.Name = "UItemIDlbl";
            UItemIDlbl.Size = new Size(18, 13);
            UItemIDlbl.TabIndex = 10;
            UItemIDlbl.Text = "ID";
            // 
            // UserItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(UItemIDlbl);
            Controls.Add(Borrow);
            Controls.Add(UDescriptionlbl);
            Controls.Add(UAvailability);
            Controls.Add(UStocklbl);
            Controls.Add(UNamelbl);
            Controls.Add(UimageBox);
            Name = "UserItemControl";
            Size = new Size(627, 172);
            Load += ItemUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)UimageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox UimageBox;
        public Label UNamelbl;
        public Label UStocklbl;
        public Label UAvailability;
        public Label UDescriptionlbl;
        public Button Borrow;
        public Label UItemIDlbl;
    }
}
