namespace equipsys
{
    partial class UserItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserItemControl));
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            ReturnButton = new Button();
            BorrowingButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(259, 22);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 3;
            label3.Text = "NAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(259, 57);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 4;
            label2.Text = "STOCK";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(259, 89);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 5;
            label1.Text = "AVAILABILITY";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(435, 22);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 8;
            label4.Text = "DESCRIPTION";
            // 
            // ReturnButton
            // 
            ReturnButton.BackColor = Color.DarkGoldenrod;
            ReturnButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ReturnButton.ForeColor = Color.White;
            ReturnButton.Location = new Point(494, 135);
            ReturnButton.Margin = new Padding(3, 2, 3, 2);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(118, 30);
            ReturnButton.TabIndex = 9;
            ReturnButton.Text = "RETURN";
            ReturnButton.UseVisualStyleBackColor = false;
            ReturnButton.Click += ReturningButton_Click;
            // 
            // BorrowingButton
            // 
            BorrowingButton.BackColor = Color.SteelBlue;
            BorrowingButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BorrowingButton.ForeColor = Color.White;
            BorrowingButton.Location = new Point(370, 135);
            BorrowingButton.Margin = new Padding(3, 2, 3, 2);
            BorrowingButton.Name = "BorrowingButton";
            BorrowingButton.Size = new Size(118, 30);
            BorrowingButton.TabIndex = 10;
            BorrowingButton.Text = "BORROW";
            BorrowingButton.UseVisualStyleBackColor = false;
            BorrowingButton.Click += BorrowingButton_Click;
            // 
            // UserItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(BorrowingButton);
            Controls.Add(ReturnButton);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Name = "UserItemControl";
            Size = new Size(627, 172);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button ReturnButton;
        private Button BorrowingButton;
    }
}
