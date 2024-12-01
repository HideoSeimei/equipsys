namespace equipsys
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            pictureBox6 = new PictureBox();
            passwordbox = new TextBox();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            usernamebox = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            accountChecker = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(660, 328);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 20;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.ForestGreen;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.DisabledLinkColor = Color.ForestGreen;
            linkLabel1.ForeColor = Color.ForestGreen;
            linkLabel1.LinkColor = Color.ForestGreen;
            linkLabel1.Location = new Point(849, 339);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(125, 20);
            linkLabel1.TabIndex = 19;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password?";
            linkLabel1.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.ForestGreen;
            button2.Location = new Point(651, 430);
            button2.Name = "button2";
            button2.Size = new Size(322, 39);
            button2.TabIndex = 18;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(651, 377);
            button1.Name = "button1";
            button1.Size = new Size(323, 45);
            button1.TabIndex = 15;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(passwordbox);
            panel2.Controls.Add(pictureBox4);
            panel2.Location = new Point(650, 261);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 58);
            panel2.TabIndex = 17;
            // 
            // pictureBox6
            // 
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(285, 15);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(25, 21);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // passwordbox
            // 
            passwordbox.BackColor = Color.WhiteSmoke;
            passwordbox.BorderStyle = BorderStyle.None;
            passwordbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            passwordbox.ForeColor = Color.DimGray;
            passwordbox.Location = new Point(64, 14);
            passwordbox.Name = "passwordbox";
            passwordbox.PlaceholderText = " Password";
            passwordbox.Size = new Size(253, 23);
            passwordbox.TabIndex = 1;
            passwordbox.UseSystemPasswordChar = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(9, 9);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 41);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(usernamebox);
            panel1.Location = new Point(650, 189);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 58);
            panel1.TabIndex = 16;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(7, 9);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // usernamebox
            // 
            usernamebox.BackColor = Color.WhiteSmoke;
            usernamebox.BorderStyle = BorderStyle.None;
            usernamebox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            usernamebox.ForeColor = Color.DimGray;
            usernamebox.Location = new Point(64, 17);
            usernamebox.Name = "usernamebox";
            usernamebox.PlaceholderText = " Username";
            usernamebox.Size = new Size(253, 23);
            usernamebox.TabIndex = 1;
            usernamebox.TextChanged += usernamebox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(640, 85);
            label1.Name = "label1";
            label1.Size = new Size(340, 34);
            label1.TabIndex = 21;
            label1.Text = "Login to Your Account";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(312, 479);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(251, 479);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(63, 85);
            label6.Name = "label6";
            label6.Size = new Size(465, 64);
            label6.TabIndex = 27;
            label6.Text = "Management Information System\r\n(Borrowing System)";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // accountChecker
            // 
            accountChecker.AutoSize = true;
            accountChecker.BackColor = Color.Transparent;
            accountChecker.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            accountChecker.ForeColor = Color.Crimson;
            accountChecker.Location = new Point(644, 335);
            accountChecker.Name = "accountChecker";
            accountChecker.Size = new Size(14, 20);
            accountChecker.TabIndex = 29;
            accountChecker.Text = " ";
            accountChecker.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(119, 408);
            label3.Name = "label3";
            label3.Size = new Size(367, 51);
            label3.TabIndex = 31;
            label3.Text = "Our MIS Borrowing System makes borrowing items a breeze!\r\nRequest, track, and return with ease—all while keeping\r\neverything organized and hassle-free.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.ForestGreen;
            label4.Location = new Point(745, 148);
            label4.Name = "label4";
            label4.Size = new Size(141, 23);
            label4.TabIndex = 32;
            label4.Text = "Login as staff";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(196, 183);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(205, 190);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 33;
            pictureBox5.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1013, 588);
            Controls.Add(pictureBox5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(accountChecker);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff Login";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private LinkLabel linkLabel1;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private TextBox passwordbox;
        private PictureBox pictureBox4;
        private Panel panel1;
        private PictureBox pictureBox3;
        private TextBox usernamebox;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label6;
        private PictureBox pictureBox6;
        private Label accountChecker;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox5;
    }
}
