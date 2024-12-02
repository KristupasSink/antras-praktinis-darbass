using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Edukacija.Login;

namespace Edukacija
{
    public partial class AddUpdateStudentGrade : Form
    {
        public AddUpdateStudentGrade()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable("table");

        // SQL Connection
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GLK4IKI\SQLEXPRESS;Initial Catalog=Edukacija;Integrated Security=SSPI");

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void student_grade_back_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the current user's role
                string role = CurrentUser.Role;

                if (string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("User role not found. Please log in again.");
                    this.Close();
                    return;
                }

                this.Hide(); // Hide the current form

                // Navigate to the appropriate panel based on the role
                switch (role)
                {
                    case "admin":
                        AdminPanel adminPanel = new AdminPanel();
                        adminPanel.Show();
                        break;

                    case "lecturer":
                        LecturerPanel lecturerPanel = new LecturerPanel();
                        lecturerPanel.Show();
                        break;

                    case "student":
                        StudentPanel studentPanel = new StudentPanel();
                        studentPanel.Show();
                        break;

                    default:
                        MessageBox.Show("Unknown role. Unable to navigate back.");
                        this.Show();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error navigating back: {ex.Message}");
            }
        }


        private void AddUpdateStudentGrade_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'edukacijaDataSet.AddDeleteLecturer' table. You can move, or remove it, as needed.
            this.addDeleteLecturerTableAdapter.Fill(this.edukacijaDataSet.AddDeleteLecturer);
            // TODO: This line of code loads data into the 'edukacijaDataSet.AddUpdateGrade' table. You can move, or remove it, as needed.
            this.addUpdateGradeTableAdapter.Fill(this.edukacijaDataSet.AddUpdateGrade);
            // TODO: This line of code loads data into the 'edukacijaDataSet.AddUpdateGrade' table. You can move, or remove it, as needed.
            this.addUpdateGradeTableAdapter.Fill(this.edukacijaDataSet.AddUpdateGrade);
            // TODO: This line of code loads data into the 'edukacijaDataSet.AddUpdateGrade' table. You can move, or remove it, as needed.
            this.addUpdateGradeTableAdapter.Fill(this.edukacijaDataSet.AddUpdateGrade);
            // TODO: This line of code loads data into the 'edukacijaDataSet.AddDeleteStudent' table. You can move, or remove it, as needed.
            this.addDeleteStudentTableAdapter.Fill(this.edukacijaDataSet.AddDeleteStudent);

            table.Columns.Add("studentID", typeof(string));
            table.Columns.Add("username", typeof(string));
            table.Columns.Add("subject", typeof(string));
            table.Columns.Add("grupes", typeof(string));
            table.Columns.Add("grade", typeof(string));
            table.Columns.Add("lecturer", typeof(string));

            dataGridView1.DataSource = table;

            LoadDataFromDatabase();
        }

        private void LoadDataFromDatabase()
        {
            try
            {
                // Open SQL connection
                conn.Open();

                
                string query = "SELECT studentID, username, subject, grupes, grade, lecturer FROM AddUpdateGrade";

                
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                
                table.Clear();

                
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
                
                conn.Close();
            }
        }

        private void AddStudentGrade_btn_Click(object sender, EventArgs e)
        {
            try
            {
                
                conn.Open();

                // SQL Insert query
                string query = "INSERT INTO AddUpdateGrade (studentID, username, subject, grupes, grade, lecturer) " +
                               "VALUES (@StudentID, @Username, @Subject, @Grupes, @Grade, @Lecturer)";

                // Create SQL command
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@StudentID", StudentIDgrade_txt.Text);
                cmd.Parameters.AddWithValue("@Username", Usernamegrade_txt.Text);
                cmd.Parameters.AddWithValue("@Subject", Subjectgrade_txt.Text);
                cmd.Parameters.AddWithValue("@Grupes", Groupgrade_txt.Text);
                cmd.Parameters.AddWithValue("@Grade", Grade_txt.Text);
                cmd.Parameters.AddWithValue("@Lecturer", Lecturergrade_txt.Text);

                // Execute the query
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    
                    MessageBox.Show("New grade has been added successfully to the database!");

                    // Update (DataGridView)
                    table.Rows.Add(StudentIDgrade_txt.Text, Usernamegrade_txt.Text, Subjectgrade_txt.Text, Groupgrade_txt.Text, Grade_txt.Text, Lecturergrade_txt);
                }
                else
                {
                    MessageBox.Show("Failed to add new grade.");
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

        private void UpdateStudentGrade_btn_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Fetch the student ID from the first cell or by column name
                string selectedStudentID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                if (string.IsNullOrEmpty(selectedStudentID))
                {
                    MessageBox.Show("Invalid student ID. Please select a valid row.");
                    return;
                }

                try
                {
                    
                    conn.Open();

                    // SQL Update query
                    string query = "UPDATE AddUpdateGrade SET username = @Username, subject = @Subject, grupes = @Grupes, grade = @Grade, lecturer = @Lecturer " +
                                   "WHERE studentID = @StudentID";

                    
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@StudentID", selectedStudentID);
                    cmd.Parameters.AddWithValue("@Username", Usernamegrade_txt.Text);
                    cmd.Parameters.AddWithValue("@Subject", Subjectgrade_txt.Text);
                    cmd.Parameters.AddWithValue("@Grupes", Groupgrade_txt.Text);
                    cmd.Parameters.AddWithValue("@Grade", Grade_txt.Text);
                    cmd.Parameters.AddWithValue("@Lecturer", Lecturergrade_txt.Text);

                    // Execute the query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Grade updated successfully!");

                        // Update the DataGridView with the new data using column indexes
                        DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                        selectedRow.Cells[1].Value = Usernamegrade_txt.Text;
                        selectedRow.Cells[2].Value = Subjectgrade_txt.Text;
                        selectedRow.Cells[3].Value = Groupgrade_txt.Text;
                        selectedRow.Cells[4].Value = Grade_txt.Text;
                    }
                    else
                    {
                        MessageBox.Show("Failed to update grade. Please try again.");
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
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        
    }
}
