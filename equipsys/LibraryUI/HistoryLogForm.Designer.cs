namespace equipsys
{
    partial class HistoryLogForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            openFileDialog1 = new OpenFileDialog();
            SaveItemButton = new Button();
            ReturnButton = new Button();
            dataGridView1 = new DataGridView();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // SaveItemButton
            // 
            SaveItemButton.BackColor = Color.ForestGreen;
            SaveItemButton.Cursor = Cursors.Hand;
            SaveItemButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SaveItemButton.ForeColor = Color.White;
            SaveItemButton.Location = new Point(512, 261);
            SaveItemButton.Margin = new Padding(3, 2, 3, 2);
            SaveItemButton.Name = "SaveItemButton";
            SaveItemButton.Size = new Size(109, 22);
            SaveItemButton.TabIndex = 8;
            SaveItemButton.Text = "Reload";
            SaveItemButton.UseVisualStyleBackColor = false;
            SaveItemButton.Click += SaveItemButton_Click;
            // 
            // ReturnButton
            // 
            ReturnButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ReturnButton.ForeColor = Color.ForestGreen;
            ReturnButton.Location = new Point(397, 261);
            ReturnButton.Margin = new Padding(3, 2, 3, 2);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(109, 22);
            ReturnButton.TabIndex = 9;
            ReturnButton.Text = "Process Return";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(619, 244);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(dataGridView1);
            guna2Panel1.Controls.Add(ReturnButton);
            guna2Panel1.Controls.Add(SaveItemButton);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(643, 294);
            guna2Panel1.TabIndex = 53;
            // 
            // HistoryLogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 294);
            Controls.Add(guna2Panel1);
            Name = "HistoryLogForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HISTORY";
            Load += HistoryLogForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private Button SaveItemButton;
        private Button ReturnButton;
        private DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}