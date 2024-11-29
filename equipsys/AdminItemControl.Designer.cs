namespace equipsys
{
    partial class AdminItemControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminItemControl));
            imageBox = new PictureBox();
            Namelbl = new Label();
            Stocklbl = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)imageBox).BeginInit();
            SuspendLayout();
            // 
            // imageBox
            // 
            imageBox.Image = (Image)resources.GetObject("imageBox.Image");
            imageBox.Location = new Point(39, 10);
            imageBox.Name = "imageBox";
            imageBox.Size = new Size(199, 147);
            imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox.TabIndex = 0;
            imageBox.TabStop = false;
            imageBox.Click += pictureBox1_Click;
            // 
            // Namelbl
            // 
            Namelbl.AutoSize = true;
            Namelbl.BackColor = Color.Transparent;
            Namelbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Namelbl.ForeColor = Color.DimGray;
            Namelbl.Location = new Point(259, 22);
            Namelbl.Name = "Namelbl";
            Namelbl.Size = new Size(51, 20);
            Namelbl.TabIndex = 3;
            Namelbl.Text = "NAME";
            Namelbl.Click += label3_Click;
            // 
            // Stocklbl
            // 
            Stocklbl.AutoSize = true;
            Stocklbl.BackColor = Color.Transparent;
            Stocklbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Stocklbl.ForeColor = Color.DimGray;
            Stocklbl.Location = new Point(259, 57);
            Stocklbl.Name = "Stocklbl";
            Stocklbl.Size = new Size(53, 20);
            Stocklbl.TabIndex = 4;
            Stocklbl.Text = "STOCK";
            Stocklbl.Click += label2_Click_1;
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
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(400, 135);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 6;
            button1.Text = "EDIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Firebrick;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(518, 135);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 7;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(494, 22);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 8;
            label4.Text = "DESCRIPTION";
            // 
            // AdminItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Stocklbl);
            Controls.Add(Namelbl);
            Controls.Add(imageBox);
            Name = "AdminItemControl";
            Size = new Size(627, 172);
            Load += ItemUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)imageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imageBox;
        private Label Namelbl;
        private Label Stocklbl;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label4;
    }
}
