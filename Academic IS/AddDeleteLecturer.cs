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
    public partial class AddDeleteLecturer : Form
    {

        public AddDeleteLecturer()
        {
            InitializeComponent();
        }


        // DataTable to hold data for DataGridView
        DataTable table = new DataTable("table");

        // SQL Connection
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GLK4IKI\SQLEXPRESS;Initial Catalog=Edukacija;Integrated Security=SSPI");


        private void AddDeleteLecturer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'edukacijaDataSet.AddDeleteLecturer' table. You can move, or remove it, as needed.
            this.addDeleteLecturerTableAdapter.Fill(this.edukacijaDataSet.AddDeleteLecturer);
            // Add columns to the DataTable for DataGridView
            table.Columns.Add("lecturerID", typeof(string));
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

        private void AddLecturerData_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the SQL connection
                conn.Open();

                // SQL Insert query
                string query = "INSERT INTO AddDeleteLecturer (lecturerID, username, password, Role, subject, grupes) " +
                               "VALUES (@LecturerID, @Username, @Password, @Role, @Subject, @Grupes)";

                // Create SQL command
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@LecturerID", DataLecturerID_txt.Text);
                cmd.Parameters.AddWithValue("@Username", DataUsername_txt.Text);
                cmd.Parameters.AddWithValue("@Password", DataPassword_txt.Text);
                cmd.Parameters.AddWithValue("@Role", DataRole_comb.Text);
                cmd.Parameters.AddWithValue("@Subject", DataSubject_comb.Text);
                cmd.Parameters.AddWithValue("@Grupes", DataGroup_comb.Text);

                // Execute the query
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Inform the user
                    MessageBox.Show("New lecturer added successfully to the database!");

                    // Update the local DataTable (DataGridView)
                    table.Rows.Add(DataLecturerID_txt.Text, DataUsername_txt.Text, DataPassword_txt.Text, DataRole_comb.Text, DataSubject_comb.Text, DataGroup_comb.Text);
                }
                else
                {
                    MessageBox.Show("Failed to add new lecturer.");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., connection errors)
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                // Close the SQL connection
                conn.Close();
            }
        }

        private void LoadDataFromDatabase()
        {
            try
            {
                
                conn.Open();

                
                string query = "SELECT lecturerID, username, password, Role, subject, grupes FROM AddDeleteLecturer";

                // Create a SqlDataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                // Clear DataTable
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

        private void DeleteLecturerData_btn_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the lecturerID from the selected row using its index (instead of column name)
                string selectedLecturerID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(); // Use index (0 is the lecturerID column)

                try
                {
                    // Open the SQL connection
                    conn.Open();

                    
                    string query = "DELETE FROM AddDeleteLecturer WHERE lecturerID = @LecturerID";

                    
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Add parameter to avoid SQL injection
                    cmd.Parameters.AddWithValue("@LecturerID", selectedLecturerID);

                    // Execute the command
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                        
                        MessageBox.Show("Lecturer deleted successfully!");
                    }
                    else
                    {
                        
                        MessageBox.Show("Failed to delete lecturer. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    
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
                
                MessageBox.Show("Please select a lecturer to delete.");
            }
        }

        private void BackLecturerData_btn_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }

        
    }
}
