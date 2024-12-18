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
            label7 = new Label();
            RegisterButton = new Button();
            ReturnButton = new Button();
            FirstNameValue = new TextBox();
            label9 = new Label();
            label10 = new Label();
            groupBox1 = new GroupBox();
            SectionValue = new ComboBox();
            YearValue = new ComboBox();
            CourseValue = new ComboBox();
            cysLabel = new Label();
            label2 = new Label();
            StudentIDValue = new TextBox();
            LastNameValue = new TextBox();
            label3 = new Label();
            PasswordValue = new TextBox();
            UsernameValue = new TextBox();
            label1 = new Label();
            label8 = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            pictureBox6 = new PictureBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            button1 = new Button();
            panel3 = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(32, 33, 35);
            label7.Location = new Point(19, 17);
            label7.Name = "label7";
            label7.Size = new Size(124, 15);
            label7.TabIndex = 44;
            label7.Text = "Personal Information";
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.FromArgb(32, 33, 35);
            RegisterButton.Cursor = Cursors.Hand;
            RegisterButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterButton.ForeColor = Color.White;
            RegisterButton.Location = new Point(291, 380);
            RegisterButton.Margin = new Padding(3, 2, 3, 2);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(108, 28);
            RegisterButton.TabIndex = 9;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
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
            ReturnButton.TabIndex = 43;
            ReturnButton.Text = "Back";
            ReturnButton.UseVisualStyleBackColor = false;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // FirstNameValue
            // 
            FirstNameValue.ForeColor = Color.DimGray;
            FirstNameValue.Location = new Point(30, 67);
            FirstNameValue.Margin = new Padding(3, 2, 3, 2);
            FirstNameValue.Name = "FirstNameValue";
            FirstNameValue.Size = new Size(189, 23);
            FirstNameValue.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(32, 33, 35);
            label9.Location = new Point(30, 43);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 35;
            label9.Text = "First Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(32, 33, 35);
            label10.Location = new Point(24, 28);
            label10.Name = "label10";
            label10.Size = new Size(128, 28);
            label10.TabIndex = 34;
            label10.Text = "Registration";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(SectionValue);
            groupBox1.Controls.Add(YearValue);
            groupBox1.Controls.Add(CourseValue);
            groupBox1.Controls.Add(cysLabel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(StudentIDValue);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(LastNameValue);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(FirstNameValue);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(24, 60);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(547, 164);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            // 
            // SectionValue
            // 
            SectionValue.FormattingEnabled = true;
            SectionValue.Items.AddRange(new object[] { "A", "B" });
            SectionValue.Location = new Point(158, 128);
            SectionValue.Margin = new Padding(3, 2, 3, 2);
            SectionValue.Name = "SectionValue";
            SectionValue.Size = new Size(61, 23);
            SectionValue.TabIndex = 5;
            SectionValue.Text = "Sec";
            SectionValue.SelectedIndexChanged += SectionValue_SelectedIndexChanged;
            // 
            // YearValue
            // 
            YearValue.FormattingEnabled = true;
            YearValue.Items.AddRange(new object[] { "1", "2", "3", "4" });
            YearValue.Location = new Point(104, 128);
            YearValue.Margin = new Padding(3, 2, 3, 2);
            YearValue.Name = "YearValue";
            YearValue.Size = new Size(49, 23);
            YearValue.TabIndex = 4;
            YearValue.Text = "Yr";
            YearValue.SelectedIndexChanged += YearValue_SelectedIndexChanged;
            // 
            // CourseValue
            // 
            CourseValue.FormattingEnabled = true;
            CourseValue.Items.AddRange(new object[] { "BSCS", "BSEMC", "BSIS", "BSIT" });
            CourseValue.Location = new Point(29, 128);
            CourseValue.Margin = new Padding(3, 2, 3, 2);
            CourseValue.Name = "CourseValue";
            CourseValue.Size = new Size(70, 23);
            CourseValue.TabIndex = 3;
            CourseValue.Text = "Course";
            CourseValue.SelectedIndexChanged += CourseValue_SelectedIndexChanged;
            // 
            // cysLabel
            // 
            cysLabel.AutoSize = true;
            cysLabel.Location = new Point(27, 111);
            cysLabel.Name = "cysLabel";
            cysLabel.Size = new Size(115, 15);
            cysLabel.TabIndex = 45;
            cysLabel.Text = "Course/Year/Section";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(32, 33, 35);
            label2.Location = new Point(246, 106);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 23;
            label2.Text = "Student ID";
            // 
            // StudentIDValue
            // 
            StudentIDValue.ForeColor = Color.DimGray;
            StudentIDValue.Location = new Point(246, 128);
            StudentIDValue.Margin = new Padding(3, 2, 3, 2);
            StudentIDValue.Name = "StudentIDValue";
            StudentIDValue.Size = new Size(178, 23);
            StudentIDValue.TabIndex = 6;
            // 
            // LastNameValue
            // 
            LastNameValue.ForeColor = Color.DimGray;
            LastNameValue.Location = new Point(246, 67);
            LastNameValue.Margin = new Padding(3, 2, 3, 2);
            LastNameValue.Name = "LastNameValue";
            LastNameValue.Size = new Size(178, 23);
            LastNameValue.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(32, 33, 35);
            label3.Location = new Point(246, 43);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 20;
            label3.Text = "Last Name";
            // 
            // PasswordValue
            // 
            PasswordValue.ForeColor = Color.DimGray;
            PasswordValue.Location = new Point(304, 74);
            PasswordValue.Margin = new Padding(3, 2, 3, 2);
            PasswordValue.Name = "PasswordValue";
            PasswordValue.Size = new Size(200, 23);
            PasswordValue.TabIndex = 8;
            PasswordValue.UseSystemPasswordChar = true;
            // 
            // UsernameValue
            // 
            UsernameValue.ForeColor = Color.DimGray;
            UsernameValue.Location = new Point(33, 74);
            UsernameValue.Margin = new Padding(3, 2, 3, 2);
            UsernameValue.Name = "UsernameValue";
            UsernameValue.Size = new Size(218, 23);
            UsernameValue.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(32, 33, 35);
            label1.Location = new Point(33, 48);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 37;
            label1.Text = "Username";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(32, 33, 35);
            label8.Location = new Point(19, 17);
            label8.Name = "label8";
            label8.Size = new Size(120, 15);
            label8.TabIndex = 45;
            label8.Text = "Sign Up Information";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(32, 33, 35);
            label6.Location = new Point(304, 48);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 26;
            label6.Text = "Password";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(pictureBox6);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(UsernameValue);
            groupBox2.Controls.Add(PasswordValue);
            groupBox2.Location = new Point(24, 229);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(547, 127);
            groupBox2.TabIndex = 47;
            groupBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(508, 74);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(22, 16);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 46;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(66, 358);
            label4.Name = "label4";
            label4.Size = new Size(154, 48);
            label4.TabIndex = 49;
            label4.Text = "University of Caloocan City\r\n-Congressional Campus\r\n\r\n@mis.ucc.com";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(71, 62);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(68, 185);
            label11.Name = "label11";
            label11.Size = new Size(151, 24);
            label11.TabIndex = 51;
            label11.Text = "Create an account for you\r\nto explore our system!\r\n";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DimGray;
            button1.Location = new Point(172, 380);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(105, 28);
            button1.TabIndex = 10;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(32, 33, 35);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label11);
            panel3.Location = new Point(598, -2);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(290, 448);
            panel3.TabIndex = 54;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(886, 441);
            Controls.Add(panel3);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(RegisterButton);
            Controls.Add(label10);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegistrationForm";
            Text = "REGISTRATION";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Button RegisterButton;
        private Button ReturnButton;
        private TextBox FirstNameValue;
        private Label label9;
        private Label label10;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox LastNameValue;
        private TextBox StudentIDValue;
        private Label label2;
        private TextBox PasswordValue;
        private TextBox UsernameValue;
        private Label label1;
        private Label label8;
        private Label label6;
        private GroupBox groupBox2;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label11;
        private Button button1;
        private Panel panel3;
        private Label cysLabel;
        private ComboBox SectionValue;
        private ComboBox YearValue;
        private ComboBox CourseValue;
        private PictureBox pictureBox6;
    }
}