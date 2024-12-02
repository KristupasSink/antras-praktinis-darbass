namespace Edukacija
{
    partial class AddUpdateStudentGrade
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lecturergrade_txt = new System.Windows.Forms.ComboBox();
            this.addDeleteLecturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edukacijaDataSet = new Edukacija.EdukacijaDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.Usernamegrade_txt = new System.Windows.Forms.ComboBox();
            this.addDeleteStudentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.StudentIDgrade_txt = new System.Windows.Forms.ComboBox();
            this.addDeleteStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_grade_back_btn = new System.Windows.Forms.Button();
            this.Grade_txt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Groupgrade_txt = new System.Windows.Forms.ComboBox();
            this.addDeleteStudentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Subjectgrade_txt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UpdateStudentGrade_btn = new System.Windows.Forms.Button();
            this.AddStudentGrade_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addUpdateGradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.addDeleteStudentTableAdapter = new Edukacija.EdukacijaDataSetTableAdapters.AddDeleteStudentTableAdapter();
            this.addUpdateGradeTableAdapter = new Edukacija.EdukacijaDataSetTableAdapters.AddUpdateGradeTableAdapter();
            this.addDeleteLecturerTableAdapter = new Edukacija.EdukacijaDataSetTableAdapters.AddDeleteLecturerTableAdapter();
            this.addDeleteStudentBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addDeleteLecturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edukacijaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDeleteStudentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDeleteStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDeleteStudentBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addUpdateGradeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDeleteStudentBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.Lecturergrade_txt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Usernamegrade_txt);
            this.panel2.Controls.Add(this.StudentIDgrade_txt);
            this.panel2.Controls.Add(this.student_grade_back_btn);
            this.panel2.Controls.Add(this.Grade_txt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Groupgrade_txt);
            this.panel2.Controls.Add(this.Subjectgrade_txt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.UpdateStudentGrade_btn);
            this.panel2.Controls.Add(this.AddStudentGrade_btn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(14, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 226);
            this.panel2.TabIndex = 3;
            // 
            // Lecturergrade_txt
            // 
            this.Lecturergrade_txt.DataSource = this.addDeleteLecturerBindingSource;
            this.Lecturergrade_txt.DisplayMember = "username";
            this.Lecturergrade_txt.FormattingEnabled = true;
            this.Lecturergrade_txt.Location = new System.Drawing.Point(392, 116);
            this.Lecturergrade_txt.Name = "Lecturergrade_txt";
            this.Lecturergrade_txt.Size = new System.Drawing.Size(130, 21);
            this.Lecturergrade_txt.TabIndex = 21;
            this.Lecturergrade_txt.ValueMember = "username";
            // 
            // addDeleteLecturerBindingSource
            // 
            this.addDeleteLecturerBindingSource.DataMember = "AddDeleteLecturer";
            this.addDeleteLecturerBindingSource.DataSource = this.edukacijaDataSet;
            // 
            // edukacijaDataSet
            // 
            this.edukacijaDataSet.DataSetName = "EdukacijaDataSet";
            this.edukacijaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(317, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Lecturer:";
            // 
            // Usernamegrade_txt
            // 
            this.Usernamegrade_txt.DataSource = this.addDeleteStudentBindingSource2;
            this.Usernamegrade_txt.DisplayMember = "username";
            this.Usernamegrade_txt.FormattingEnabled = true;
            this.Usernamegrade_txt.Location = new System.Drawing.Point(119, 72);
            this.Usernamegrade_txt.Name = "Usernamegrade_txt";
            this.Usernamegrade_txt.Size = new System.Drawing.Size(130, 21);
            this.Usernamegrade_txt.TabIndex = 19;
            this.Usernamegrade_txt.ValueMember = "username";
            // 
            // addDeleteStudentBindingSource2
            // 
            this.addDeleteStudentBindingSource2.DataMember = "AddDeleteStudent";
            this.addDeleteStudentBindingSource2.DataSource = this.edukacijaDataSet;
            // 
            // StudentIDgrade_txt
            // 
            this.StudentIDgrade_txt.DataSource = this.addDeleteStudentBindingSource;
            this.StudentIDgrade_txt.DisplayMember = "studentID";
            this.StudentIDgrade_txt.FormattingEnabled = true;
            this.StudentIDgrade_txt.Location = new System.Drawing.Point(119, 26);
            this.StudentIDgrade_txt.Name = "StudentIDgrade_txt";
            this.StudentIDgrade_txt.Size = new System.Drawing.Size(130, 21);
            this.StudentIDgrade_txt.TabIndex = 18;
            this.StudentIDgrade_txt.ValueMember = "studentID";
            // 
            // addDeleteStudentBindingSource
            // 
            this.addDeleteStudentBindingSource.DataMember = "AddDeleteStudent";
            this.addDeleteStudentBindingSource.DataSource = this.edukacijaDataSet;
            // 
            // student_grade_back_btn
            // 
            this.student_grade_back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.student_grade_back_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.student_grade_back_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
            this.student_grade_back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_grade_back_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_grade_back_btn.ForeColor = System.Drawing.Color.White;
            this.student_grade_back_btn.Location = new System.Drawing.Point(617, 157);
            this.student_grade_back_btn.Name = "student_grade_back_btn";
            this.student_grade_back_btn.Size = new System.Drawing.Size(80, 40);
            this.student_grade_back_btn.TabIndex = 17;
            this.student_grade_back_btn.Text = "BACK";
            this.student_grade_back_btn.UseVisualStyleBackColor = false;
            this.student_grade_back_btn.Click += new System.EventHandler(this.student_grade_back_btn_Click);
            // 
            // Grade_txt
            // 
            this.Grade_txt.FormattingEnabled = true;
            this.Grade_txt.Items.AddRange(new object[] {
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.Grade_txt.Location = new System.Drawing.Point(392, 72);
            this.Grade_txt.Name = "Grade_txt";
            this.Grade_txt.Size = new System.Drawing.Size(130, 21);
            this.Grade_txt.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Grade:";
            // 
            // Groupgrade_txt
            // 
            this.Groupgrade_txt.DataSource = this.addDeleteStudentBindingSource1;
            this.Groupgrade_txt.DisplayMember = "grupes";
            this.Groupgrade_txt.FormattingEnabled = true;
            this.Groupgrade_txt.Location = new System.Drawing.Point(392, 30);
            this.Groupgrade_txt.Name = "Groupgrade_txt";
            this.Groupgrade_txt.Size = new System.Drawing.Size(130, 21);
            this.Groupgrade_txt.TabIndex = 14;
            this.Groupgrade_txt.ValueMember = "grupes";
            // 
            // addDeleteStudentBindingSource1
            // 
            this.addDeleteStudentBindingSource1.DataMember = "AddDeleteStudent";
            this.addDeleteStudentBindingSource1.DataSource = this.edukacijaDataSet;
            // 
            // Subjectgrade_txt
            // 
            this.Subjectgrade_txt.DataSource = this.addDeleteStudentBindingSource3;
            this.Subjectgrade_txt.DisplayMember = "subject";
            this.Subjectgrade_txt.FormattingEnabled = true;
            this.Subjectgrade_txt.Location = new System.Drawing.Point(119, 114);
            this.Subjectgrade_txt.Name = "Subjectgrade_txt";
            this.Subjectgrade_txt.Size = new System.Drawing.Size(130, 21);
            this.Subjectgrade_txt.TabIndex = 13;
            this.Subjectgrade_txt.ValueMember = "subject";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(317, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Group:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Subject:";
            // 
            // UpdateStudentGrade_btn
            // 
            this.UpdateStudentGrade_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.UpdateStudentGrade_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.UpdateStudentGrade_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
            this.UpdateStudentGrade_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateStudentGrade_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateStudentGrade_btn.ForeColor = System.Drawing.Color.White;
            this.UpdateStudentGrade_btn.Location = new System.Drawing.Point(824, 157);
            this.UpdateStudentGrade_btn.Name = "UpdateStudentGrade_btn";
            this.UpdateStudentGrade_btn.Size = new System.Drawing.Size(80, 40);
            this.UpdateStudentGrade_btn.TabIndex = 10;
            this.UpdateStudentGrade_btn.Text = "UPDATE";
            this.UpdateStudentGrade_btn.UseVisualStyleBackColor = false;
            this.UpdateStudentGrade_btn.Click += new System.EventHandler(this.UpdateStudentGrade_btn_Click);
            // 
            // AddStudentGrade_btn
            // 
            this.AddStudentGrade_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.AddStudentGrade_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.AddStudentGrade_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
            this.AddStudentGrade_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudentGrade_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudentGrade_btn.ForeColor = System.Drawing.Color.White;
            this.AddStudentGrade_btn.Location = new System.Drawing.Point(721, 157);
            this.AddStudentGrade_btn.Name = "AddStudentGrade_btn";
            this.AddStudentGrade_btn.Size = new System.Drawing.Size(80, 40);
            this.AddStudentGrade_btn.TabIndex = 8;
            this.AddStudentGrade_btn.Text = "ADD";
            this.AddStudentGrade_btn.UseVisualStyleBackColor = false;
            this.AddStudentGrade_btn.Click += new System.EventHandler(this.AddStudentGrade_btn_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 271);
            this.panel1.TabIndex = 2;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.White;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(900, -3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(26, 29);
            this.exit.TabIndex = 3;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.grupesDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.lecturerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.addUpdateGradeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(880, 206);
            this.dataGridView1.TabIndex = 1;
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
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "grade";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            // 
            // lecturerDataGridViewTextBoxColumn
            // 
            this.lecturerDataGridViewTextBoxColumn.DataPropertyName = "lecturer";
            this.lecturerDataGridViewTextBoxColumn.HeaderText = "lecturer";
            this.lecturerDataGridViewTextBoxColumn.Name = "lecturerDataGridViewTextBoxColumn";
            // 
            // addUpdateGradeBindingSource
            // 
            this.addUpdateGradeBindingSource.DataMember = "AddUpdateGrade";
            this.addUpdateGradeBindingSource.DataSource = this.edukacijaDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student\'s Grades";
            // 
            // addDeleteStudentTableAdapter
            // 
            this.addDeleteStudentTableAdapter.ClearBeforeFill = true;
            // 
            // addUpdateGradeTableAdapter
            // 
            this.addUpdateGradeTableAdapter.ClearBeforeFill = true;
            // 
            // addDeleteLecturerTableAdapter
            // 
            this.addDeleteLecturerTableAdapter.ClearBeforeFill = true;
            // 
            // addDeleteStudentBindingSource3
            // 
            this.addDeleteStudentBindingSource3.DataMember = "AddDeleteStudent";
            this.addDeleteStudentBindingSource3.DataSource = this.edukacijaDataSet;
            // 
            // AddUpdateStudentGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 537);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUpdateStudentGrade";
            this.Text = "AddUpdateStudentGrade";
            this.Load += new System.EventHandler(this.AddUpdateStudentGrade_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addDeleteLecturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edukacijaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDeleteStudentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDeleteStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDeleteStudentBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addUpdateGradeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDeleteStudentBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox Groupgrade_txt;
        private System.Windows.Forms.ComboBox Subjectgrade_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button UpdateStudentGrade_btn;
        private System.Windows.Forms.Button AddStudentGrade_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Grade_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Button student_grade_back_btn;
        private System.Windows.Forms.ComboBox StudentIDgrade_txt;
        private EdukacijaDataSet edukacijaDataSet;
        private System.Windows.Forms.BindingSource addDeleteStudentBindingSource;
        private EdukacijaDataSetTableAdapters.AddDeleteStudentTableAdapter addDeleteStudentTableAdapter;
        private System.Windows.Forms.ComboBox Usernamegrade_txt;
        private System.Windows.Forms.BindingSource addDeleteStudentBindingSource2;
        private System.Windows.Forms.BindingSource addDeleteStudentBindingSource1;
        private System.Windows.Forms.BindingSource addUpdateGradeBindingSource;
        private EdukacijaDataSetTableAdapters.AddUpdateGradeTableAdapter addUpdateGradeTableAdapter;
        private System.Windows.Forms.ComboBox Lecturergrade_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource addDeleteLecturerBindingSource;
        private EdukacijaDataSetTableAdapters.AddDeleteLecturerTableAdapter addDeleteLecturerTableAdapter;
        private System.Windows.Forms.BindingSource addDeleteStudentBindingSource3;
    }
}