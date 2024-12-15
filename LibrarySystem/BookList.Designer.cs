namespace LibrarySystem
{
    partial class BookList
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
            lbl_bookList = new Label();
            TitlePanel = new Panel();
            dataGridView1 = new DataGridView();
            input_search = new TextBox();
            btn_search = new Button();
            TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl_bookList
            // 
            lbl_bookList.AutoSize = true;
            lbl_bookList.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_bookList.Location = new Point(279, 10);
            lbl_bookList.Name = "lbl_bookList";
            lbl_bookList.Size = new Size(113, 30);
            lbl_bookList.TabIndex = 0;
            lbl_bookList.Text = "Book Lists";
            // 
            // TitlePanel
            // 
            TitlePanel.BackColor = Color.LightPink;
            TitlePanel.Controls.Add(lbl_bookList);
            TitlePanel.Dock = DockStyle.Top;
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(706, 50);
            TitlePanel.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.MistyRose;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(706, 234);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // input_search
            // 
            input_search.Location = new Point(467, 56);
            input_search.Name = "input_search";
            input_search.PlaceholderText = "Search Title";
            input_search.Size = new Size(155, 23);
            input_search.TabIndex = 3;
            // 
            // btn_search
            // 
            btn_search.BackColor = SystemColors.ActiveCaption;
            btn_search.Location = new Point(628, 55);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(75, 23);
            btn_search.TabIndex = 4;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // BookList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_search);
            Controls.Add(input_search);
            Controls.Add(dataGridView1);
            Controls.Add(TitlePanel);
            Name = "BookList";
            Size = new Size(706, 337);
            Load += BookList_Load;
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_bookList;
        private Panel TitlePanel;
        private DataGridView dataGridView1;
        private TextBox input_search;
        private Button btn_search;
    }
}
