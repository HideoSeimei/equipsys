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
            ItemStockBox = new TextBox();
            ItemDescriptionBox = new TextBox();
            ItemNameBox = new TextBox();
            label5 = new Label();
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
            SaveItemButton.Location = new Point(218, 219);
            SaveItemButton.Margin = new Padding(3, 2, 3, 2);
            SaveItemButton.Name = "SaveItemButton";
            SaveItemButton.Size = new Size(139, 26);
            SaveItemButton.TabIndex = 16;
            SaveItemButton.Text = "Save as Returned";
            SaveItemButton.UseVisualStyleBackColor = false;
            SaveItemButton.Click += SaveItemButton_Click;
            // 
            // ItemStockBox
            // 
            ItemStockBox.Location = new Point(114, 156);
            ItemStockBox.Margin = new Padding(3, 2, 3, 2);
            ItemStockBox.Name = "ItemStockBox";
            ItemStockBox.Size = new Size(86, 23);
            ItemStockBox.TabIndex = 15;
            // 
            // ItemDescriptionBox
            // 
            ItemDescriptionBox.Location = new Point(111, 100);
            ItemDescriptionBox.Margin = new Padding(3, 2, 3, 2);
            ItemDescriptionBox.Name = "ItemDescriptionBox";
            ItemDescriptionBox.Size = new Size(324, 23);
            ItemDescriptionBox.TabIndex = 14;
            // 
            // ItemNameBox
            // 
            ItemNameBox.Location = new Point(113, 50);
            ItemNameBox.Margin = new Padding(3, 2, 3, 2);
            ItemNameBox.Name = "ItemNameBox";
            ItemNameBox.Size = new Size(324, 23);
            ItemNameBox.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.ForestGreen;
            label5.Location = new Point(111, 132);
            label5.Name = "label5";
            label5.Size = new Size(110, 17);
            label5.TabIndex = 12;
            label5.Text = "Starting Time:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.ForestGreen;
            label4.Location = new Point(112, 78);
            label4.Name = "label4";
            label4.Size = new Size(91, 17);
            label4.TabIndex = 11;
            label4.Text = "Item Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(111, 23);
            label3.Name = "label3";
            label3.Size = new Size(89, 17);
            label3.TabIndex = 10;
            label3.Text = "Student ID:";
            // 
            // ReturningForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 290);
            Controls.Add(SaveItemButton);
            Controls.Add(ItemStockBox);
            Controls.Add(ItemDescriptionBox);
            Controls.Add(ItemNameBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "ReturningForm";
            Text = "ReturnForm";
            Load += ReturningForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SaveItemButton;
        public TextBox ItemStockBox;
        public TextBox ItemDescriptionBox;
        public TextBox ItemNameBox;
        public Label label5;
        public Label label4;
        public Label label3;
    }
}