namespace LibrarySystem
{
    partial class Main
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
            TitleHolder = new Panel();
            label1 = new Label();
            ButtonNavPanel = new Panel();
            btn_logout = new Button();
            btn_manageBooks = new Button();
            btn_bookList = new Button();
            panel3 = new Panel();
            ControlFormsHolder = new Panel();
            bookList1 = new BookList();
            return1 = new Return();
            manageBooks1 = new ManageBooks();
            home1 = new Home();
            borrowLists1 = new BorrowLists();
            TitleHolder.SuspendLayout();
            ButtonNavPanel.SuspendLayout();
            ControlFormsHolder.SuspendLayout();
            SuspendLayout();
            // 
            // TitleHolder
            // 
            TitleHolder.BackColor = Color.Thistle;
            TitleHolder.BorderStyle = BorderStyle.FixedSingle;
            TitleHolder.Controls.Add(label1);
            TitleHolder.Dock = DockStyle.Top;
            TitleHolder.Location = new Point(0, 0);
            TitleHolder.Name = "TitleHolder";
            TitleHolder.Size = new Size(800, 95);
            TitleHolder.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(209, 24);
            label1.Name = "label1";
            label1.Size = new Size(415, 45);
            label1.TabIndex = 0;
            label1.Text = "Library Catalog Viewer";
            // 
            // ButtonNavPanel
            // 
            ButtonNavPanel.BorderStyle = BorderStyle.FixedSingle;
            ButtonNavPanel.Controls.Add(btn_logout);
            ButtonNavPanel.Controls.Add(btn_manageBooks);
            ButtonNavPanel.Controls.Add(btn_bookList);
            ButtonNavPanel.Dock = DockStyle.Left;
            ButtonNavPanel.Location = new Point(0, 95);
            ButtonNavPanel.Name = "ButtonNavPanel";
            ButtonNavPanel.Size = new Size(84, 337);
            ButtonNavPanel.TabIndex = 1;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.WhiteSmoke;
            btn_logout.Dock = DockStyle.Top;
            btn_logout.Location = new Point(0, 96);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(82, 48);
            btn_logout.TabIndex = 6;
            btn_logout.Text = "Log Out";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_manageBooks
            // 
            btn_manageBooks.BackColor = Color.WhiteSmoke;
            btn_manageBooks.Dock = DockStyle.Top;
            btn_manageBooks.Location = new Point(0, 48);
            btn_manageBooks.Name = "btn_manageBooks";
            btn_manageBooks.Size = new Size(82, 48);
            btn_manageBooks.TabIndex = 4;
            btn_manageBooks.Text = "Manage Books";
            btn_manageBooks.UseVisualStyleBackColor = false;
            btn_manageBooks.Click += btn_manageBooks_Click;
            // 
            // btn_bookList
            // 
            btn_bookList.BackColor = Color.WhiteSmoke;
            btn_bookList.Dock = DockStyle.Top;
            btn_bookList.Location = new Point(0, 0);
            btn_bookList.Name = "btn_bookList";
            btn_bookList.Size = new Size(82, 48);
            btn_bookList.TabIndex = 3;
            btn_bookList.Text = "Book Lists";
            btn_bookList.UseVisualStyleBackColor = false;
            btn_bookList.Click += btn_bookList_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Thistle;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(84, 95);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 337);
            panel3.TabIndex = 2;
            // 
            // ControlFormsHolder
            // 
            ControlFormsHolder.Controls.Add(bookList1);
            ControlFormsHolder.Controls.Add(return1);
            ControlFormsHolder.Controls.Add(manageBooks1);
            ControlFormsHolder.Controls.Add(home1);
            ControlFormsHolder.Controls.Add(borrowLists1);
            ControlFormsHolder.Dock = DockStyle.Fill;
            ControlFormsHolder.Location = new Point(94, 95);
            ControlFormsHolder.Name = "ControlFormsHolder";
            ControlFormsHolder.Size = new Size(706, 337);
            ControlFormsHolder.TabIndex = 3;
            // 
            // bookList1
            // 
            bookList1.BorderStyle = BorderStyle.FixedSingle;
            bookList1.Location = new Point(0, 0);
            bookList1.Name = "bookList1";
            bookList1.Size = new Size(706, 337);
            bookList1.TabIndex = 7;
            // 
            // return1
            // 
            return1.Location = new Point(0, 0);
            return1.Name = "return1";
            return1.Size = new Size(706, 337);
            return1.TabIndex = 4;
            // 
            // manageBooks1
            // 
            manageBooks1.Location = new Point(0, 0);
            manageBooks1.Name = "manageBooks1";
            manageBooks1.Size = new Size(706, 337);
            manageBooks1.TabIndex = 3;
            // 
            // home1
            // 
            home1.Location = new Point(0, 0);
            home1.Name = "home1";
            home1.Size = new Size(706, 337);
            home1.TabIndex = 2;
            // 
            // borrowLists1
            // 
            borrowLists1.Location = new Point(0, 0);
            borrowLists1.Name = "borrowLists1";
            borrowLists1.Size = new Size(706, 337);
            borrowLists1.TabIndex = 6;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 432);
            Controls.Add(ControlFormsHolder);
            Controls.Add(panel3);
            Controls.Add(ButtonNavPanel);
            Controls.Add(TitleHolder);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            TitleHolder.ResumeLayout(false);
            TitleHolder.PerformLayout();
            ButtonNavPanel.ResumeLayout(false);
            ControlFormsHolder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TitleHolder;
        private Panel ButtonNavPanel;
        private Button btn_logout;
        private Button btn_manageBooks;
        private Button btn_bookList;
        private Panel panel3;
        private Panel ControlFormsHolder;
        private BorrowLists borrow1;
        private Return return1;
        private ManageBooks manageBooks1;
        private Home home1;
        private BorrowLists borrowLists1;
        private BookList bookList1;
        private Label label1;
    }
}