namespace equipsys
{
    partial class UserItems
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
            UserItemsPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // UserItemsPanel
            // 
            UserItemsPanel.AutoScroll = true;
            UserItemsPanel.Dock = DockStyle.Fill;
            UserItemsPanel.Location = new Point(0, 0);
            UserItemsPanel.Margin = new Padding(3, 2, 3, 2);
            UserItemsPanel.Name = "UserItemsPanel";
            UserItemsPanel.Size = new Size(700, 338);
            UserItemsPanel.TabIndex = 0;
            // 
            // UserItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(UserItemsPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserItems";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserItems";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel UserItemsPanel;
    }
}