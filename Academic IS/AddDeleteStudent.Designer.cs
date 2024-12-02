namespace Edukacija
{
    partial class AddDeleteStudent
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addDeleteStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edukacijaDataSet = new Edukacija.EdukacijaDataSet();
            this.exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataGroup_txt = new System.Windows.Forms.ComboBox();
            this.DataSubject_txt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ImportStudentData_btn = new System.Windows.Forms.Button();
            this.DeleteStudentData_btn = new System.Windows.Forms.Button();
            this.AddStudentData_btn = new System.Windows.Forms.Button();
            this.DataRole_txt = new System.Windows.Forms.ComboBox();
            this.DataPassword_txt = new System.Windows.Forms.TextBox();
            this.DataUsername_txt = new System.Windows.Forms.TextBox();
            this.DataStudentID_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addDeleteStudentTableAdapter = new Edukacija.EdukacijaDataSetTableAdapters.AddDeleteStudentTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDeleteStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edukacijaDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(27, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 282);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.grupesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.addDeleteStudentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(880, 206);
            this.dataGridView1.TabIndex = 4;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "studentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "studentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            // 
            // grupesDataGridViewTextBoxColumn
            // 
            this.grupesDataGridViewTextBoxColumn.DataPropertyName = "grupes";
            this.grupesDataGridViewTextBoxColumn.HeaderText = "grupes";
            this.grupesDataGridViewTextBoxColumn.Name = "grupesDataGridViewTextBoxColumn";
            // 
            // addDeleteStudentBindingSource
            // 
            this.addDeleteStudentBindingSource.DataMember = "AddDeleteStudent";
            this.addDeleteStudentBindingSource.DataSource = this.edukacijaDataSet;
            // 
            // edukacijaDataSet
            // 
            this.edukacijaDataSet.DataSetName = "EdukacijaDataSet";
            this.edukacijaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(903, -8);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(26, 29);
            this.exit.TabIndex = 3;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student\'s Data";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.DataGroup_txt);
            this.panel2.Controls.Add(this.DataSubject_txt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.ImportStudentData_btn);
            this.panel2.Controls.Add(this.DeleteStudentData_btn);
            this.panel2.Controls.Add(this.AddStudentData_btn);
            this.panel2.Controls.Add(this.DataRole_txt);
            this.panel2.Controls.Add(this.DataPassword_txt);
            this.panel2.Controls.Add(this.DataUsername_txt);
            this.panel2.Controls.Add(this.DataStudentID_txt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(27, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 210);
            this.panel2.TabIndex = 2;
            // 
            // DataGroup_txt
            // 
            this.DataGroup_txt.FormattingEnabled = true;
            this.DataGroup_txt.Items.AddRange(new object[] {
            "PI23A",
            "PI23B",
            "IS23A",
            "IS23B",
            "EI23A",
            "EI23B",
            "KI23A",
            "KI23B"});
            this.DataGroup_txt.Location = new System.Drawing.Point(392, 67);
            this.DataGroup_txt.Name = "DataGroup_txt";
            this.DataGroup_txt.Size = new System.Drawing.Size(130, 21);
            this.DataGroup_txt.TabIndex = 14;
            // 
            // DataSubject_txt
            // 
            this.DataSubject_txt.FormattingEnabled = true;
            this.DataSubject_txt.Items.AddRange(new object[] {
            "Program systems",
            "Electronics engineering",
            "Information systems",
            "Computer engineering"});
            this.DataSubject_txt.Location = new System.Drawing.Point(392, 26);
            this.DataSubject_txt.Name = "DataSubject_txt";
            this.DataSubject_txt.Size = new System.Drawing.Size(130, 21);
            this.DataSubject_txt.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(319, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Group:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(319, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Subject:";
            // 
            // ImportStudentData_btn
            // 
            this.ImportStudentData_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.ImportStudentData_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.ImportStudentData_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
            this.ImportStudentData_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportStudentData_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportStudentData_btn.ForeColor = System.Drawing.Color.White;
            this.ImportStudentData_btn.Location = new System.Drawing.Point(616, 153);
            this.ImportStudentData_btn.Name = "ImportStudentData_btn";
            this.ImportStudentData_btn.Size = new System.Drawing.Size(80, 40);
            this.ImportStudentData_btn.TabIndex = 10;
            this.ImportStudentData_btn.Text = "BACK";
            this.ImportStudentData_btn.UseVisualStyleBackColor = false;
            this.ImportStudentData_btn.Click += new System.EventHandler(this.ImportStudentData_btn_Click);
            // 
            // DeleteStudentData_btn
            // 
            this.DeleteStudentData_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.DeleteStudentData_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.DeleteStudentData_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
            this.DeleteStudentData_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteStudentData_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteStudentData_btn.ForeColor = System.Drawing.Color.White;
            this.DeleteStudentData_btn.Location = new System.Drawing.Point(820, 153);
            this.DeleteStudentData_btn.Name = "DeleteStudentData_btn";
            this.DeleteStudentData_btn.Size = new System.Drawing.Size(80, 40);
            this.DeleteStudentData_btn.TabIndex = 9;
            this.DeleteStudentData_btn.Text = "DELETE";
            this.DeleteStudentData_btn.UseVisualStyleBackColor = false;
            this.DeleteStudentData_btn.Click += new System.EventHandler(this.DeleteStudentData_btn_Click);
            // 
            // AddStudentData_btn
            // 
            this.AddStudentData_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.AddStudentData_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.AddStudentData_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
            this.AddStudentData_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudentData_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudentData_btn.ForeColor = System.Drawing.Color.White;
            this.AddStudentData_btn.Location = new System.Drawing.Point(718, 153);
            this.AddStudentData_btn.Name = "AddStudentData_btn";
            this.AddStudentData_btn.Size = new System.Drawing.Size(80, 40);
            this.AddStudentData_btn.TabIndex = 8;
            this.AddStudentData_btn.Text = "ADD";
            this.AddStudentData_btn.UseVisualStyleBackColor = false;
            this.AddStudentData_btn.Click += new System.EventHandler(this.AddStudentData_btn_Click);
            // 
            // DataRole_txt
            // 
            this.DataRole_txt.FormattingEnabled = true;
            this.DataRole_txt.Items.AddRange(new object[] {
            "admin",
            "lecturer",
            "student"});
            this.DataRole_txt.Location = new System.Drawing.Point(119, 150);
            this.DataRole_txt.Name = "DataRole_txt";
            this.DataRole_txt.Size = new System.Drawing.Size(130, 21);
            this.DataRole_txt.TabIndex = 7;
            // 
            // DataPassword_txt
            // 
            this.DataPassword_txt.Location = new System.Drawing.Point(119, 110);
            this.DataPassword_txt.Multiline = true;
            this.DataPassword_txt.Name = "DataPassword_txt";
            this.DataPassword_txt.Size = new System.Drawing.Size(130, 22);
            this.DataPassword_txt.TabIndex = 6;
            // 
            // DataUsername_txt
            // 
            this.DataUsername_txt.Location = new System.Drawing.Point(119, 67);
            this.DataUsername_txt.Multiline = true;
            this.DataUsername_txt.Name = "DataUsername_txt";
            this.DataUsername_txt.Size = new System.Drawing.Size(130, 22);
            this.DataUsername_txt.TabIndex = 5;
            // 
            // DataStudentID_txt
            // 
            this.DataStudentID_txt.Location = new System.Drawing.Point(119, 25);
            this.DataStudentID_txt.Multiline = true;
            this.DataStudentID_txt.Name = "DataStudentID_txt";
            this.DataStudentID_txt.Size = new System.Drawing.Size(130, 22);
            this.DataStudentID_txt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Role:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student ID:";
            // 
            // addDeleteStudentTableAdapter
            // 
            this.addDeleteStudentTableAdapter.ClearBeforeFill = true;
            // 
            // AddDeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDeleteStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddDeleteStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDeleteStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edukacijaDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox DataGroup_txt;
        private System.Windows.Forms.ComboBox DataSubject_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ImportStudentData_btn;
        private System.Windows.Forms.Button DeleteStudentData_btn;
        private System.Windows.Forms.Button AddStudentData_btn;
        private System.Windows.Forms.ComboBox DataRole_txt;
        private System.Windows.Forms.TextBox DataPassword_txt;
        private System.Windows.Forms.TextBox DataUsername_txt;
        private System.Windows.Forms.TextBox DataStudentID_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EdukacijaDataSet edukacijaDataSet;
        private System.Windows.Forms.BindingSource addDeleteStudentBindingSource;
        private EdukacijaDataSetTableAdapters.AddDeleteStudentTableAdapter addDeleteStudentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupesDataGridViewTextBoxColumn;
    }
}
