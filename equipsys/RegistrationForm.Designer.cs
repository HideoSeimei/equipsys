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
            ReturnButton = new Button();
            RegisterButton = new Button();
            CourseBox = new TextBox();
            label5 = new Label();
            FNameBox = new TextBox();
            label9 = new Label();
            label10 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            YearBox = new ComboBox();
            StudentIDBox = new TextBox();
            LNameBox = new TextBox();
            label3 = new Label();
            PasswordBox = new TextBox();
            UsernameBox = new TextBox();
            label1 = new Label();
            label8 = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.ForestGreen;
            label7.Location = new Point(27, 99);
            label7.Name = "label7";
            label7.Size = new Size(158, 20);
            label7.TabIndex = 44;
            label7.Text = "Personal Information";
            // 
            // ReturnButton
            // 
            ReturnButton.BackColor = Color.Transparent;
            ReturnButton.Cursor = Cursors.Hand;
            ReturnButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ReturnButton.ForeColor = Color.ForestGreen;
            ReturnButton.Location = new Point(178, 519);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(120, 29);
            ReturnButton.TabIndex = 43;
            ReturnButton.Text = "Back";
            ReturnButton.UseVisualStyleBackColor = false;
            ReturnButton.Click += RegisterButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.ForestGreen;
            RegisterButton.Cursor = Cursors.Hand;
            RegisterButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterButton.ForeColor = Color.White;
            RegisterButton.Location = new Point(358, 519);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(120, 29);
            RegisterButton.TabIndex = 42;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // CourseBox
            // 
            CourseBox.ForeColor = Color.DimGray;
            CourseBox.Location = new Point(34, 171);
            CourseBox.Name = "CourseBox";
            CourseBox.Size = new Size(215, 27);
            CourseBox.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.ForestGreen;
            label5.Location = new Point(34, 141);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 39;
            label5.Text = "Course/Program";
            // 
            // FNameBox
            // 
            FNameBox.ForeColor = Color.DimGray;
            FNameBox.Location = new Point(34, 89);
            FNameBox.Name = "FNameBox";
            FNameBox.Size = new Size(215, 27);
            FNameBox.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.ForestGreen;
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
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.ForestGreen;
            label10.Location = new Point(11, 29);
            label10.Name = "label10";
            label10.Size = new Size(128, 28);
            label10.TabIndex = 34;
            label10.Text = "Registration";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(YearBox);
            groupBox1.Controls.Add(StudentIDBox);
            groupBox1.Controls.Add(LNameBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(CourseBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(FNameBox);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(11, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(641, 219);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(293, 141);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 23;
            label2.Text = "Student ID";
            // 
            // YearBox
            // 
            YearBox.AllowDrop = true;
            YearBox.BackColor = Color.White;
            YearBox.DropDownHeight = 75;
            YearBox.DropDownWidth = 75;
            YearBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            YearBox.ForeColor = Color.ForestGreen;
            YearBox.FormattingEnabled = true;
            YearBox.IntegralHeight = false;
            YearBox.Items.AddRange(new object[] { "1st Year", "2nd Year", "3rd Year", "4th Year" });
            YearBox.Location = new Point(518, 89);
            YearBox.Name = "YearBox";
            YearBox.Size = new Size(105, 28);
            YearBox.TabIndex = 18;
            YearBox.Text = " Year";
            YearBox.SelectedIndexChanged += YearBox_SelectedIndexChanged;
            // 
            // StudentIDBox
            // 
            StudentIDBox.ForeColor = Color.DimGray;
            StudentIDBox.Location = new Point(293, 171);
            StudentIDBox.Name = "StudentIDBox";
            StudentIDBox.Size = new Size(203, 27);
            StudentIDBox.TabIndex = 22;
            // 
            // LNameBox
            // 
            LNameBox.ForeColor = Color.DimGray;
            LNameBox.Location = new Point(293, 89);
            LNameBox.Name = "LNameBox";
            LNameBox.Size = new Size(203, 27);
            LNameBox.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(293, 57);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 20;
            label3.Text = "Last Name";
            // 
            // PasswordBox
            // 
            PasswordBox.ForeColor = Color.DimGray;
            PasswordBox.Location = new Point(347, 99);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(228, 27);
            PasswordBox.TabIndex = 41;
            // 
            // UsernameBox
            // 
            UsernameBox.ForeColor = Color.DimGray;
            UsernameBox.Location = new Point(38, 99);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(249, 27);
            UsernameBox.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.ForestGreen;
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
            label8.ForeColor = Color.ForestGreen;
            label8.Location = new Point(16, 24);
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
            label6.ForeColor = Color.ForestGreen;
            label6.Location = new Point(347, 64);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 26;
            label6.Text = "Password";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(UsernameBox);
            groupBox2.Controls.Add(PasswordBox);
            groupBox2.Location = new Point(11, 317);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(641, 157);
            groupBox2.TabIndex = 47;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(783, 475);
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
            pictureBox1.Location = new Point(786, 93);
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
            label11.Location = new Point(786, 282);
            label11.Name = "label11";
            label11.Size = new Size(174, 30);
            label11.TabIndex = 51;
            label11.Text = "Create an account for you\r\nto explore our system!\r\n";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1013, 588);
            Controls.Add(label11);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(label7);
            Controls.Add(ReturnButton);
            Controls.Add(RegisterButton);
            Controls.Add(label10);
            Controls.Add(groupBox1);
            Name = "RegistrationForm";
            Text = "REGISTRATION";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Button ReturnButton;
        private Button RegisterButton;
        private TextBox CourseBox;
        private Label label5;
        private TextBox FNameBox;
        private Label label9;
        private Label label10;
        private GroupBox groupBox1;
        private ComboBox YearBox;
        private Label label3;
        private TextBox LNameBox;
        private TextBox StudentIDBox;
        private Label label2;
        private TextBox PasswordBox;
        private TextBox UsernameBox;
        private Label label1;
        private Label label8;
        private Label label6;
        private GroupBox groupBox2;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label11;
    }
}