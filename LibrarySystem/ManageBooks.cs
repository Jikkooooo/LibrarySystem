using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class ManageBooks : UserControl
    {
        public ManageBooks()
        {
            InitializeComponent();
        }

        private void ManageBooks_Load(object sender, EventArgs e)
        {
            LoadBooksTable();

        }

        private void AddBook(string title, string author, string genre)
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    string query = "INSERT INTO books (title, author, genre) VALUES (@title, @author, @genre)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@author", author);
                        cmd.Parameters.AddWithValue("@genre", genre);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the book. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string title = input_title.Text.Trim();
            string author = input_author.Text.Trim();
            string genre = input_genre.Text.Trim();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(genre))
            {
                MessageBox.Show("Please enter all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AddBook(title, author, genre);
        }

        private void LoadBooksTable()
        {
            try
            {
                MySqlConnection conn = DatabaseHelper.GetConnection();

                string query = "SELECT * FROM books";

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
                System.Data.DataTable dataTable = new System.Data.DataTable();

                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                if (dataGridView1.Columns.Contains("bookId"))
                {
                    dataGridView1.Columns["bookId"].ReadOnly = true;
                }

                dataGridView1.RowHeadersVisible = false;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadBooksTable();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get the values from the selected row
                int bookId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["bookId"].Value); // Assuming "id" is the primary key column
                string title = dataGridView1.CurrentRow.Cells["title"].Value.ToString();
                string author = dataGridView1.CurrentRow.Cells["author"].Value.ToString();
                string genre = dataGridView1.CurrentRow.Cells["genre"].Value.ToString();

                // Update query
                string query = "UPDATE books SET title = @title, author = @author, genre = @genre WHERE bookId = @bookId";

                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@author", author);
                        cmd.Parameters.AddWithValue("@bookId", bookId);
                        cmd.Parameters.AddWithValue("@genre", genre);

                        // Execute the update
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Provide feedback to the user
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No changes were made.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                // Refresh the DataGridView
                LoadBooksTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Confirm deletion
                var confirmResult = MessageBox.Show("Are you sure you want to delete this record?",
                                                    "Confirm Delete",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.No)
                {
                    return;
                }

                // Get the primary key value (e.g., "id")
                int bookId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["bookId"].Value);

                // Delete query
                string query = "DELETE FROM books WHERE bookId = @bookId";

                // Execute the DELETE command
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@bookId", bookId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh the DataGridView
                            LoadBooksTable();
                        }
                        else
                        {
                            MessageBox.Show("Error: Record not found or already deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
