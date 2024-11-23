namespace equipsys
{
    partial class REGISTRATION
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REGISTRATION));
            label7 = new Label();
            button2 = new Button();
            button1 = new Button();
            courseReg = new TextBox();
            label5 = new Label();
            firstnameReg = new TextBox();
            label9 = new Label();
            label10 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            yearReg = new ComboBox();
            studentidReg = new TextBox();
            lastnameReg = new TextBox();
            label3 = new Label();
            passwordReg = new TextBox();
            usernameReg = new TextBox();
            label1 = new Label();
            label8 = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
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
            // button2
            // 
            button2.BackColor = Color.ForestGreen;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(366, 505);
            button2.Name = "button2";
            button2.Size = new Size(120, 29);
            button2.TabIndex = 43;
            button2.Text = "Back to Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(161, 505);
            button1.Name = "button1";
            button1.Size = new Size(120, 29);
            button1.TabIndex = 42;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // courseReg
            // 
            courseReg.ForeColor = Color.DimGray;
            courseReg.Location = new Point(34, 170);
            courseReg.Name = "courseReg";
            courseReg.Size = new Size(215, 27);
            courseReg.TabIndex = 40;
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
            // firstnameReg
            // 
            firstnameReg.ForeColor = Color.DimGray;
            firstnameReg.Location = new Point(34, 89);
            firstnameReg.Name = "firstnameReg";
            firstnameReg.Size = new Size(215, 27);
            firstnameReg.TabIndex = 36;
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
            label10.Location = new Point(12, 30);
            label10.Name = "label10";
            label10.Size = new Size(128, 28);
            label10.TabIndex = 34;
            label10.Text = "Registration";
            label10.Click += label10_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(yearReg);
            groupBox1.Controls.Add(studentidReg);
            groupBox1.Controls.Add(lastnameReg);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(courseReg);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(firstnameReg);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(12, 80);
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
            label2.Location = new Point(292, 141);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 23;
            label2.Text = "Student ID";
            // 
            // yearReg
            // 
            yearReg.AllowDrop = true;
            yearReg.BackColor = Color.White;
            yearReg.DropDownHeight = 75;
            yearReg.DropDownWidth = 75;
            yearReg.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            yearReg.ForeColor = Color.ForestGreen;
            yearReg.FormattingEnabled = true;
            yearReg.IntegralHeight = false;
            yearReg.Items.AddRange(new object[] { "1st Year", "2nd Year", "3rd Year", "4th Year" });
            yearReg.Location = new Point(518, 89);
            yearReg.Name = "yearReg";
            yearReg.Size = new Size(105, 28);
            yearReg.TabIndex = 18;
            yearReg.Text = " Year";
            // 
            // studentidReg
            // 
            studentidReg.ForeColor = Color.DimGray;
            studentidReg.Location = new Point(292, 170);
            studentidReg.Name = "studentidReg";
            studentidReg.Size = new Size(203, 27);
            studentidReg.TabIndex = 22;
            studentidReg.TextChanged += textBox6_TextChanged;
            // 
            // lastnameReg
            // 
            lastnameReg.ForeColor = Color.DimGray;
            lastnameReg.Location = new Point(292, 89);
            lastnameReg.Name = "lastnameReg";
            lastnameReg.Size = new Size(203, 27);
            lastnameReg.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(292, 57);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 20;
            label3.Text = "Last Name";
            // 
            // passwordReg
            // 
            passwordReg.ForeColor = Color.DimGray;
            passwordReg.Location = new Point(348, 99);
            passwordReg.Name = "passwordReg";
            passwordReg.Size = new Size(228, 27);
            passwordReg.TabIndex = 41;
            // 
            // usernameReg
            // 
            usernameReg.ForeColor = Color.DimGray;
            usernameReg.Location = new Point(38, 99);
            usernameReg.Name = "usernameReg";
            usernameReg.Size = new Size(249, 27);
            usernameReg.TabIndex = 38;
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
            label8.Location = new Point(15, 23);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 45;
            label8.Text = "Sign Up";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.ForestGreen;
            label6.Location = new Point(348, 64);
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
            groupBox2.Controls.Add(usernameReg);
            groupBox2.Controls.Add(passwordReg);
            groupBox2.Location = new Point(12, 317);
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
            label4.Location = new Point(783, 474);
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
            pictureBox1.Location = new Point(799, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // REGISTRATION
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1013, 588);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(groupBox1);
            Name = "REGISTRATION";
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
        private Button button2;
        private Button button1;
        private TextBox courseReg;
        private Label label5;
        private TextBox firstnameReg;
        private Label label9;
        private Label label10;
        private GroupBox groupBox1;
        private ComboBox yearReg;
        private Label label3;
        private TextBox lastnameReg;
        private TextBox studentidReg;
        private Label label2;
        private TextBox passwordReg;
        private TextBox usernameReg;
        private Label label1;
        private Label label8;
        private Label label6;
        private GroupBox groupBox2;
        private Label label4;
        private PictureBox pictureBox1;
    }
}