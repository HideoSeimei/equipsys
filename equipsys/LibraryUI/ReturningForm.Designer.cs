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
            ItemDescriptionBox = new TextBox();
            ItemNameBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // SaveItemButton
            // 
            SaveItemButton.BackColor = Color.ForestGreen;
            SaveItemButton.Cursor = Cursors.Hand;
            SaveItemButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SaveItemButton.ForeColor = Color.White;
            SaveItemButton.Location = new Point(231, 290);
            SaveItemButton.Name = "SaveItemButton";
            SaveItemButton.Size = new Size(159, 35);
            SaveItemButton.TabIndex = 16;
            SaveItemButton.Text = "Save as Returned";
            SaveItemButton.UseVisualStyleBackColor = false;
            SaveItemButton.Click += SaveItemButton_Click;
            // 
            // ItemDescriptionBox
            // 
            ItemDescriptionBox.Location = new Point(129, 242);
            ItemDescriptionBox.Name = "ItemDescriptionBox";
            ItemDescriptionBox.Size = new Size(370, 27);
            ItemDescriptionBox.TabIndex = 14;
            ItemDescriptionBox.TextChanged += ItemDescriptionBox_TextChanged;
            // 
            // ItemNameBox
            // 
            ItemNameBox.Location = new Point(129, 130);
            ItemNameBox.Name = "ItemNameBox";
            ItemNameBox.Size = new Size(370, 27);
            ItemNameBox.TabIndex = 13;
            ItemNameBox.TextChanged += ItemNameBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.ForestGreen;
            label4.Location = new Point(127, 193);
            label4.Name = "label4";
            label4.Size = new Size(146, 21);
            label4.TabIndex = 11;
            label4.Text = "Transaction ID:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(129, 86);
            label3.Name = "label3";
            label3.Size = new Size(108, 21);
            label3.TabIndex = 10;
            label3.Text = "Student ID:";
            label3.Click += label3_Click;
            // 
            // ReturningForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 387);
            Controls.Add(SaveItemButton);
            Controls.Add(ItemDescriptionBox);
            Controls.Add(ItemNameBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReturningForm";
            Text = "ReturnForm";
            Load += ReturningForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SaveItemButton;
        public TextBox ItemDescriptionBox;
        public TextBox ItemNameBox;
        public Label label4;
        public Label label3;
    }
}