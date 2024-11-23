namespace equipsys
{
    partial class RECORD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RECORD));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            vScrollBar1 = new VScrollBar();
            label1 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            profileName = new Label();
            mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            button1 = new Button();
            items = new Button();
            pictureBox4 = new PictureBox();
            textBox1 = new TextBox();
            pictureBox5 = new PictureBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Course = new DataGridViewTextBoxColumn();
            Borrowed_Item = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // vScrollBar1
            // 
            vScrollBar1.AllowDrop = true;
            vScrollBar1.Cursor = Cursors.NoMoveVert;
            vScrollBar1.Location = new Point(954, 112);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(21, 436);
            vScrollBar1.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(198, 43);
            label1.Name = "label1";
            label1.Size = new Size(271, 32);
            label1.TabIndex = 27;
            label1.Text = "Borrower's History";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(37, 486);
            label2.Name = "label2";
            label2.Size = new Size(62, 17);
            label2.TabIndex = 24;
            label2.Text = "Log out";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(41, 274);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(41, 188);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // profileName
            // 
            profileName.AutoSize = true;
            profileName.BackColor = Color.Transparent;
            profileName.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            profileName.ForeColor = SystemColors.ActiveCaptionText;
            profileName.Location = new Point(88, 367);
            profileName.Name = "profileName";
            profileName.Size = new Size(137, 32);
            profileName.TabIndex = 19;
            profileName.Text = "PROFILE";
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(dataGridView1);
            mainPanel.CustomizableEdges = customizableEdges1;
            mainPanel.Location = new Point(198, 104);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            mainPanel.Size = new Size(753, 444);
            mainPanel.TabIndex = 29;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(89, 202);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 22;
            button1.Text = "RECORD";
            button1.UseVisualStyleBackColor = true;
            // 
            // items
            // 
            items.Location = new Point(89, 274);
            items.Margin = new Padding(3, 4, 3, 4);
            items.Name = "items";
            items.Size = new Size(115, 31);
            items.TabIndex = 21;
            items.Text = "ADD ITEMS";
            items.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(680, 40);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(38, 37);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 25;
            pictureBox4.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(724, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 27);
            textBox1.TabIndex = 26;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(41, 356);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(42, 43);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 30;
            pictureBox5.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Course, Borrowed_Item, Column2, Column3 });
            dataGridView1.GridColor = Color.ForestGreen;
            dataGridView1.Location = new Point(0, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(753, 438);
            dataGridView1.TabIndex = 31;
            // 
            // Column1
            // 
            Column1.HeaderText = "Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 175;
            // 
            // Course
            // 
            Course.HeaderText = "Course";
            Course.MinimumWidth = 6;
            Course.Name = "Course";
            Course.Width = 150;
            // 
            // Borrowed_Item
            // 
            Borrowed_Item.HeaderText = "Borrowed Item";
            Borrowed_Item.MinimumWidth = 6;
            Borrowed_Item.Name = "Borrowed_Item";
            Borrowed_Item.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Item";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Time";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // RECORD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1013, 588);
            Controls.Add(pictureBox5);
            Controls.Add(button1);
            Controls.Add(vScrollBar1);
            Controls.Add(items);
            Controls.Add(profileName);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox4);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(mainPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RECORD";
            Text = "HISTORY";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private VScrollBar vScrollBar1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label profileName;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Button button1;
        private Button items;
        private PictureBox pictureBox4;
        private TextBox textBox1;
        private PictureBox pictureBox5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Course;
        private DataGridViewTextBoxColumn Borrowed_Item;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}