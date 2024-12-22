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
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            StudentIDValue = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SaveItemButton
            // 
            SaveItemButton.BackColor = Color.FromArgb(32, 33, 35);
            SaveItemButton.Cursor = Cursors.Hand;
            SaveItemButton.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            SaveItemButton.ForeColor = Color.White;
            SaveItemButton.Location = new Point(155, 191);
            SaveItemButton.Margin = new Padding(3, 2, 3, 2);
            SaveItemButton.Name = "SaveItemButton";
            SaveItemButton.Size = new Size(181, 26);
            SaveItemButton.TabIndex = 16;
            SaveItemButton.Text = "Save as Returned";
            SaveItemButton.UseVisualStyleBackColor = false;
            SaveItemButton.Click += SaveItemButton_Click;
            // 
            // TransactionIDValue
            // 
            TransactionIDValue.Location = new Point(95, 145);
            TransactionIDValue.Margin = new Padding(3, 2, 3, 2);
            TransactionIDValue.Name = "TransactionIDValue";
            TransactionIDValue.Size = new Size(257, 23);
            TransactionIDValue.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(32, 33, 35);
            label4.Location = new Point(95, 118);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 11;
            label4.Text = "Transaction ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(32, 33, 35);
            label3.Location = new Point(95, 60);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 10;
            label3.Text = "Student ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(32, 33, 35);
            label1.Location = new Point(155, 16);
            label1.Name = "label1";
            label1.Size = new Size(148, 21);
            label1.TabIndex = 17;
            label1.Text = "Returning Form";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(StudentIDValue);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SaveItemButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TransactionIDValue);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(32, 28);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(478, 243);
            panel1.TabIndex = 18;
            // 
            // StudentIDValue
            // 
            StudentIDValue.FormattingEnabled = true;
            StudentIDValue.Location = new Point(95, 88);
            StudentIDValue.Margin = new Padding(3, 2, 3, 2);
            StudentIDValue.Name = "StudentIDValue";
            StudentIDValue.Size = new Size(257, 23);
            StudentIDValue.TabIndex = 18;
            // 
            // ReturningForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 290);
            Controls.Add(panel1);
            Name = "ReturningForm";
            Text = "ReturnForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button SaveItemButton;

        public TextBox TransactionIDValue;
        public Label label4;
        public Label label3;
        public Label label1;
        private Panel panel1;
        private ComboBox StudentIDValues;
        private ComboBox StudentIDValue;
    }
}