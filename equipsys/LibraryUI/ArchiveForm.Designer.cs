namespace equipsys.LibraryUI
{
    partial class ArchiveForm
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
            ArchiveDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ArchiveDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ArchiveDataGridView
            // 
            ArchiveDataGridView.BackgroundColor = Color.White;
            ArchiveDataGridView.BorderStyle = BorderStyle.None;
            ArchiveDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ArchiveDataGridView.Dock = DockStyle.Fill;
            ArchiveDataGridView.Location = new Point(0, 0);
            ArchiveDataGridView.Name = "ArchiveDataGridView";
            ArchiveDataGridView.ReadOnly = true;
            ArchiveDataGridView.RowTemplate.Height = 25;
            ArchiveDataGridView.Size = new Size(684, 299);
            ArchiveDataGridView.TabIndex = 0;
            ArchiveDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ArchiveForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 299);
            Controls.Add(ArchiveDataGridView);
            Name = "ArchiveForm";
            Text = "ArchiveForm";
            Load += ArchiveForm_Load;
            ((System.ComponentModel.ISupportInitialize)ArchiveDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView ArchiveDataGridView;
    }
}