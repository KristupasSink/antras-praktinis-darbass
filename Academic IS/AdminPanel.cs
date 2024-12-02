using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edukacija
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignOut_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void AddDeleteLecturer_btn_Click(object sender, EventArgs e)
        {
            AddDeleteLecturer addDeleteLecturer = new AddDeleteLecturer();
            addDeleteLecturer.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            AddDeleteStudent addDeleteStudent = new AddDeleteStudent();
            addDeleteStudent.Show();
            this.Hide();
        }

        private void GRADE_BTN_Click(object sender, EventArgs e)
        {
            AddUpdateStudentGrade addUpdateStudentGrade = new AddUpdateStudentGrade();
            addUpdateStudentGrade.Show();
            this.Hide();
        }
    }
}
