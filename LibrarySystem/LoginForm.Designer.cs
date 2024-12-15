namespace LibrarySystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            input_user = new TextBox();
            input_pass = new TextBox();
            lbl_user = new Label();
            btn_login = new Button();
            lbl_pass = new Label();
            SuspendLayout();
            // 
            // input_user
            // 
            input_user.Location = new Point(111, 112);
            input_user.Name = "input_user";
            input_user.PlaceholderText = "Username";
            input_user.Size = new Size(143, 23);
            input_user.TabIndex = 0;
            // 
            // input_pass
            // 
            input_pass.Location = new Point(111, 158);
            input_pass.Name = "input_pass";
            input_pass.PlaceholderText = "**************";
            input_pass.Size = new Size(143, 23);
            input_pass.TabIndex = 1;
            input_pass.UseSystemPasswordChar = true;
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.Location = new Point(39, 115);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(66, 15);
            lbl_user.TabIndex = 2;
            lbl_user.Text = "Username :";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(123, 228);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 23);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // lbl_pass
            // 
            lbl_pass.AutoSize = true;
            lbl_pass.Location = new Point(42, 161);
            lbl_pass.Name = "lbl_pass";
            lbl_pass.Size = new Size(63, 15);
            lbl_pass.TabIndex = 6;
            lbl_pass.Text = "Password :";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 348);
            Controls.Add(lbl_pass);
            Controls.Add(btn_login);
            Controls.Add(lbl_user);
            Controls.Add(input_pass);
            Controls.Add(input_user);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox input_user;
        private TextBox input_pass;
        private Label lbl_user;
        private Button btn_login;
        private Label lbl_pass;
    }
}
