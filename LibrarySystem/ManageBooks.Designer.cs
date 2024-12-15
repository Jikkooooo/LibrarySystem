namespace LibrarySystem
{
    partial class ManageBooks
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
            panel1 = new Panel();
            lbl_borrow = new Label();
            input_title = new TextBox();
            input_author = new TextBox();
            input_genre = new TextBox();
            lbl_title = new Label();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            btn_add = new Button();
            btn_update = new Button();
            btn_remove = new Button();
            btn_refresh = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightPink;
            panel1.Controls.Add(lbl_borrow);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 50);
            panel1.TabIndex = 0;
            // 
            // lbl_borrow
            // 
            lbl_borrow.AutoSize = true;
            lbl_borrow.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_borrow.Location = new Point(268, 11);
            lbl_borrow.Name = "lbl_borrow";
            lbl_borrow.Size = new Size(158, 30);
            lbl_borrow.TabIndex = 1;
            lbl_borrow.Text = "Manage Books";
            // 
            // input_title
            // 
            input_title.Location = new Point(3, 56);
            input_title.Name = "input_title";
            input_title.Size = new Size(134, 23);
            input_title.TabIndex = 1;
            // 
            // input_author
            // 
            input_author.Location = new Point(2, 122);
            input_author.Name = "input_author";
            input_author.Size = new Size(134, 23);
            input_author.TabIndex = 2;
            // 
            // input_genre
            // 
            input_genre.Location = new Point(3, 188);
            input_genre.Name = "input_genre";
            input_genre.Size = new Size(134, 23);
            input_genre.TabIndex = 3;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Location = new Point(50, 83);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(29, 15);
            lbl_title.TabIndex = 4;
            lbl_title.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 149);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 5;
            label1.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 215);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "Genre";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.MistyRose;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.Location = new Point(289, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(417, 287);
            dataGridView1.TabIndex = 7;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.PaleGreen;
            btn_add.Location = new Point(30, 254);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 63);
            btn_add.TabIndex = 8;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.PaleTurquoise;
            btn_update.Location = new Point(208, 50);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 41);
            btn_update.TabIndex = 9;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_remove
            // 
            btn_remove.BackColor = Color.Crimson;
            btn_remove.Location = new Point(208, 104);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(75, 41);
            btn_remove.TabIndex = 10;
            btn_remove.Text = "Remove";
            btn_remove.UseVisualStyleBackColor = false;
            btn_remove.Click += btn_remove_Click;
            // 
            // btn_refresh
            // 
            btn_refresh.BackColor = Color.MistyRose;
            btn_refresh.Location = new Point(208, 159);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(75, 41);
            btn_refresh.TabIndex = 11;
            btn_refresh.Text = "Refresh List";
            btn_refresh.UseVisualStyleBackColor = false;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // ManageBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_refresh);
            Controls.Add(btn_remove);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_title);
            Controls.Add(input_genre);
            Controls.Add(input_author);
            Controls.Add(input_title);
            Controls.Add(panel1);
            Name = "ManageBooks";
            Size = new Size(706, 337);
            Load += ManageBooks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lbl_borrow;
        private TextBox input_title;
        private TextBox input_author;
        private TextBox input_genre;
        private Label lbl_title;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Button btn_add;
        private Button btn_update;
        private Button btn_remove;
        private Button btn_refresh;
    }
}
