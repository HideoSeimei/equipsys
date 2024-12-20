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
            label5 = new Label();
            ConfirmPasswordValue = new TextBox();
            pictureBox6 = new PictureBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            button1 = new Button();
            panel3 = new Panel();
            ExitBTN = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExitBTN).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(32, 33, 35);
            label7.Location = new Point(22, 23);
            label7.Name = "label7";
            label7.Size = new Size(158, 20);
            label7.TabIndex = 44;
            label7.Text = "Personal Information";
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.FromArgb(32, 33, 35);
            RegisterButton.Cursor = Cursors.Hand;
            RegisterButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterButton.ForeColor = Color.White;
            RegisterButton.Location = new Point(333, 507);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(123, 37);
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
            FirstNameValue.Location = new Point(34, 89);
            FirstNameValue.Name = "FirstNameValue";
            FirstNameValue.Size = new Size(215, 27);
            FirstNameValue.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(32, 33, 35);
            label9.Location = new Point(34, 57);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
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
            label10.Location = new Point(27, 37);
            label10.Name = "label10";
            label10.Size = new Size(157, 35);
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
            groupBox1.Location = new Point(27, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(625, 219);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            // 
            // SectionValue
            // 
            SectionValue.FormattingEnabled = true;
            SectionValue.Items.AddRange(new object[] { "A", "B" });
            SectionValue.Location = new Point(181, 171);
            SectionValue.Name = "SectionValue";
            SectionValue.Size = new Size(69, 28);
            SectionValue.TabIndex = 5;
            SectionValue.Text = "Sec";
            SectionValue.SelectedIndexChanged += SectionValue_SelectedIndexChanged;
            // 
            // YearValue
            // 
            YearValue.FormattingEnabled = true;
            YearValue.Items.AddRange(new object[] { "1", "2", "3", "4" });
            YearValue.Location = new Point(119, 171);
            YearValue.Name = "YearValue";
            YearValue.Size = new Size(55, 28);
            YearValue.TabIndex = 4;
            YearValue.Text = "Yr";
            YearValue.SelectedIndexChanged += YearValue_SelectedIndexChanged;
            // 
            // CourseValue
            // 
            CourseValue.FormattingEnabled = true;
            CourseValue.Items.AddRange(new object[] { "BSCS", "BSEMC", "BSIS", "BSIT" });
            CourseValue.Location = new Point(33, 171);
            CourseValue.Name = "CourseValue";
            CourseValue.Size = new Size(79, 28);
            CourseValue.TabIndex = 3;
            CourseValue.Text = "Course";
            CourseValue.SelectedIndexChanged += CourseValue_SelectedIndexChanged;
            // 
            // cysLabel
            // 
            cysLabel.AutoSize = true;
            cysLabel.Location = new Point(31, 148);
            cysLabel.Name = "cysLabel";
            cysLabel.Size = new Size(143, 20);
            cysLabel.TabIndex = 45;
            cysLabel.Text = "Course/Year/Section";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(32, 33, 35);
            label2.Location = new Point(281, 141);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 23;
            label2.Text = "Student ID";
            // 
            // StudentIDValue
            // 
            StudentIDValue.ForeColor = Color.DimGray;
            StudentIDValue.Location = new Point(281, 171);
            StudentIDValue.Name = "StudentIDValue";
            StudentIDValue.Size = new Size(203, 27);
            StudentIDValue.TabIndex = 6;
            // 
            // LastNameValue
            // 
            LastNameValue.ForeColor = Color.DimGray;
            LastNameValue.Location = new Point(281, 89);
            LastNameValue.Name = "LastNameValue";
            LastNameValue.Size = new Size(203, 27);
            LastNameValue.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(32, 33, 35);
            label3.Location = new Point(281, 57);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 20;
            label3.Text = "Last Name";
            // 
            // PasswordValue
            // 
            PasswordValue.ForeColor = Color.DimGray;
            PasswordValue.Location = new Point(331, 57);
            PasswordValue.Name = "PasswordValue";
            PasswordValue.Size = new Size(228, 27);
            PasswordValue.TabIndex = 8;
            PasswordValue.UseSystemPasswordChar = true;
            // 
            // UsernameValue
            // 
            UsernameValue.ForeColor = Color.DimGray;
            UsernameValue.Location = new Point(38, 99);
            UsernameValue.Name = "UsernameValue";
            UsernameValue.Size = new Size(249, 27);
            UsernameValue.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(32, 33, 35);
            label1.Location = new Point(38, 64);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 37;
            label1.Text = "Username";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(32, 33, 35);
            label8.Location = new Point(22, 23);
            label8.Name = "label8";
            label8.Size = new Size(152, 20);
            label8.TabIndex = 45;
            label8.Text = "Sign Up Information";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(32, 33, 35);
            label6.Location = new Point(331, 22);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 26;
            label6.Text = "Password";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(ConfirmPasswordValue);
            groupBox2.Controls.Add(pictureBox6);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(UsernameValue);
            groupBox2.Controls.Add(PasswordValue);
            groupBox2.Location = new Point(27, 305);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(625, 169);
            groupBox2.TabIndex = 47;
            groupBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(32, 33, 35);
            label5.Location = new Point(331, 92);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 48;
            label5.Text = "Confirm Password";
            // 
            // ConfirmPasswordValue
            // 
            ConfirmPasswordValue.ForeColor = Color.DimGray;
            ConfirmPasswordValue.Location = new Point(331, 127);
            ConfirmPasswordValue.Name = "ConfirmPasswordValue";
            ConfirmPasswordValue.Size = new Size(228, 27);
            ConfirmPasswordValue.TabIndex = 47;
            ConfirmPasswordValue.UseSystemPasswordChar = true;
            // 
            // pictureBox6
            // 
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(576, 99);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(25, 21);
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
            label4.Location = new Point(75, 477);
            label4.Name = "label4";
            label4.Size = new Size(182, 60);
            label4.TabIndex = 49;
            label4.Text = "University of Caloocan City\r\n-Congressional Campus\r\n\r\n@mis.ucc.com";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(81, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 163);
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
            label11.Location = new Point(78, 247);
            label11.Name = "label11";
            label11.Size = new Size(174, 30);
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
            button1.Location = new Point(197, 507);
            button1.Name = "button1";
            button1.Size = new Size(120, 37);
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
            panel3.Location = new Point(683, -3);
            panel3.Name = "panel3";
            panel3.Size = new Size(331, 597);
            panel3.TabIndex = 54;
            // 
            // ExitBTN
            // 
            ExitBTN.BackgroundImage = (Image)resources.GetObject("ExitBTN.BackgroundImage");
            ExitBTN.Cursor = Cursors.Hand;
            ExitBTN.Location = new Point(652, 7);
            ExitBTN.Name = "ExitBTN";
            ExitBTN.Size = new Size(22, 23);
            ExitBTN.SizeMode = PictureBoxSizeMode.StretchImage;
            ExitBTN.TabIndex = 64;
            ExitBTN.TabStop = false;
            ExitBTN.Click += ExitBTN_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1013, 588);
            Controls.Add(ExitBTN);
            Controls.Add(panel3);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(RegisterButton);
            Controls.Add(label10);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRATION";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ExitBTN).EndInit();
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
        private Label label5;
        private TextBox ConfirmPasswordValue;
        private PictureBox ExitBTN;
    }
}