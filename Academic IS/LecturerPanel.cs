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
    public partial class LecturerPanel : Form
    {
        public LecturerPanel()
        {
            InitializeComponent();
        }

        private void LecturerPanel_Load(object sender, EventArgs e)
        {
            // NOTHING
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LecturerPanel panel = new LecturerPanel();
            panel.Show();
            this.Hide();
        }

        private void GRADE_BTN_Click(object sender, EventArgs e)
        {
            AddUpdateStudentGrade addUpdateStudentGrade = new AddUpdateStudentGrade();
            addUpdateStudentGrade.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignOut_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }
    }
}
