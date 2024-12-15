using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class BookList : UserControl
    {
        public BookList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            // Get the search term from the TextBox
            string searchTerm = input_search.Text.Trim();

            try
            {
                // Connect to the database
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    // Enhanced query to prioritize matches across multiple columns
                    string query = @"
                SELECT *, 
                       CASE 
                           WHEN title LIKE @exactMatch THEN 1 
                           WHEN author LIKE @exactMatch THEN 1 
                           WHEN genre LIKE @exactMatch THEN 1 
                           WHEN title LIKE @prefixMatch THEN 2 
                           WHEN author LIKE @prefixMatch THEN 2 
                           WHEN genre LIKE @prefixMatch THEN 2 
                           WHEN title LIKE @searchTerm THEN 3 
                           WHEN author LIKE @searchTerm THEN 3 
                           WHEN genre LIKE @searchTerm THEN 3 
                           ELSE 4 
                       END AS relevance
                FROM books 
                WHERE title LIKE @searchTerm 
                   OR author LIKE @searchTerm 
                   OR genre LIKE @searchTerm
                ORDER BY relevance ASC, title ASC";

                    // Use MySqlDataAdapter to fetch data
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn))
                    {
                        // Add parameters to the query
                        dataAdapter.SelectCommand.Parameters.AddWithValue("@exactMatch", searchTerm);
                        dataAdapter.SelectCommand.Parameters.AddWithValue("@prefixMatch", searchTerm + "%");
                        dataAdapter.SelectCommand.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                        // Fill a DataTable with the search results
                        System.Data.DataTable dataTable = new System.Data.DataTable();
                        dataAdapter.Fill(dataTable);

                        // Check if results were found
                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No results found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        // Bind the results to the DataGridView
                        dataGridView1.DataSource = dataTable;

                        // Hide the primary key column (bookId)
                        if (dataGridView1.Columns.Contains("bookId"))
                        {
                            dataGridView1.Columns["bookId"].Visible = false;
                        }

                        if (dataGridView1.Columns.Contains("relevance"))
                        {
                            dataGridView1.Columns["relevance"].Visible = false;
                        }

                        // Auto-size columns for better readability
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle errors
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BookList_Load(object sender, EventArgs e)
        {
            LoadBooksTable();
        }

        private void LoadBooksTable()
        {
            try
            {
                // Connect to the database
                MySqlConnection conn = DatabaseHelper.GetConnection();

                // Query to select all data from the books table
                string query = "SELECT * FROM books";

                // Use MySqlDataAdapter to fetch data
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
                System.Data.DataTable dataTable = new System.Data.DataTable();

                // Fill the DataTable with data from the database
                dataAdapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;

                if (dataGridView1.Columns.Contains("bookId"))
                {
                    dataGridView1.Columns["bookId"].Visible = false;
                }
                // Hide row headers
                dataGridView1.RowHeadersVisible = false;

                // Auto-size columns for better readability
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                // Handle errors
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
