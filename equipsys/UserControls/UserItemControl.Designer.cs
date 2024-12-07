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
<<<<<<< HEAD
            UimageBox = new PictureBox();
            UNamelbl = new Label();
            UStocklbl = new Label();
            UAvailability = new Label();
            UDescriptionlbl = new Label();
            Borrow = new Button();
            UItemIDlbl = new Label();
            Return = new Button();
            ((System.ComponentModel.ISupportInitialize)UimageBox).BeginInit();
=======
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            ReturnButton = new Button();
            BorrowingButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
>>>>>>> 1daeb0249e797aa50fc4235f8904033dfac45c6c
            SuspendLayout();
            // 
            // UimageBox
            // 
<<<<<<< HEAD
            UimageBox.Image = (Image)resources.GetObject("UimageBox.Image");
            UimageBox.Location = new Point(39, 10);
            UimageBox.Name = "UimageBox";
            UimageBox.Size = new Size(199, 147);
            UimageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            UimageBox.TabIndex = 0;
            UimageBox.TabStop = false;
=======
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
>>>>>>> 1daeb0249e797aa50fc4235f8904033dfac45c6c
            // 
            // UNamelbl
            // 
<<<<<<< HEAD
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
=======
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(259, 22);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 3;
            label3.Text = "NAME";
>>>>>>> 1daeb0249e797aa50fc4235f8904033dfac45c6c
            // 
            // UStocklbl
            // 
<<<<<<< HEAD
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
=======
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(259, 57);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 4;
            label2.Text = "STOCK";
>>>>>>> 1daeb0249e797aa50fc4235f8904033dfac45c6c
            // 
            // UAvailability
            // 
<<<<<<< HEAD
            UAvailability.AutoSize = true;
            UAvailability.BackColor = Color.Transparent;
            UAvailability.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            UAvailability.ForeColor = Color.DimGray;
            UAvailability.Location = new Point(259, 89);
            UAvailability.Name = "UAvailability";
            UAvailability.Size = new Size(97, 20);
            UAvailability.TabIndex = 5;
            UAvailability.Text = "AVAILABILITY";
=======
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(259, 89);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 5;
            label1.Text = "AVAILABILITY";
>>>>>>> 1daeb0249e797aa50fc4235f8904033dfac45c6c
            // 
            // UDescriptionlbl
            // 
<<<<<<< HEAD
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
            // Return
            // 
            Return.BackColor = Color.MediumAquamarine;
            Return.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Return.ForeColor = Color.White;
            Return.Location = new Point(342, 128);
            Return.Margin = new Padding(3, 2, 3, 2);
            Return.Name = "Return";
            Return.Size = new Size(118, 30);
            Return.TabIndex = 11;
            Return.Text = "RETURN";
            Return.UseVisualStyleBackColor = false;
            Return.Click += Return_Click;
=======
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(435, 22);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 8;
            label4.Text = "DESCRIPTION";
            // 
            // ReturnButton
            // 
            ReturnButton.BackColor = Color.DarkGoldenrod;
            ReturnButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ReturnButton.ForeColor = Color.White;
            ReturnButton.Location = new Point(494, 135);
            ReturnButton.Margin = new Padding(3, 2, 3, 2);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(118, 30);
            ReturnButton.TabIndex = 9;
            ReturnButton.Text = "RETURN";
            ReturnButton.UseVisualStyleBackColor = false;
            ReturnButton.Click += ReturningButton_Click;
            // 
            // BorrowingButton
            // 
            BorrowingButton.BackColor = Color.SteelBlue;
            BorrowingButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BorrowingButton.ForeColor = Color.White;
            BorrowingButton.Location = new Point(370, 135);
            BorrowingButton.Margin = new Padding(3, 2, 3, 2);
            BorrowingButton.Name = "BorrowingButton";
            BorrowingButton.Size = new Size(118, 30);
            BorrowingButton.TabIndex = 10;
            BorrowingButton.Text = "BORROW";
            BorrowingButton.UseVisualStyleBackColor = false;
            BorrowingButton.Click += BorrowingButton_Click;
>>>>>>> 1daeb0249e797aa50fc4235f8904033dfac45c6c
            // 
            // UserItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
<<<<<<< HEAD
            Controls.Add(Return);
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
=======
            Controls.Add(BorrowingButton);
            Controls.Add(ReturnButton);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Name = "UserItemControl";
            Size = new Size(627, 172);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
>>>>>>> 1daeb0249e797aa50fc4235f8904033dfac45c6c
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

<<<<<<< HEAD
        public PictureBox UimageBox;
        public Label UNamelbl;
        public Label UStocklbl;
        public Label UAvailability;
        public Label UDescriptionlbl;
        public Button Borrow;
        public Label UItemIDlbl;
        public Button Return;
=======
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button ReturnButton;
        private Button BorrowingButton;
>>>>>>> 1daeb0249e797aa50fc4235f8904033dfac45c6c
    }
}
