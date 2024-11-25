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
            UserItemsPanel.Name = "UserItemsPanel";
            UserItemsPanel.Size = new Size(800, 450);
            UserItemsPanel.TabIndex = 0;
            UserItemsPanel.Paint += flowLayoutPanel1_Paint;
            // 
            // UserItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UserItemsPanel);
            Name = "UserItems";
            Text = "UserItems";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel UserItemsPanel;
    }
}