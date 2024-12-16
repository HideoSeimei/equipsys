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
            piLabel = new Label();
            RegisterBTN = new Button();
            ReturnButton = new Button();
            cysLabel = new Label();
            FirstNameValue = new TextBox();
            fnLabel = new Label();
            registrationLabel = new Label();
            PersonalInfoGB = new GroupBox();
            CourseValue = new ComboBox();
            SectionValue = new ComboBox();
            sidLabel = new Label();
            YearValue = new ComboBox();
            StudentIDValue = new TextBox();
            LastNameValue = new TextBox();
            lnLabel = new Label();
            PasswordValue = new TextBox();
            UsernameValue = new TextBox();
            userLabel = new Label();
            suiLabel = new Label();
            passLabel = new Label();
            SignUpInfoGB = new GroupBox();
            infoLabel2 = new Label();
            registrationPB = new PictureBox();
            infoLabel1 = new Label();
            BackBTN = new Button();
            Panel = new Panel();
            PersonalInfoGB.SuspendLayout();
            SignUpInfoGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)registrationPB).BeginInit();
            Panel.SuspendLayout();
            SuspendLayout();
            // 
            // piLabel
            // 
            piLabel.AutoSize = true;
            piLabel.BackColor = Color.Transparent;
            piLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            piLabel.ForeColor = Color.FromArgb(32, 33, 35);
            piLabel.Location = new Point(19, 17);
            piLabel.Name = "piLabel";
            piLabel.Size = new Size(163, 21);
            piLabel.TabIndex = 44;
            piLabel.Text = "Personal Information";
            // 
            // RegisterBTN
            // 
            RegisterBTN.BackColor = Color.FromArgb(32, 33, 35);
            RegisterBTN.Cursor = Cursors.Hand;
            RegisterBTN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterBTN.ForeColor = Color.White;
            RegisterBTN.Location = new Point(291, 380);
            RegisterBTN.Margin = new Padding(3, 2, 3, 2);
            RegisterBTN.Name = "RegisterBTN";
            RegisterBTN.Size = new Size(100, 24);
            RegisterBTN.TabIndex = 8;
            RegisterBTN.Text = "Register";
            RegisterBTN.UseVisualStyleBackColor = false;
            RegisterBTN.Click += RegisterBTN_Click;
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(0, 0);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(75, 23);
            ReturnButton.TabIndex = 0;
            // 
            // cysLabel
            // 
            cysLabel.AutoSize = true;
            cysLabel.BackColor = Color.Transparent;
            cysLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cysLabel.ForeColor = Color.FromArgb(32, 33, 35);
            cysLabel.Location = new Point(30, 109);
            cysLabel.Name = "cysLabel";
            cysLabel.Size = new Size(126, 17);
            cysLabel.TabIndex = 39;
            cysLabel.Text = "Course/Year/Section";
            // 
            // FirstNameValue
            // 
            FirstNameValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameValue.ForeColor = Color.DimGray;
            FirstNameValue.Location = new Point(30, 67);
            FirstNameValue.Margin = new Padding(3, 2, 3, 2);
            FirstNameValue.Name = "FirstNameValue";
            FirstNameValue.Size = new Size(189, 23);
            FirstNameValue.TabIndex = 0;
            // 
            // fnLabel
            // 
            fnLabel.AutoSize = true;
            fnLabel.BackColor = Color.Transparent;
            fnLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            fnLabel.ForeColor = Color.FromArgb(32, 33, 35);
            fnLabel.Location = new Point(30, 48);
            fnLabel.Name = "fnLabel";
            fnLabel.Size = new Size(71, 17);
            fnLabel.TabIndex = 35;
            fnLabel.Text = "First Name";
            // 
            // registrationLabel
            // 
            registrationLabel.AutoSize = true;
            registrationLabel.BackColor = Color.Transparent;
            registrationLabel.FlatStyle = FlatStyle.Flat;
            registrationLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            registrationLabel.ForeColor = Color.FromArgb(32, 33, 35);
            registrationLabel.Location = new Point(24, 28);
            registrationLabel.Name = "registrationLabel";
            registrationLabel.Size = new Size(132, 30);
            registrationLabel.TabIndex = 34;
            registrationLabel.Text = "Registration";
            // 
            // PersonalInfoGB
            // 
            PersonalInfoGB.BackColor = Color.WhiteSmoke;
            PersonalInfoGB.Controls.Add(CourseValue);
            PersonalInfoGB.Controls.Add(SectionValue);
            PersonalInfoGB.Controls.Add(sidLabel);
            PersonalInfoGB.Controls.Add(YearValue);
            PersonalInfoGB.Controls.Add(StudentIDValue);
            PersonalInfoGB.Controls.Add(piLabel);
            PersonalInfoGB.Controls.Add(LastNameValue);
            PersonalInfoGB.Controls.Add(cysLabel);
            PersonalInfoGB.Controls.Add(lnLabel);
            PersonalInfoGB.Controls.Add(fnLabel);
            PersonalInfoGB.Controls.Add(FirstNameValue);
            PersonalInfoGB.ForeColor = SystemColors.ControlText;
            PersonalInfoGB.Location = new Point(24, 60);
            PersonalInfoGB.Margin = new Padding(3, 2, 3, 2);
            PersonalInfoGB.Name = "PersonalInfoGB";
            PersonalInfoGB.Padding = new Padding(3, 2, 3, 2);
            PersonalInfoGB.Size = new Size(547, 164);
            PersonalInfoGB.TabIndex = 46;
            PersonalInfoGB.TabStop = false;
            // 
            // CourseValue
            // 
            CourseValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CourseValue.ForeColor = Color.DimGray;
            CourseValue.FormattingEnabled = true;
            CourseValue.Items.AddRange(new object[] { "BSCS", "BSEMC", "BSIS", "BSIT" });
            CourseValue.Location = new Point(30, 128);
            CourseValue.Name = "CourseValue";
            CourseValue.Size = new Size(64, 23);
            CourseValue.TabIndex = 2;
            CourseValue.Text = "Course";
            CourseValue.SelectedIndexChanged += CourseValue_SelectedIndexChanged;
            // 
            // SectionValue
            // 
            SectionValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SectionValue.ForeColor = Color.DimGray;
            SectionValue.FormattingEnabled = true;
            SectionValue.Items.AddRange(new object[] { "A", "B" });
            SectionValue.Location = new Point(151, 128);
            SectionValue.Name = "SectionValue";
            SectionValue.Size = new Size(68, 23);
            SectionValue.TabIndex = 4;
            SectionValue.Text = "Section";
            SectionValue.SelectedIndexChanged += SectionValue_SelectedIndexChanged;
            // 
            // sidLabel
            // 
            sidLabel.AutoSize = true;
            sidLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            sidLabel.ForeColor = Color.FromArgb(32, 33, 35);
            sidLabel.Location = new Point(267, 109);
            sidLabel.Name = "sidLabel";
            sidLabel.Size = new Size(68, 17);
            sidLabel.TabIndex = 23;
            sidLabel.Text = "Student ID";
            // 
            // YearValue
            // 
            YearValue.AllowDrop = true;
            YearValue.BackColor = Color.White;
            YearValue.DropDownHeight = 75;
            YearValue.DropDownWidth = 75;
            YearValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            YearValue.ForeColor = Color.DimGray;
            YearValue.FormattingEnabled = true;
            YearValue.IntegralHeight = false;
            YearValue.Items.AddRange(new object[] { "1", "2", "3", "4" });
            YearValue.Location = new Point(100, 128);
            YearValue.Margin = new Padding(3, 2, 3, 2);
            YearValue.Name = "YearValue";
            YearValue.Size = new Size(45, 23);
            YearValue.TabIndex = 3;
            YearValue.Text = "Year";
            YearValue.SelectedIndexChanged += YearValue_SelectedIndexChanged;
            // 
            // StudentIDValue
            // 
            StudentIDValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            StudentIDValue.ForeColor = Color.DimGray;
            StudentIDValue.Location = new Point(267, 128);
            StudentIDValue.Margin = new Padding(3, 2, 3, 2);
            StudentIDValue.Name = "StudentIDValue";
            StudentIDValue.Size = new Size(178, 23);
            StudentIDValue.TabIndex = 5;
            // 
            // LastNameValue
            // 
            LastNameValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameValue.ForeColor = Color.DimGray;
            LastNameValue.Location = new Point(267, 67);
            LastNameValue.Margin = new Padding(3, 2, 3, 2);
            LastNameValue.Name = "LastNameValue";
            LastNameValue.Size = new Size(178, 23);
            LastNameValue.TabIndex = 1;
            // 
            // lnLabel
            // 
            lnLabel.AutoSize = true;
            lnLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lnLabel.ForeColor = Color.FromArgb(32, 33, 35);
            lnLabel.Location = new Point(267, 48);
            lnLabel.Name = "lnLabel";
            lnLabel.Size = new Size(70, 17);
            lnLabel.TabIndex = 20;
            lnLabel.Text = "Last Name";
            // 
            // PasswordValue
            // 
            PasswordValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordValue.ForeColor = Color.DimGray;
            PasswordValue.Location = new Point(267, 74);
            PasswordValue.Margin = new Padding(3, 2, 3, 2);
            PasswordValue.Name = "PasswordValue";
            PasswordValue.Size = new Size(178, 23);
            PasswordValue.TabIndex = 7;
            PasswordValue.UseSystemPasswordChar = true;
            // 
            // UsernameValue
            // 
            UsernameValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameValue.ForeColor = Color.DimGray;
            UsernameValue.Location = new Point(30, 74);
            UsernameValue.Margin = new Padding(3, 2, 3, 2);
            UsernameValue.Name = "UsernameValue";
            UsernameValue.Size = new Size(189, 23);
            UsernameValue.TabIndex = 6;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.BackColor = Color.Transparent;
            userLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            userLabel.ForeColor = Color.FromArgb(32, 33, 35);
            userLabel.Location = new Point(30, 55);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(67, 17);
            userLabel.TabIndex = 37;
            userLabel.Text = "Username";
            // 
            // suiLabel
            // 
            suiLabel.AutoSize = true;
            suiLabel.BackColor = Color.Transparent;
            suiLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            suiLabel.ForeColor = Color.FromArgb(32, 33, 35);
            suiLabel.Location = new Point(19, 18);
            suiLabel.Name = "suiLabel";
            suiLabel.Size = new Size(155, 21);
            suiLabel.TabIndex = 45;
            suiLabel.Text = "Sign Up Information";
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.BackColor = Color.Transparent;
            passLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            passLabel.ForeColor = Color.FromArgb(32, 33, 35);
            passLabel.Location = new Point(267, 55);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(64, 17);
            passLabel.TabIndex = 26;
            passLabel.Text = "Password";
            // 
            // SignUpInfoGB
            // 
            SignUpInfoGB.BackColor = Color.WhiteSmoke;
            SignUpInfoGB.Controls.Add(passLabel);
            SignUpInfoGB.Controls.Add(suiLabel);
            SignUpInfoGB.Controls.Add(userLabel);
            SignUpInfoGB.Controls.Add(UsernameValue);
            SignUpInfoGB.Controls.Add(PasswordValue);
            SignUpInfoGB.Location = new Point(24, 229);
            SignUpInfoGB.Margin = new Padding(3, 2, 3, 2);
            SignUpInfoGB.Name = "SignUpInfoGB";
            SignUpInfoGB.Padding = new Padding(3, 2, 3, 2);
            SignUpInfoGB.Size = new Size(547, 127);
            SignUpInfoGB.TabIndex = 47;
            SignUpInfoGB.TabStop = false;
            // 
            // infoLabel2
            // 
            infoLabel2.AutoSize = true;
            infoLabel2.BackColor = Color.Transparent;
            infoLabel2.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            infoLabel2.ForeColor = Color.White;
            infoLabel2.Location = new Point(66, 358);
            infoLabel2.Name = "infoLabel2";
            infoLabel2.Size = new Size(154, 48);
            infoLabel2.TabIndex = 49;
            infoLabel2.Text = "University of Caloocan City\r\n-Congressional Campus\r\n\r\n@mis.ucc.com";
            infoLabel2.TextAlign = ContentAlignment.TopCenter;
            // 
            // registrationPB
            // 
            registrationPB.BackColor = Color.Transparent;
            registrationPB.Image = (Image)resources.GetObject("registrationPB.Image");
            registrationPB.Location = new Point(71, 62);
            registrationPB.Margin = new Padding(3, 2, 3, 2);
            registrationPB.Name = "registrationPB";
            registrationPB.Size = new Size(145, 122);
            registrationPB.SizeMode = PictureBoxSizeMode.StretchImage;
            registrationPB.TabIndex = 50;
            registrationPB.TabStop = false;
            // 
            // infoLabel1
            // 
            infoLabel1.AutoSize = true;
            infoLabel1.BackColor = Color.Transparent;
            infoLabel1.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            infoLabel1.ForeColor = Color.White;
            infoLabel1.Location = new Point(68, 185);
            infoLabel1.Name = "infoLabel1";
            infoLabel1.Size = new Size(151, 24);
            infoLabel1.TabIndex = 51;
            infoLabel1.Text = "Create an account for you\r\nto explore our system!\r\n";
            infoLabel1.TextAlign = ContentAlignment.TopCenter;
            // 
            // BackBTN
            // 
            BackBTN.BackColor = Color.Transparent;
            BackBTN.Cursor = Cursors.Hand;
            BackBTN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BackBTN.ForeColor = Color.DimGray;
            BackBTN.Location = new Point(143, 380);
            BackBTN.Margin = new Padding(3, 2, 3, 2);
            BackBTN.Name = "BackBTN";
            BackBTN.Size = new Size(100, 24);
            BackBTN.TabIndex = 9;
            BackBTN.Text = "Back";
            BackBTN.UseVisualStyleBackColor = false;
            BackBTN.Click += BackBTN_Click;
            // 
            // Panel
            // 
            Panel.BackColor = Color.FromArgb(32, 33, 35);
            Panel.Controls.Add(registrationPB);
            Panel.Controls.Add(infoLabel2);
            Panel.Controls.Add(infoLabel1);
            Panel.Location = new Point(598, -2);
            Panel.Margin = new Padding(3, 2, 3, 2);
            Panel.Name = "Panel";
            Panel.Size = new Size(290, 448);
            Panel.TabIndex = 54;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(886, 441);
            Controls.Add(Panel);
            Controls.Add(BackBTN);
            Controls.Add(SignUpInfoGB);
            Controls.Add(RegisterBTN);
            Controls.Add(registrationLabel);
            Controls.Add(PersonalInfoGB);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegistrationForm";
            Text = "REGISTRATION";
            PersonalInfoGB.ResumeLayout(false);
            PersonalInfoGB.PerformLayout();
            SignUpInfoGB.ResumeLayout(false);
            SignUpInfoGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)registrationPB).EndInit();
            Panel.ResumeLayout(false);
            Panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label piLabel;
        private Button RegisterBTN;
        private Button ReturnButton;
        private Label cysLabel;
        private TextBox FirstNameValue;
        private Label fnLabel;
        private Label registrationLabel;
        private GroupBox PersonalInfoGB;
        private ComboBox YearValue;
        private Label lnLabel;
        private TextBox LastNameValue;
        private TextBox StudentIDValue;
        private Label sidLabel;
        private TextBox PasswordValue;
        private TextBox UsernameValue;
        private Label userLabel;
        private Label suiLabel;
        private Label passLabel;
        private GroupBox SignUpInfoGB;
        private Label infoLabel2;
        private PictureBox registrationPB;
        private Label infoLabel1;
        private Button BackBTN;
        private Panel Panel;
        private ComboBox SectionValue;
        private ComboBox CourseValue;
    }
}