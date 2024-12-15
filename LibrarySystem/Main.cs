using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibrarySystem.LoginForm;

namespace LibrarySystem
{
    public partial class Main : Form
    {
        private string userRole;
        public Main()
        {
            InitializeComponent();
            if (LoginForm.CurrentUser.Role == "administrator")
            {
                btn_manageBooks.Visible = true;
            }
            else
            {
                btn_manageBooks.Visible = false;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_bookList_Click(object sender, EventArgs e)
        {
            bookList1.BringToFront();
        }

        private void btn_manageBooks_Click(object sender, EventArgs e)
        {
            manageBooks1.BringToFront();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var loginForm = new LoginForm();
                loginForm.Show();

                this.Close();
            }
        }
    }

}
