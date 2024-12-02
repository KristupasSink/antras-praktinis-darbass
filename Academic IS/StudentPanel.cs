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

namespace Edukacija
{
    public partial class StudentPanel : Form
    {
        public StudentPanel()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GLK4IKI\SQLEXPRESS;Initial Catalog=Edukacija;Integrated Security=SSPI");

        private void SignOut_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void StudentPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'edukacijaDataSet.AddUpdateGrade' table. You can move, or remove it, as needed.
            this.addUpdateGradeTableAdapter.Fill(this.edukacijaDataSet.AddUpdateGrade);
            // TODO: This line of code loads data into the 'edukacijaDataSet.AddUpdateGrade' table. You can move, or remove it, as needed.
            this.addUpdateGradeTableAdapter.Fill(this.edukacijaDataSet.AddUpdateGrade);

        }
    }
}
