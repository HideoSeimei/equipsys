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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            BorrowCount = new TextBox();
            comboBox7 = new ComboBox();
            button3 = new Button();
            label13 = new Label();
            button2 = new Button();
            EndTime = new ComboBox();
            SectionBox = new ComboBox();
            yearBox = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            label12 = new Label();
            EmailBox = new TextBox();
            label11 = new Label();
            contactBox = new TextBox();
            courseBox = new ComboBox();
            label4 = new Label();
            studentidReg = new TextBox();
            lastnameReg = new TextBox();
            label9 = new Label();
            label10 = new Label();
            firstnameReg = new TextBox();
            panel = new Panel();
            button13 = new Button();
            button8 = new Button();
            button4 = new Button();
            pictureBox6 = new PictureBox();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BorrowingImage).BeginInit();
            groupBox1.SuspendLayout();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(262, 89);
            guna2Panel1.Margin = new Padding(3, 4, 3, 4);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
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
            groupBox1.Controls.Add(BorrowCount);
            groupBox1.Controls.Add(comboBox7);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(EndTime);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(SectionBox);
            groupBox1.Controls.Add(yearBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(EmailBox);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(contactBox);
            groupBox1.Controls.Add(courseBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(studentidReg);
            groupBox1.Controls.Add(lastnameReg);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(firstnameReg);
            groupBox1.ForeColor = Color.ForestGreen;
            groupBox1.Location = new Point(216, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 454);
            groupBox1.TabIndex = 49;
            groupBox1.TabStop = false;
            // 
            // BorrowCount
            // 
            BorrowCount.Location = new Point(23, 355);
            BorrowCount.Name = "BorrowCount";
            BorrowCount.Size = new Size(74, 27);
            BorrowCount.TabIndex = 58;
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox7.Location = new Point(23, 317);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(71, 28);
            comboBox7.TabIndex = 57;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(32, 33, 35);
            button3.Location = new Point(242, 402);
            button3.Name = "button3";
            button3.Size = new Size(101, 29);
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
            button2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(354, 402);
            button2.Name = "button2";
            button2.Size = new Size(107, 29);
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
            EndTime.Size = new Size(52, 28);
            EndTime.TabIndex = 56;
            // 
            // SectionBox
            // 
            SectionBox.ForeColor = Color.FromArgb(32, 33, 35);
            SectionBox.FormattingEnabled = true;
            SectionBox.Items.AddRange(new object[] { "A", "B" });
            SectionBox.Location = new Point(185, 165);
            SectionBox.Name = "SectionBox";
            SectionBox.Size = new Size(63, 28);
            SectionBox.TabIndex = 55;
            SectionBox.Text = "Sec";
            // 
            // yearBox
            // 
            yearBox.ForeColor = Color.FromArgb(32, 33, 35);
            yearBox.FormattingEnabled = true;
            yearBox.Items.AddRange(new object[] { "1st", "2nd", "3rd", "4th" });
            yearBox.Location = new Point(112, 165);
            yearBox.Name = "yearBox";
            yearBox.Size = new Size(65, 28);
            yearBox.TabIndex = 54;
            yearBox.Text = "Yr";
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
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(32, 33, 35);
            label5.Location = new Point(267, 296);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
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
            // EmailBox
            // 
            EmailBox.ForeColor = Color.DimGray;
            EmailBox.Location = new Point(263, 239);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(199, 27);
            EmailBox.TabIndex = 51;
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
            // contactBox
            // 
            contactBox.ForeColor = Color.DimGray;
            contactBox.Location = new Point(23, 236);
            contactBox.Name = "contactBox";
            contactBox.Size = new Size(215, 27);
            contactBox.TabIndex = 49;
            // 
            // courseBox
            // 
            courseBox.ForeColor = Color.FromArgb(32, 33, 35);
            courseBox.FormattingEnabled = true;
            courseBox.Items.AddRange(new object[] { "BSCS", "BSIT", "BSIS", "BSEMC" });
            courseBox.Location = new Point(23, 165);
            courseBox.Name = "courseBox";
            courseBox.Size = new Size(83, 28);
            courseBox.TabIndex = 39;
            courseBox.Text = " Course";
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
            // studentidReg
            // 
            studentidReg.ForeColor = Color.DimGray;
            studentidReg.Location = new Point(263, 165);
            studentidReg.Name = "studentidReg";
            studentidReg.Size = new Size(199, 27);
            studentidReg.TabIndex = 22;
            // 
            // lastnameReg
            // 
            lastnameReg.ForeColor = Color.DimGray;
            lastnameReg.Location = new Point(263, 88);
            lastnameReg.Name = "lastnameReg";
            lastnameReg.Size = new Size(199, 27);
            lastnameReg.TabIndex = 21;
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
            // firstnameReg
            // 
            firstnameReg.ForeColor = Color.DimGray;
            firstnameReg.Location = new Point(23, 88);
            firstnameReg.Name = "firstnameReg";
            firstnameReg.Size = new Size(215, 27);
            firstnameReg.TabIndex = 36;
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
            // BorrowingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 588);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label7;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private GroupBox groupBox1;
        private ComboBox courseBox;
        private Label label4;
        private TextBox studentidReg;
        private TextBox lastnameReg;
        private Label label9;
        private Label label10;
        private PictureBox BorrowingImage;
        private Label label5;
        private TextBox firstnameReg;
        private Button button3;
        private Button button2;
        private ComboBox EndTime;
        private Label BorrowingItemName;
        private Label label12;
        private TextBox EmailBox;
        private Label label11;
        private TextBox contactBox;
        private ComboBox SectionBox;
        private ComboBox yearBox;
        private Label label3;
        private ComboBox comboBox7;
        private Label label13;
        private Label BorrowingStock;
        private Label BorrowingDescription;
        private TextBox BorrowCount;
        private Panel panel;
        private Button button13;
        private PictureBox pictureBox6;
        private Button button4;
        private Button button8;
        private PictureBox pictureBox3;
        private Label label6;
    }
}