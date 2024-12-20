namespace equipsys
{
    partial class BorrowingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowingForm));
            label1 = new Label();
            label2 = new Label();
            label7 = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            BorrowingDescription = new Label();
            BorrowingStock = new Label();
            BorrowingItemName = new Label();
            BorrowingImage = new PictureBox();
            groupBox1 = new GroupBox();
            BorrowStockValue = new TextBox();
            button3 = new Button();
            label13 = new Label();
            button2 = new Button();
            EndTime = new ComboBox();
            SectionValue = new ComboBox();
            YearValue = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            label12 = new Label();
            EmailValue = new TextBox();
            label11 = new Label();
            ContactNumberValue = new TextBox();
            CourseValue = new ComboBox();
            label4 = new Label();
            StudentIDValue = new TextBox();
            LastNameValue = new TextBox();
            label9 = new Label();
            label10 = new Label();
            FirstNameValue = new TextBox();
            panel = new Panel();
            button13 = new Button();
            button8 = new Button();
            button4 = new Button();
            pictureBox6 = new PictureBox();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            ExitBTN = new PictureBox();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BorrowingImage).BeginInit();
            groupBox1.SuspendLayout();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExitBTN).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(32, 33, 35);
            label1.Location = new Point(262, 35);
            label1.Name = "label1";
            label1.Size = new Size(226, 32);
            label1.TabIndex = 36;
            label1.Text = "Borrowing Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 467);
            label2.Name = "label2";
            label2.Size = new Size(62, 17);
            label2.TabIndex = 35;
            label2.Text = "Log out";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(32, 33, 35);
            label7.Location = new Point(23, 24);
            label7.Name = "label7";
            label7.Size = new Size(174, 20);
            label7.TabIndex = 48;
            label7.Text = "Borrower's Information";
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(BorrowingDescription);
            guna2Panel1.Controls.Add(BorrowingStock);
            guna2Panel1.Controls.Add(BorrowingItemName);
            guna2Panel1.Controls.Add(BorrowingImage);
            guna2Panel1.Controls.Add(groupBox1);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Location = new Point(262, 89);
            guna2Panel1.Margin = new Padding(3, 4, 3, 4);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(721, 473);
            guna2Panel1.TabIndex = 37;
            guna2Panel1.Paint += guna2Panel1_Paint;
            // 
            // BorrowingDescription
            // 
            BorrowingDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BorrowingDescription.ForeColor = Color.FromArgb(32, 33, 35);
            BorrowingDescription.Location = new Point(27, 259);
            BorrowingDescription.MaximumSize = new Size(343, 0);
            BorrowingDescription.MinimumSize = new Size(114, 133);
            BorrowingDescription.Name = "BorrowingDescription";
            BorrowingDescription.Size = new Size(114, 133);
            BorrowingDescription.TabIndex = 58;
            BorrowingDescription.Text = "DESCRIPTION:";
            // 
            // BorrowingStock
            // 
            BorrowingStock.AutoSize = true;
            BorrowingStock.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BorrowingStock.ForeColor = Color.FromArgb(32, 33, 35);
            BorrowingStock.Location = new Point(27, 229);
            BorrowingStock.Name = "BorrowingStock";
            BorrowingStock.Size = new Size(57, 20);
            BorrowingStock.TabIndex = 57;
            BorrowingStock.Text = "STOCK:";
            // 
            // BorrowingItemName
            // 
            BorrowingItemName.AutoSize = true;
            BorrowingItemName.BackColor = Color.Transparent;
            BorrowingItemName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BorrowingItemName.ForeColor = Color.FromArgb(32, 33, 35);
            BorrowingItemName.Location = new Point(27, 196);
            BorrowingItemName.Name = "BorrowingItemName";
            BorrowingItemName.Size = new Size(95, 20);
            BorrowingItemName.TabIndex = 49;
            BorrowingItemName.Text = "ITEM NAME:";
            // 
            // BorrowingImage
            // 
            BorrowingImage.Image = (Image)resources.GetObject("BorrowingImage.Image");
            BorrowingImage.Location = new Point(24, 15);
            BorrowingImage.Name = "BorrowingImage";
            BorrowingImage.Size = new Size(174, 163);
            BorrowingImage.SizeMode = PictureBoxSizeMode.StretchImage;
            BorrowingImage.TabIndex = 50;
            BorrowingImage.TabStop = false;
            BorrowingImage.Click += BorrowingImage_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(BorrowStockValue);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(EndTime);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(SectionValue);
            groupBox1.Controls.Add(YearValue);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(EmailValue);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(ContactNumberValue);
            groupBox1.Controls.Add(CourseValue);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(StudentIDValue);
            groupBox1.Controls.Add(LastNameValue);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(FirstNameValue);
            groupBox1.ForeColor = Color.ForestGreen;
            groupBox1.Location = new Point(216, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 454);
            groupBox1.TabIndex = 49;
            groupBox1.TabStop = false;
            // 
            // BorrowStockValue
            // 
            BorrowStockValue.Location = new Point(23, 308);
            BorrowStockValue.Name = "BorrowStockValue";
            BorrowStockValue.Size = new Size(74, 27);
            BorrowStockValue.TabIndex = 58;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(32, 33, 35);
            button3.Location = new Point(215, 402);
            button3.Name = "button3";
            button3.Size = new Size(128, 29);
            button3.TabIndex = 55;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.FromArgb(32, 33, 35);
            label13.Location = new Point(23, 285);
            label13.Name = "label13";
            label13.Size = new Size(80, 20);
            label13.TabIndex = 56;
            label13.Text = "To Borrow:";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(32, 33, 35);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(349, 402);
            button2.Name = "button2";
            button2.Size = new Size(113, 29);
            button2.TabIndex = 54;
            button2.Text = "Borrow";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // EndTime
            // 
            EndTime.ForeColor = Color.ForestGreen;
            EndTime.FormattingEnabled = true;
            EndTime.Location = new Point(354, 291);
            EndTime.Name = "EndTime";
            EndTime.Size = new Size(83, 28);
            EndTime.TabIndex = 56;
            // 
            // SectionValue
            // 
            SectionValue.ForeColor = Color.FromArgb(32, 33, 35);
            SectionValue.FormattingEnabled = true;
            SectionValue.Items.AddRange(new object[] { "A", "B" });
            SectionValue.Location = new Point(185, 165);
            SectionValue.Name = "SectionValue";
            SectionValue.Size = new Size(63, 28);
            SectionValue.TabIndex = 55;
            SectionValue.Text = "Sec";
            SectionValue.SelectedIndexChanged += SectionBox_SelectedIndexChanged;
            // 
            // YearValue
            // 
            YearValue.ForeColor = Color.FromArgb(32, 33, 35);
            YearValue.FormattingEnabled = true;
            YearValue.Items.AddRange(new object[] { "1st", "2nd", "3rd", "4th" });
            YearValue.Location = new Point(112, 165);
            YearValue.Name = "YearValue";
            YearValue.Size = new Size(65, 28);
            YearValue.TabIndex = 54;
            YearValue.Text = "Yr";
            YearValue.SelectedIndexChanged += yearBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(32, 33, 35);
            label3.Location = new Point(23, 137);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 53;
            label3.Text = "Course/Yr/Sec";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(32, 33, 35);
            label5.Location = new Point(267, 296);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 51;
            label5.Text = "END TIME";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(32, 33, 35);
            label12.Location = new Point(265, 211);
            label12.Name = "label12";
            label12.Size = new Size(46, 20);
            label12.TabIndex = 52;
            label12.Text = "Email";
            // 
            // EmailValue
            // 
            EmailValue.ForeColor = Color.DimGray;
            EmailValue.Location = new Point(263, 239);
            EmailValue.Name = "EmailValue";
            EmailValue.Size = new Size(199, 27);
            EmailValue.TabIndex = 51;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(32, 33, 35);
            label11.Location = new Point(23, 211);
            label11.Name = "label11";
            label11.Size = new Size(118, 20);
            label11.TabIndex = 50;
            label11.Text = "Contact Number";
            // 
            // ContactNumberValue
            // 
            ContactNumberValue.ForeColor = Color.DimGray;
            ContactNumberValue.Location = new Point(23, 236);
            ContactNumberValue.Name = "ContactNumberValue";
            ContactNumberValue.Size = new Size(215, 27);
            ContactNumberValue.TabIndex = 49;
            // 
            // CourseValue
            // 
            CourseValue.ForeColor = Color.FromArgb(32, 33, 35);
            CourseValue.FormattingEnabled = true;
            CourseValue.Items.AddRange(new object[] { "BSCS", "BSIT", "BSIS", "BSEMC" });
            CourseValue.Location = new Point(23, 165);
            CourseValue.Name = "CourseValue";
            CourseValue.Size = new Size(83, 28);
            CourseValue.TabIndex = 39;
            CourseValue.Text = " Course";
            CourseValue.SelectedIndexChanged += courseBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(32, 33, 35);
            label4.Location = new Point(263, 137);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 23;
            label4.Text = "Student ID";
            // 
            // StudentIDValue
            // 
            StudentIDValue.ForeColor = Color.DimGray;
            StudentIDValue.Location = new Point(263, 165);
            StudentIDValue.Name = "StudentIDValue";
            StudentIDValue.Size = new Size(199, 27);
            StudentIDValue.TabIndex = 22;
            // 
            // LastNameValue
            // 
            LastNameValue.ForeColor = Color.DimGray;
            LastNameValue.Location = new Point(263, 88);
            LastNameValue.Name = "LastNameValue";
            LastNameValue.Size = new Size(199, 27);
            LastNameValue.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(32, 33, 35);
            label9.Location = new Point(263, 61);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 20;
            label9.Text = "Last Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(32, 33, 35);
            label10.Location = new Point(23, 61);
            label10.Name = "label10";
            label10.Size = new Size(80, 20);
            label10.TabIndex = 35;
            label10.Text = "First Name";
            // 
            // FirstNameValue
            // 
            FirstNameValue.ForeColor = Color.DimGray;
            FirstNameValue.Location = new Point(23, 88);
            FirstNameValue.Name = "FirstNameValue";
            FirstNameValue.Size = new Size(215, 27);
            FirstNameValue.TabIndex = 36;
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(32, 33, 35);
            panel.Controls.Add(button13);
            panel.Controls.Add(button8);
            panel.Controls.Add(button4);
            panel.Controls.Add(pictureBox6);
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(235, 589);
            panel.TabIndex = 49;
            // 
            // button13
            // 
            button13.BackgroundImageLayout = ImageLayout.None;
            button13.Cursor = Cursors.Hand;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button13.ForeColor = Color.White;
            button13.Image = (Image)resources.GetObject("button13.Image");
            button13.ImageAlign = ContentAlignment.MiddleLeft;
            button13.Location = new Point(22, 475);
            button13.Name = "button13";
            button13.Padding = new Padding(25, 0, 0, 0);
            button13.Size = new Size(190, 75);
            button13.TabIndex = 45;
            button13.Text = "   Log out";
            button13.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackgroundImageLayout = ImageLayout.None;
            button8.Cursor = Cursors.Hand;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(10, 194);
            button8.Name = "button8";
            button8.Padding = new Padding(25, 0, 0, 0);
            button8.Size = new Size(213, 75);
            button8.TabIndex = 46;
            button8.Text = " History";
            button8.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(10, 108);
            button4.Name = "button4";
            button4.Padding = new Padding(25, 0, 0, 0);
            button4.Size = new Size(213, 75);
            button4.TabIndex = 45;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(82, 28);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(62, 57);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 46;
            pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(954, 41);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 51;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(32, 33, 35);
            label6.Location = new Point(780, 42);
            label6.Name = "label6";
            label6.Size = new Size(174, 23);
            label6.TabIndex = 50;
            label6.Text = "Welcome Admin!";
            // 
            // ExitBTN
            // 
            ExitBTN.BackgroundImage = (Image)resources.GetObject("ExitBTN.BackgroundImage");
            ExitBTN.Cursor = Cursors.Hand;
            ExitBTN.Location = new Point(980, 6);
            ExitBTN.Name = "ExitBTN";
            ExitBTN.Size = new Size(22, 23);
            ExitBTN.SizeMode = PictureBoxSizeMode.StretchImage;
            ExitBTN.TabIndex = 64;
            ExitBTN.TabStop = false;
            ExitBTN.Click += ExitBTN_Click;
            // 
            // BorrowingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 588);
            Controls.Add(ExitBTN);
            Controls.Add(pictureBox3);
            Controls.Add(label6);
            Controls.Add(panel);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BorrowingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BORROWING";
            Load += BORROWING_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BorrowingImage).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExitBTN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label7;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private GroupBox groupBox1;
        private ComboBox CourseValue;
        private Label label4;
        private TextBox StudentIDValue;
        private TextBox LastNameValue;
        private Label label9;
        private Label label10;
        private PictureBox BorrowingImage;
        private Label label5;
        private TextBox FirstNameValue;
        private Button button3;
        private Button button2;
        private ComboBox EndTime;
        private Label BorrowingItemName;
        private Label label12;
        private TextBox EmailValue;
        private Label label11;
        private TextBox ContactNumberValue;
        private ComboBox SectionValue;
        private ComboBox YearValue;
        private Label label3;
        private Label label13;
        private Label BorrowingStock;
        private Label BorrowingDescription;
        private TextBox BorrowStockValue;
        private Panel panel;
        private Button button13;
        private PictureBox pictureBox6;
        private Button button4;
        private Button button8;
        private PictureBox pictureBox3;
        private Label label6;
        private PictureBox ExitBTN;
    }
}