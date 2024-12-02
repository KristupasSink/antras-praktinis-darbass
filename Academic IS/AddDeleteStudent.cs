using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Edukacija
{
    public partial class AddDeleteStudent : Form
    {
        public AddDeleteStudent()
        {
            InitializeComponent();
        }

        // DataTable to hold data for DataGridView
        DataTable table = new DataTable("table");

        // SQL Connection
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GLK4IKI\SQLEXPRESS;Initial Catalog=Edukacija;Integrated Security=SSPI");

        private void AddDeleteStudent_Load(object sender, EventArgs e)
        {
            // Add columns to the DataTable for DataGridView
            table.Columns.Add("studentID", typeof(string));
            table.Columns.Add("username", typeof(string));
            table.Columns.Add("password", typeof(string));
            table.Columns.Add("Role", typeof(string));
            table.Columns.Add("subject", typeof(string));
            table.Columns.Add("grupes", typeof(string));

            dataGridView1.DataSource = table;

            // Load existing data from the database into the DataGridView
            LoadDataFromDatabase();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddStudentData_btn_Click(object sender, EventArgs e)
        {
            try
            {
                
                conn.Open();

                
                string query = "INSERT INTO AddDeleteStudent (studentID, username, password, Role, subject, grupes) " +
                               "VALUES (@StudentID, @Username, @Password, @Role, @Subject, @Grupes)";

                
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@StudentID", DataStudentID_txt.Text);
                cmd.Parameters.AddWithValue("@Username", DataUsername_txt.Text);
                cmd.Parameters.AddWithValue("@Password", DataPassword_txt.Text);
                cmd.Parameters.AddWithValue("@Role", DataRole_txt.Text);
                cmd.Parameters.AddWithValue("@Subject", DataSubject_txt.Text);
                cmd.Parameters.AddWithValue("@Grupes", DataGroup_txt.Text);

                // Execute the query
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    
                    MessageBox.Show("New student added successfully to the database!");

                    
                    table.Rows.Add(DataStudentID_txt.Text, DataUsername_txt.Text, DataPassword_txt.Text, DataRole_txt.Text, DataSubject_txt.Text, DataGroup_txt.Text);
                }
                else
                {
                    MessageBox.Show("Failed to add new student.");
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                
                conn.Close();
            }
        }

        private void LoadDataFromDatabase()
        {
            try
            {
                // Open SQL connection
                conn.Open();

                // SQL query to fetch data
                string query = "SELECT studentID, username, password, Role, subject, grupes FROM AddDeleteStudent";

                // Create a SqlDataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                // Clear the existing data in the DataTable
                table.Clear();

                // Fill the DataTable with the database data
                adapter.Fill(table);

                // Bind the updated DataTable to the DataGridView
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
            finally
            {
                // Close SQL connection
                conn.Close();
            }
        }

        private void DeleteStudentData_btn_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the studentID from the selected row using its index (instead of column name)
                string selectedStudentID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(); // Use index (0 is the studentID column index)

                try
                {
                    // Open the SQL connection
                    conn.Open();

                    // SQL query to delete the student
                    string query = "DELETE FROM AddDeleteStudent WHERE studentID = @StudentID";

                    // Create a SQL command
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Add parameter to avoid SQL injection
                    cmd.Parameters.AddWithValue("@StudentID", selectedStudentID);

                    // Execute the command
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Remove the row from the DataGridView
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                        // Show success message
                        MessageBox.Show("Student deleted successfully!");
                    }
                    else
                    {
                        // Inform the user if no rows were affected
                        MessageBox.Show("Failed to delete student. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    // Close the SQL connection
                    conn.Close();
                }
            }
            else
            {
                // Inform the user if no row is selected
                MessageBox.Show("Please select a student to delete.");
            }
        }

        private void ImportStudentData_btn_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();


        }
    }
}