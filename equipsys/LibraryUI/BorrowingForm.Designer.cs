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
            FormLabel = new Label();
            LogOutLabel = new Label();
            BorrowerInformationLabel = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ItemDescriptionLabel = new Label();
            ItemStockLabel = new Label();
            BackButton = new Button();
            BorrowButton = new Button();
            ItemNameLabel = new Label();
            ItemPictureBox = new PictureBox();
            BorrowerInformationGroupBox = new GroupBox();
            BorrowedStockLabel = new Label();
            SectionComboBox = new ComboBox();
            CYSLabel = new Label();
            EmailLabel = new Label();
            ItemStockComboBox = new ComboBox();
            EmailTextBox = new TextBox();
            ContactNumberLabel = new Label();
            ContactNumberTextBox = new TextBox();
            CourseComboBox = new ComboBox();
            StudentIDLabel = new Label();
            StudentIDTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            LastNameLabel = new Label();
            YearComboBox = new ComboBox();
            FirstNameLabel = new Label();
            FirstNameTextBox = new TextBox();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemPictureBox).BeginInit();
            BorrowerInformationGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // FormLabel
            // 
            FormLabel.AutoSize = true;
            FormLabel.BackColor = Color.Transparent;
            FormLabel.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormLabel.ForeColor = Color.ForestGreen;
            FormLabel.Location = new Point(186, 31);
            FormLabel.Name = "FormLabel";
            FormLabel.Size = new Size(178, 26);
            FormLabel.TabIndex = 36;
            FormLabel.Text = "Borrowing Item";
            // 
            // LogOutLabel
            // 
            LogOutLabel.AutoSize = true;
            LogOutLabel.BackColor = Color.Transparent;
            LogOutLabel.Cursor = Cursors.Hand;
            LogOutLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LogOutLabel.ForeColor = Color.White;
            LogOutLabel.Location = new Point(40, 418);
            LogOutLabel.Name = "LogOutLabel";
            LogOutLabel.Size = new Size(50, 14);
            LogOutLabel.TabIndex = 35;
            LogOutLabel.Text = "Log out";
            // 
            // BorrowerInformationLabel
            // 
            BorrowerInformationLabel.AutoSize = true;
            BorrowerInformationLabel.BackColor = Color.Transparent;
            BorrowerInformationLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BorrowerInformationLabel.ForeColor = Color.ForestGreen;
            BorrowerInformationLabel.Location = new Point(0, 0);
            BorrowerInformationLabel.Name = "BorrowerInformationLabel";
            BorrowerInformationLabel.Size = new Size(139, 15);
            BorrowerInformationLabel.TabIndex = 48;
            BorrowerInformationLabel.Text = "Borrower's Information";
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(ItemDescriptionLabel);
            guna2Panel1.Controls.Add(ItemStockLabel);
            guna2Panel1.Controls.Add(BackButton);
            guna2Panel1.Controls.Add(BorrowButton);
            guna2Panel1.Controls.Add(ItemNameLabel);
            guna2Panel1.Controls.Add(ItemPictureBox);
            guna2Panel1.Controls.Add(BorrowerInformationGroupBox);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(186, 76);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(659, 334);
            guna2Panel1.TabIndex = 37;
            // 
            // ItemDescriptionLabel
            // 
            ItemDescriptionLabel.AutoSize = true;
            ItemDescriptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ItemDescriptionLabel.ForeColor = Color.ForestGreen;
            ItemDescriptionLabel.Location = new Point(16, 196);
            ItemDescriptionLabel.Name = "ItemDescriptionLabel";
            ItemDescriptionLabel.Size = new Size(85, 15);
            ItemDescriptionLabel.TabIndex = 58;
            ItemDescriptionLabel.Text = "Description: {}";
            // 
            // ItemStockLabel
            // 
            ItemStockLabel.AutoSize = true;
            ItemStockLabel.BackColor = Color.Transparent;
            ItemStockLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ItemStockLabel.ForeColor = Color.ForestGreen;
            ItemStockLabel.Location = new Point(16, 181);
            ItemStockLabel.Name = "ItemStockLabel";
            ItemStockLabel.Size = new Size(53, 15);
            ItemStockLabel.TabIndex = 56;
            ItemStockLabel.Text = "Stock: {}";
            // 
            // BackButton
            // 
            BackButton.Cursor = Cursors.Hand;
            BackButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.ForeColor = Color.ForestGreen;
            BackButton.Location = new Point(415, 304);
            BackButton.Margin = new Padding(3, 2, 3, 2);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(109, 22);
            BackButton.TabIndex = 9;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // BorrowButton
            // 
            BorrowButton.BackColor = Color.ForestGreen;
            BorrowButton.Cursor = Cursors.Hand;
            BorrowButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BorrowButton.ForeColor = Color.White;
            BorrowButton.Location = new Point(535, 304);
            BorrowButton.Margin = new Padding(3, 2, 3, 2);
            BorrowButton.Name = "BorrowButton";
            BorrowButton.Size = new Size(109, 22);
            BorrowButton.TabIndex = 10;
            BorrowButton.Text = "Borrow";
            BorrowButton.UseVisualStyleBackColor = false;
            BorrowButton.Click += BorrowButton_Click;
            // 
            // ItemNameLabel
            // 
            ItemNameLabel.AutoSize = true;
            ItemNameLabel.BackColor = Color.Transparent;
            ItemNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ItemNameLabel.ForeColor = Color.ForestGreen;
            ItemNameLabel.Location = new Point(16, 166);
            ItemNameLabel.Name = "ItemNameLabel";
            ItemNameLabel.Size = new Size(84, 15);
            ItemNameLabel.TabIndex = 49;
            ItemNameLabel.Text = "Item Name: {}";
            // 
            // ItemPictureBox
            // 
            ItemPictureBox.Image = (Image)resources.GetObject("ItemPictureBox.Image");
            ItemPictureBox.Location = new Point(15, 9);
            ItemPictureBox.Margin = new Padding(3, 2, 3, 2);
            ItemPictureBox.Name = "ItemPictureBox";
            ItemPictureBox.Size = new Size(169, 149);
            ItemPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ItemPictureBox.TabIndex = 50;
            ItemPictureBox.TabStop = false;
            // 
            // BorrowerInformationGroupBox
            // 
            BorrowerInformationGroupBox.BackColor = Color.WhiteSmoke;
            BorrowerInformationGroupBox.Controls.Add(BorrowedStockLabel);
            BorrowerInformationGroupBox.Controls.Add(SectionComboBox);
            BorrowerInformationGroupBox.Controls.Add(CYSLabel);
            BorrowerInformationGroupBox.Controls.Add(EmailLabel);
            BorrowerInformationGroupBox.Controls.Add(ItemStockComboBox);
            BorrowerInformationGroupBox.Controls.Add(EmailTextBox);
            BorrowerInformationGroupBox.Controls.Add(ContactNumberLabel);
            BorrowerInformationGroupBox.Controls.Add(ContactNumberTextBox);
            BorrowerInformationGroupBox.Controls.Add(BorrowerInformationLabel);
            BorrowerInformationGroupBox.Controls.Add(CourseComboBox);
            BorrowerInformationGroupBox.Controls.Add(StudentIDLabel);
            BorrowerInformationGroupBox.Controls.Add(StudentIDTextBox);
            BorrowerInformationGroupBox.Controls.Add(LastNameTextBox);
            BorrowerInformationGroupBox.Controls.Add(LastNameLabel);
            BorrowerInformationGroupBox.Controls.Add(YearComboBox);
            BorrowerInformationGroupBox.Controls.Add(FirstNameLabel);
            BorrowerInformationGroupBox.Controls.Add(FirstNameTextBox);
            BorrowerInformationGroupBox.ForeColor = SystemColors.ControlText;
            BorrowerInformationGroupBox.Location = new Point(202, 9);
            BorrowerInformationGroupBox.Margin = new Padding(3, 2, 3, 2);
            BorrowerInformationGroupBox.Name = "BorrowerInformationGroupBox";
            BorrowerInformationGroupBox.Padding = new Padding(3, 2, 3, 2);
            BorrowerInformationGroupBox.Size = new Size(442, 283);
            BorrowerInformationGroupBox.TabIndex = 49;
            BorrowerInformationGroupBox.TabStop = false;
            // 
            // BorrowedStockLabel
            // 
            BorrowedStockLabel.AutoSize = true;
            BorrowedStockLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BorrowedStockLabel.ForeColor = Color.ForestGreen;
            BorrowedStockLabel.Location = new Point(6, 234);
            BorrowedStockLabel.Name = "BorrowedStockLabel";
            BorrowedStockLabel.Size = new Size(63, 15);
            BorrowedStockLabel.TabIndex = 54;
            BorrowedStockLabel.Text = "To Borrow:";
            // 
            // SectionComboBox
            // 
            SectionComboBox.AllowDrop = true;
            SectionComboBox.BackColor = Color.White;
            SectionComboBox.DropDownHeight = 75;
            SectionComboBox.DropDownWidth = 75;
            SectionComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SectionComboBox.ForeColor = Color.DimGray;
            SectionComboBox.FormattingEnabled = true;
            SectionComboBox.IntegralHeight = false;
            SectionComboBox.Items.AddRange(new object[] { "A", "B" });
            SectionComboBox.Location = new Point(126, 120);
            SectionComboBox.Margin = new Padding(3, 2, 3, 2);
            SectionComboBox.Name = "SectionComboBox";
            SectionComboBox.Size = new Size(41, 23);
            SectionComboBox.TabIndex = 4;
            SectionComboBox.Text = "Sec";
            SectionComboBox.SelectedIndexChanged += SectionComboBox_SelectedIndexChanged;
            // 
            // CYSLabel
            // 
            CYSLabel.AutoSize = true;
            CYSLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CYSLabel.ForeColor = Color.ForestGreen;
            CYSLabel.Location = new Point(6, 103);
            CYSLabel.Name = "CYSLabel";
            CYSLabel.Size = new Size(82, 15);
            CYSLabel.TabIndex = 53;
            CYSLabel.Text = "Course/Yr/Sec";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel.ForeColor = Color.ForestGreen;
            EmailLabel.Location = new Point(213, 172);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(36, 15);
            EmailLabel.TabIndex = 52;
            EmailLabel.Text = "Email";
            // 
            // ItemStockComboBox
            // 
            ItemStockComboBox.ForeColor = Color.ForestGreen;
            ItemStockComboBox.FormattingEnabled = true;
            ItemStockComboBox.Location = new Point(6, 251);
            ItemStockComboBox.Margin = new Padding(3, 2, 3, 2);
            ItemStockComboBox.Name = "ItemStockComboBox";
            ItemStockComboBox.Size = new Size(64, 23);
            ItemStockComboBox.TabIndex = 8;
            ItemStockComboBox.Text = "1";
            // 
            // EmailTextBox
            // 
            EmailTextBox.ForeColor = Color.DimGray;
            EmailTextBox.Location = new Point(212, 189);
            EmailTextBox.Margin = new Padding(3, 2, 3, 2);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(162, 23);
            EmailTextBox.TabIndex = 7;
            // 
            // ContactNumberLabel
            // 
            ContactNumberLabel.AutoSize = true;
            ContactNumberLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ContactNumberLabel.ForeColor = Color.ForestGreen;
            ContactNumberLabel.Location = new Point(6, 172);
            ContactNumberLabel.Name = "ContactNumberLabel";
            ContactNumberLabel.Size = new Size(96, 15);
            ContactNumberLabel.TabIndex = 50;
            ContactNumberLabel.Text = "Contact Number";
            // 
            // ContactNumberTextBox
            // 
            ContactNumberTextBox.ForeColor = Color.DimGray;
            ContactNumberTextBox.Location = new Point(6, 189);
            ContactNumberTextBox.Margin = new Padding(3, 2, 3, 2);
            ContactNumberTextBox.Name = "ContactNumberTextBox";
            ContactNumberTextBox.Size = new Size(161, 23);
            ContactNumberTextBox.TabIndex = 6;
            // 
            // CourseComboBox
            // 
            CourseComboBox.DisplayMember = "Course";
            CourseComboBox.ForeColor = Color.DimGray;
            CourseComboBox.FormattingEnabled = true;
            CourseComboBox.Items.AddRange(new object[] { "BSCS", "BSEMC", "BSIS", "BSIT" });
            CourseComboBox.Location = new Point(6, 120);
            CourseComboBox.Margin = new Padding(3, 2, 3, 2);
            CourseComboBox.Name = "CourseComboBox";
            CourseComboBox.Size = new Size(64, 23);
            CourseComboBox.TabIndex = 2;
            CourseComboBox.Text = "Course";
            CourseComboBox.ValueMember = "Course";
            CourseComboBox.SelectedIndexChanged += CourseComboBox_SelectedIndexChanged;
            // 
            // StudentIDLabel
            // 
            StudentIDLabel.AutoSize = true;
            StudentIDLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            StudentIDLabel.ForeColor = Color.ForestGreen;
            StudentIDLabel.Location = new Point(213, 103);
            StudentIDLabel.Name = "StudentIDLabel";
            StudentIDLabel.Size = new Size(62, 15);
            StudentIDLabel.TabIndex = 23;
            StudentIDLabel.Text = "Student ID";
            // 
            // StudentIDTextBox
            // 
            StudentIDTextBox.ForeColor = Color.DimGray;
            StudentIDTextBox.Location = new Point(213, 120);
            StudentIDTextBox.Margin = new Padding(3, 2, 3, 2);
            StudentIDTextBox.Name = "StudentIDTextBox";
            StudentIDTextBox.Size = new Size(161, 23);
            StudentIDTextBox.TabIndex = 5;
            StudentIDTextBox.TextChanged += StudentIDTextBox_TextChanged;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.ForeColor = Color.DimGray;
            LastNameTextBox.Location = new Point(213, 45);
            LastNameTextBox.Margin = new Padding(3, 2, 3, 2);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(161, 23);
            LastNameTextBox.TabIndex = 1;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameLabel.ForeColor = Color.ForestGreen;
            LastNameLabel.Location = new Point(213, 28);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(63, 15);
            LastNameLabel.TabIndex = 20;
            LastNameLabel.Text = "Last Name";
            // 
            // YearComboBox
            // 
            YearComboBox.AllowDrop = true;
            YearComboBox.BackColor = Color.White;
            YearComboBox.DropDownHeight = 75;
            YearComboBox.DropDownWidth = 75;
            YearComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            YearComboBox.ForeColor = Color.DimGray;
            YearComboBox.FormattingEnabled = true;
            YearComboBox.IntegralHeight = false;
            YearComboBox.Items.AddRange(new object[] { "1", "2", "3", "4" });
            YearComboBox.Location = new Point(76, 120);
            YearComboBox.Margin = new Padding(3, 2, 3, 2);
            YearComboBox.Name = "YearComboBox";
            YearComboBox.Size = new Size(44, 23);
            YearComboBox.TabIndex = 3;
            YearComboBox.Text = "Yr";
            YearComboBox.SelectedIndexChanged += YearComboBox_SelectedIndexChanged;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.BackColor = Color.Transparent;
            FirstNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameLabel.ForeColor = Color.ForestGreen;
            FirstNameLabel.Location = new Point(6, 28);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(64, 15);
            FirstNameLabel.TabIndex = 35;
            FirstNameLabel.Text = "First Name";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.ForeColor = Color.DimGray;
            FirstNameTextBox.Location = new Point(6, 45);
            FirstNameTextBox.Margin = new Padding(3, 2, 3, 2);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(161, 23);
            FirstNameTextBox.TabIndex = 0;
            // 
            // BorrowingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(886, 441);
            Controls.Add(FormLabel);
            Controls.Add(LogOutLabel);
            Controls.Add(guna2Panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BorrowingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Borrower's Sheet";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ItemPictureBox).EndInit();
            BorrowerInformationGroupBox.ResumeLayout(false);
            BorrowerInformationGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FormLabel;
        private Label LogOutLabel;
        private Label BorrowerInformationLabel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private GroupBox BorrowerInformationGroupBox;
        private ComboBox CourseComboBox;
        private Label StudentIDLabel;
        private ComboBox YearComboBox;
        private TextBox StudentIDTextBox;
        private TextBox LastNameTextBox;
        private Label LastNameLabel;
        private Label FirstNameLabel;
        private PictureBox ItemPictureBox;
        private ComboBox ItemStockComboBox;
        private TextBox FirstNameTextBox;
        private Button BackButton;
        private Button BorrowButton;
        private Label ItemNameLabel;
        private Label EmailLabel;
        private TextBox EmailTextBox;
        private Label ContactNumberLabel;
        private TextBox ContactNumberTextBox;
        private ComboBox SectionComboBox;
        private Label CYSLabel;
        private Label ItemStockLabel;
        private Label ItemDescriptionLabel;
        private Label BorrowedStockLabel;
    }
}