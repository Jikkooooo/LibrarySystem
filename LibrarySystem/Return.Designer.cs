namespace LibrarySystem
{
    partial class Return
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_return = new Label();
            TitlePanel = new Panel();
            TitlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_return
            // 
            lbl_return.AutoSize = true;
            lbl_return.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_return.Location = new Point(279, 10);
            lbl_return.Name = "lbl_return";
            lbl_return.Size = new Size(136, 30);
            lbl_return.TabIndex = 0;
            lbl_return.Text = "Return Book";
            // 
            // TitlePanel
            // 
            TitlePanel.Controls.Add(lbl_return);
            TitlePanel.Dock = DockStyle.Top;
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(706, 50);
            TitlePanel.TabIndex = 1;
            // 
            // Return
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TitlePanel);
            Name = "Return";
            Size = new Size(706, 337);
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_return;
        private Panel TitlePanel;
    }
}
