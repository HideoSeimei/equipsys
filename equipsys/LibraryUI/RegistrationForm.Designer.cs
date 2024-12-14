namespace equipsys
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            PersonalInformationLabel = new Label();
            ReturnButton = new Button();
            RegisterButton = new Button();
            CYSLabel = new Label();
            FirstNameTextBox = new TextBox();
            FirstNameLabel = new Label();
            RegistrationLabel = new Label();
            PersonalInformationGroupBox = new GroupBox();
            SectionComboBox = new ComboBox();
            CourseComboBox = new ComboBox();
            YearComboBox = new ComboBox();
            StudentIDLabel = new Label();
            StudentIDTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            LastNameLabel = new Label();
            PasswordTextBox = new TextBox();
            UsernameTextBox = new TextBox();
            UsernameLabel = new Label();
            SignUpInformationLabel = new Label();
            PasswordLabel = new Label();
            SignUpInformationGroupBox = new GroupBox();
            Info2Label = new Label();
            IconPictureBox = new PictureBox();
            Info1Label = new Label();
            PersonalInformationGroupBox.SuspendLayout();
            SignUpInformationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IconPictureBox).BeginInit();
            SuspendLayout();
            // 
            // PersonalInformationLabel
            // 
            PersonalInformationLabel.AutoSize = true;
            PersonalInformationLabel.BackColor = Color.Transparent;
            PersonalInformationLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PersonalInformationLabel.ForeColor = Color.ForestGreen;
            PersonalInformationLabel.Location = new Point(24, 74);
            PersonalInformationLabel.Name = "PersonalInformationLabel";
            PersonalInformationLabel.Size = new Size(124, 15);
            PersonalInformationLabel.TabIndex = 44;
            PersonalInformationLabel.Text = "Personal Information";
            // 
            // ReturnButton
            // 
            ReturnButton.BackColor = Color.Transparent;
            ReturnButton.Cursor = Cursors.Hand;
            ReturnButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ReturnButton.ForeColor = Color.ForestGreen;
            ReturnButton.Location = new Point(130, 375);
            ReturnButton.Margin = new Padding(3, 2, 3, 2);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(131, 36);
            ReturnButton.TabIndex = 9;
            ReturnButton.Text = "Back";
            ReturnButton.UseVisualStyleBackColor = false;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.ForestGreen;
            RegisterButton.Cursor = Cursors.Hand;
            RegisterButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterButton.ForeColor = Color.White;
            RegisterButton.Location = new Point(313, 375);
            RegisterButton.Margin = new Padding(3, 2, 3, 2);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(131, 36);
            RegisterButton.TabIndex = 8;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // CYSLabel
            // 
            CYSLabel.AutoSize = true;
            CYSLabel.BackColor = Color.Transparent;
            CYSLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CYSLabel.ForeColor = Color.ForestGreen;
            CYSLabel.Location = new Point(29, 111);
            CYSLabel.Name = "CYSLabel";
            CYSLabel.Size = new Size(82, 15);
            CYSLabel.TabIndex = 39;
            CYSLabel.Text = "Course/Yr/Sec";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.ForeColor = Color.DimGray;
            FirstNameTextBox.Location = new Point(29, 67);
            FirstNameTextBox.Margin = new Padding(3, 2, 3, 2);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(178, 23);
            FirstNameTextBox.TabIndex = 0;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.BackColor = Color.Transparent;
            FirstNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameLabel.ForeColor = Color.ForestGreen;
            FirstNameLabel.Location = new Point(29, 50);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(64, 15);
            FirstNameLabel.TabIndex = 35;
            FirstNameLabel.Text = "First Name";
            // 
            // RegistrationLabel
            // 
            RegistrationLabel.AutoSize = true;
            RegistrationLabel.BackColor = Color.Transparent;
            RegistrationLabel.FlatStyle = FlatStyle.Flat;
            RegistrationLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RegistrationLabel.ForeColor = Color.ForestGreen;
            RegistrationLabel.Location = new Point(10, 22);
            RegistrationLabel.Name = "RegistrationLabel";
            RegistrationLabel.Size = new Size(103, 21);
            RegistrationLabel.TabIndex = 34;
            RegistrationLabel.Text = "Registration";
            // 
            // PersonalInformationGroupBox
            // 
            PersonalInformationGroupBox.BackColor = Color.WhiteSmoke;
            PersonalInformationGroupBox.Controls.Add(SectionComboBox);
            PersonalInformationGroupBox.Controls.Add(CourseComboBox);
            PersonalInformationGroupBox.Controls.Add(YearComboBox);
            PersonalInformationGroupBox.Controls.Add(StudentIDLabel);
            PersonalInformationGroupBox.Controls.Add(StudentIDTextBox);
            PersonalInformationGroupBox.Controls.Add(LastNameTextBox);
            PersonalInformationGroupBox.Controls.Add(CYSLabel);
            PersonalInformationGroupBox.Controls.Add(LastNameLabel);
            PersonalInformationGroupBox.Controls.Add(FirstNameLabel);
            PersonalInformationGroupBox.Controls.Add(FirstNameTextBox);
            PersonalInformationGroupBox.ForeColor = SystemColors.ControlText;
            PersonalInformationGroupBox.Location = new Point(10, 60);
            PersonalInformationGroupBox.Margin = new Padding(3, 2, 3, 2);
            PersonalInformationGroupBox.Name = "PersonalInformationGroupBox";
            PersonalInformationGroupBox.Padding = new Padding(3, 2, 3, 2);
            PersonalInformationGroupBox.Size = new Size(561, 164);
            PersonalInformationGroupBox.TabIndex = 46;
            PersonalInformationGroupBox.TabStop = false;
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
            SectionComboBox.Location = new Point(149, 128);
            SectionComboBox.Margin = new Padding(3, 2, 3, 2);
            SectionComboBox.Name = "SectionComboBox";
            SectionComboBox.Size = new Size(41, 23);
            SectionComboBox.TabIndex = 4;
            SectionComboBox.Text = "Sec";
            SectionComboBox.SelectedIndexChanged += SectionComboBox_SelectedIndexChanged;
            // 
            // CourseComboBox
            // 
            CourseComboBox.DisplayMember = "Course";
            CourseComboBox.ForeColor = Color.DimGray;
            CourseComboBox.FormattingEnabled = true;
            CourseComboBox.Items.AddRange(new object[] { "BSCS", "BSEMC", "BSIS", "BSIT" });
            CourseComboBox.Location = new Point(29, 128);
            CourseComboBox.Margin = new Padding(3, 2, 3, 2);
            CourseComboBox.Name = "CourseComboBox";
            CourseComboBox.Size = new Size(64, 23);
            CourseComboBox.TabIndex = 2;
            CourseComboBox.Text = "Course";
            CourseComboBox.ValueMember = "Course";
            CourseComboBox.SelectedIndexChanged += CourseComboBox_SelectedIndexChanged;
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
            YearComboBox.Location = new Point(99, 128);
            YearComboBox.Margin = new Padding(3, 2, 3, 2);
            YearComboBox.Name = "YearComboBox";
            YearComboBox.Size = new Size(44, 23);
            YearComboBox.TabIndex = 3;
            YearComboBox.Text = "Yr";
            YearComboBox.SelectedIndexChanged += YearComboBox_SelectedIndexChanged;
            // 
            // StudentIDLabel
            // 
            StudentIDLabel.AutoSize = true;
            StudentIDLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            StudentIDLabel.ForeColor = Color.ForestGreen;
            StudentIDLabel.Location = new Point(308, 111);
            StudentIDLabel.Name = "StudentIDLabel";
            StudentIDLabel.Size = new Size(62, 15);
            StudentIDLabel.TabIndex = 23;
            StudentIDLabel.Text = "Student ID";
            // 
            // StudentIDTextBox
            // 
            StudentIDTextBox.ForeColor = Color.DimGray;
            StudentIDTextBox.Location = new Point(308, 128);
            StudentIDTextBox.Margin = new Padding(3, 2, 3, 2);
            StudentIDTextBox.Name = "StudentIDTextBox";
            StudentIDTextBox.Size = new Size(178, 23);
            StudentIDTextBox.TabIndex = 5;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.ForeColor = Color.DimGray;
            LastNameTextBox.Location = new Point(308, 67);
            LastNameTextBox.Margin = new Padding(3, 2, 3, 2);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(178, 23);
            LastNameTextBox.TabIndex = 1;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameLabel.ForeColor = Color.ForestGreen;
            LastNameLabel.Location = new Point(308, 50);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(63, 15);
            LastNameLabel.TabIndex = 20;
            LastNameLabel.Text = "Last Name";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.ForeColor = Color.DimGray;
            PasswordTextBox.Location = new Point(304, 74);
            PasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(200, 23);
            PasswordTextBox.TabIndex = 7;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.ForeColor = Color.DimGray;
            UsernameTextBox.Location = new Point(34, 74);
            UsernameTextBox.Margin = new Padding(3, 2, 3, 2);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(174, 23);
            UsernameTextBox.TabIndex = 6;
            UsernameTextBox.TextChanged += UsernameTextBox_TextChanged;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.BackColor = Color.Transparent;
            UsernameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameLabel.ForeColor = Color.ForestGreen;
            UsernameLabel.Location = new Point(33, 57);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(60, 15);
            UsernameLabel.TabIndex = 37;
            UsernameLabel.Text = "Username";
            // 
            // SignUpInformationLabel
            // 
            SignUpInformationLabel.AutoSize = true;
            SignUpInformationLabel.BackColor = Color.Transparent;
            SignUpInformationLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SignUpInformationLabel.ForeColor = Color.ForestGreen;
            SignUpInformationLabel.Location = new Point(14, 18);
            SignUpInformationLabel.Name = "SignUpInformationLabel";
            SignUpInformationLabel.Size = new Size(120, 15);
            SignUpInformationLabel.TabIndex = 45;
            SignUpInformationLabel.Text = "Sign Up Information";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.ForeColor = Color.ForestGreen;
            PasswordLabel.Location = new Point(304, 57);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(57, 15);
            PasswordLabel.TabIndex = 26;
            PasswordLabel.Text = "Password";
            // 
            // SignUpInformationGroupBox
            // 
            SignUpInformationGroupBox.BackColor = Color.WhiteSmoke;
            SignUpInformationGroupBox.Controls.Add(PasswordLabel);
            SignUpInformationGroupBox.Controls.Add(SignUpInformationLabel);
            SignUpInformationGroupBox.Controls.Add(UsernameLabel);
            SignUpInformationGroupBox.Controls.Add(UsernameTextBox);
            SignUpInformationGroupBox.Controls.Add(PasswordTextBox);
            SignUpInformationGroupBox.Location = new Point(10, 238);
            SignUpInformationGroupBox.Margin = new Padding(3, 2, 3, 2);
            SignUpInformationGroupBox.Name = "SignUpInformationGroupBox";
            SignUpInformationGroupBox.Padding = new Padding(3, 2, 3, 2);
            SignUpInformationGroupBox.Size = new Size(561, 118);
            SignUpInformationGroupBox.TabIndex = 47;
            SignUpInformationGroupBox.TabStop = false;
            // 
            // Info2Label
            // 
            Info2Label.AutoSize = true;
            Info2Label.BackColor = Color.Transparent;
            Info2Label.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Info2Label.ForeColor = Color.White;
            Info2Label.Location = new Point(714, 356);
            Info2Label.Name = "Info2Label";
            Info2Label.Size = new Size(154, 48);
            Info2Label.TabIndex = 49;
            Info2Label.Text = "University of Caloocan City\r\n-Congressional Campus\r\n\r\n@mis.ucc.com";
            Info2Label.TextAlign = ContentAlignment.TopCenter;
            // 
            // IconPictureBox
            // 
            IconPictureBox.BackColor = Color.Transparent;
            IconPictureBox.Image = (Image)resources.GetObject("IconPictureBox.Image");
            IconPictureBox.Location = new Point(718, 59);
            IconPictureBox.Margin = new Padding(3, 2, 3, 2);
            IconPictureBox.Name = "IconPictureBox";
            IconPictureBox.Size = new Size(145, 122);
            IconPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            IconPictureBox.TabIndex = 50;
            IconPictureBox.TabStop = false;
            // 
            // Info1Label
            // 
            Info1Label.AutoSize = true;
            Info1Label.BackColor = Color.Transparent;
            Info1Label.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Info1Label.ForeColor = Color.White;
            Info1Label.Location = new Point(716, 183);
            Info1Label.Name = "Info1Label";
            Info1Label.Size = new Size(151, 24);
            Info1Label.TabIndex = 51;
            Info1Label.Text = "Create an account for you\r\nto explore our system!\r\n";
            Info1Label.TextAlign = ContentAlignment.TopCenter;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(886, 441);
            Controls.Add(Info1Label);
            Controls.Add(IconPictureBox);
            Controls.Add(Info2Label);
            Controls.Add(SignUpInformationGroupBox);
            Controls.Add(PersonalInformationLabel);
            Controls.Add(ReturnButton);
            Controls.Add(RegisterButton);
            Controls.Add(RegistrationLabel);
            Controls.Add(PersonalInformationGroupBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegistrationForm";
            Text = "Registration Sheet";
            PersonalInformationGroupBox.ResumeLayout(false);
            PersonalInformationGroupBox.PerformLayout();
            SignUpInformationGroupBox.ResumeLayout(false);
            SignUpInformationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IconPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label PersonalInformationLabel;
        private Button ReturnButton;
        private Button RegisterButton;
        private Label CYSLabel;
        private TextBox FirstNameTextBox;
        private Label FirstNameLabel;
        private Label RegistrationLabel;
        private GroupBox PersonalInformationGroupBox;
        private Label LastNameLabel;
        private TextBox LastNameTextBox;
        private TextBox StudentIDTextBox;
        private Label StudentIDLabel;
        private TextBox PasswordTextBox;
        private TextBox UsernameTextBox;
        private Label UsernameLabel;
        private Label SignUpInformationLabel;
        private Label PasswordLabel;
        private GroupBox SignUpInformationGroupBox;
        private Label Info2Label;
        private PictureBox IconPictureBox;
        private Label Info1Label;
        private ComboBox SectionComboBox;
        private ComboBox CourseComboBox;
        private ComboBox YearComboBox;
    }
}