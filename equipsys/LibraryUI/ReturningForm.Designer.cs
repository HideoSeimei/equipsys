namespace equipsys.LibraryUI
{
    partial class ReturningForm
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
            SaveItemButton = new Button();
            TransactionIDValue = new TextBox();
            StudentIDValue = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            StudentIDValues = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SaveItemButton
            // 
            SaveItemButton.BackColor = Color.FromArgb(32, 33, 35);
            SaveItemButton.Cursor = Cursors.Hand;
            SaveItemButton.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            SaveItemButton.ForeColor = Color.White;
            SaveItemButton.Location = new Point(177, 255);
            SaveItemButton.Name = "SaveItemButton";
            SaveItemButton.Size = new Size(207, 35);
            SaveItemButton.TabIndex = 16;
            SaveItemButton.Text = "Save as Returned";
            SaveItemButton.UseVisualStyleBackColor = false;
            SaveItemButton.Click += SaveItemButton_Click;
            // 
            // TransactionIDValue
            // 
            TransactionIDValue.Location = new Point(109, 193);
            TransactionIDValue.Name = "TransactionIDValue";
            TransactionIDValue.Size = new Size(293, 27);
            TransactionIDValue.TabIndex = 14;
            TransactionIDValue.TextChanged += ItemDescriptionBox_TextChanged;
            // 
            // StudentIDValue
            // 
            StudentIDValue.Location = new Point(109, 114);
            StudentIDValue.Name = "StudentIDValue";
            StudentIDValue.Size = new Size(293, 27);
            StudentIDValue.TabIndex = 13;
            StudentIDValue.TextChanged += ItemNameBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(32, 33, 35);
            label4.Location = new Point(109, 157);
            label4.Name = "label4";
            label4.Size = new Size(134, 25);
            label4.TabIndex = 11;
            label4.Text = "Transaction ID:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(32, 33, 35);
            label3.Location = new Point(109, 80);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 10;
            label3.Text = "Student ID:";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(32, 33, 35);
            label1.Location = new Point(177, 22);
            label1.Name = "label1";
            label1.Size = new Size(187, 27);
            label1.TabIndex = 17;
            label1.Text = "Returning Form";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(StudentIDValues);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SaveItemButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TransactionIDValue);
            panel1.Controls.Add(StudentIDValue);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(36, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 324);
            panel1.TabIndex = 18;
            // 
            // StudentIDValues
            // 
            StudentIDValues.FormattingEnabled = true;
            StudentIDValues.Location = new Point(109, 117);
            StudentIDValues.Name = "StudentIDValues";
            StudentIDValues.Size = new Size(293, 28);
            StudentIDValues.TabIndex = 18;
            // 
            // ReturningForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 387);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReturningForm";
            Text = "ReturnForm";
            Load += ReturningForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button SaveItemButton;

        public TextBox TransactionIDValue;
        public TextBox StudentIDValue;
        public Label label4;
        public Label label3;
        public Label label1;
        private Panel panel1;
        private ComboBox StudentIDValues;
    }
}