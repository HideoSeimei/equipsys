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
            SaveItemBTN = new Button();
            TransactionIDValue = new TextBox();
            StudentIDValue = new TextBox();
            tidLabel = new Label();
            sidLabel = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SaveItemBTN
            // 
            SaveItemBTN.BackColor = Color.FromArgb(32, 33, 35);
            SaveItemBTN.Cursor = Cursors.Hand;
            SaveItemBTN.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SaveItemBTN.ForeColor = Color.White;
            SaveItemBTN.Location = new Point(169, 191);
            SaveItemBTN.Margin = new Padding(3, 2, 3, 2);
            SaveItemBTN.Name = "SaveItemBTN";
            SaveItemBTN.Size = new Size(139, 26);
            SaveItemBTN.TabIndex = 16;
            SaveItemBTN.Text = "Save as Returned";
            SaveItemBTN.UseVisualStyleBackColor = false;
            SaveItemBTN.Click += SaveItemButton_Click;
            // 
            // TransactionIDValue
            // 
            TransactionIDValue.Location = new Point(95, 145);
            TransactionIDValue.Margin = new Padding(3, 2, 3, 2);
            TransactionIDValue.Name = "TransactionIDValue";
            TransactionIDValue.Size = new Size(257, 23);
            TransactionIDValue.TabIndex = 14;
            // 
            // StudentIDValue
            // 
            StudentIDValue.Location = new Point(95, 86);
            StudentIDValue.Margin = new Padding(3, 2, 3, 2);
            StudentIDValue.Name = "StudentIDValue";
            StudentIDValue.Size = new Size(257, 23);
            StudentIDValue.TabIndex = 13;
            // 
            // tidLabel
            // 
            tidLabel.AutoSize = true;
            tidLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tidLabel.ForeColor = Color.FromArgb(32, 33, 35);
            tidLabel.Location = new Point(95, 118);
            tidLabel.Name = "tidLabel";
            tidLabel.Size = new Size(110, 20);
            tidLabel.TabIndex = 11;
            tidLabel.Text = "Transaction ID:";
            // 
            // sidLabel
            // 
            sidLabel.AutoSize = true;
            sidLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            sidLabel.ForeColor = Color.FromArgb(32, 33, 35);
            sidLabel.Location = new Point(95, 60);
            sidLabel.Name = "sidLabel";
            sidLabel.Size = new Size(85, 20);
            sidLabel.TabIndex = 10;
            sidLabel.Text = "Student ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(32, 33, 35);
            label1.Location = new Point(164, 17);
            label1.Name = "label1";
            label1.Size = new Size(132, 18);
            label1.TabIndex = 17;
            label1.Text = "Returning Form";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SaveItemBTN);
            panel1.Controls.Add(sidLabel);
            panel1.Controls.Add(TransactionIDValue);
            panel1.Controls.Add(StudentIDValue);
            panel1.Controls.Add(tidLabel);
            panel1.Location = new Point(32, 28);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(478, 243);
            panel1.TabIndex = 18;
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
        private Button SaveItemBTN;
        public TextBox TransactionIDValue;
        public TextBox StudentIDValue;
        public Label tidLabel;
        public Label sidLabel;
        public Label label1;
        private Panel panel1;
    }
}