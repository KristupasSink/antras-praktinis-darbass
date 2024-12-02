namespace Edukacija
{
    partial class AddDeleteLecturer
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
            this.lecturerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addDeleteLecturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edukacijaDataSet = new Edukacija.EdukacijaDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataGroup_comb = new System.Windows.Forms.ComboBox();
            this.DataSubject_comb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BackLecturerData_btn = new System.Windows.Forms.Button();
            this.DeleteLecturerData_btn = new System.Windows.Forms.Button();
            this.AddLecturerData_btn = new System.Windows.Forms.Button();
            this.DataRole_comb = new System.Windows.Forms.ComboBox();
            this.DataPassword_txt = new System.Windows.Forms.TextBox();
            this.DataUsername_txt = new System.Windows.Forms.TextBox();
            this.DataLecturerID_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.addDeleteLecturerTableAdapter = new Edukacija.EdukacijaDataSetTableAdapters.AddDeleteLecturerTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDeleteLecturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edukacijaDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(27, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 282);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lecturerIDDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.grupesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.addDeleteLecturerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(880, 206);
            this.dataGridView1.TabIndex = 1;
            // 
            // lecturerIDDataGridViewTextBoxColumn
            // 
            this.lecturerIDDataGridViewTextBoxColumn.DataPropertyName = "lecturerID";
            this.lecturerIDDataGridViewTextBoxColumn.HeaderText = "lecturerID";
            this.lecturerIDDataGridViewTextBoxColumn.Name = "lecturerIDDataGridViewTextBoxColumn";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lecturer\'s Data";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.DataGroup_comb);
            this.panel2.Controls.Add(this.DataSubject_comb);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.BackLecturerData_btn);
            this.panel2.Controls.Add(this.DeleteLecturerData_btn);
            this.panel2.Controls.Add(this.AddLecturerData_btn);
            this.panel2.Controls.Add(this.DataRole_comb);
            this.panel2.Controls.Add(this.DataPassword_txt);
            this.panel2.Controls.Add(this.DataUsername_txt);
            this.panel2.Controls.Add(this.DataLecturerID_txt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(27, 330);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 210);
            this.panel2.TabIndex = 1;
            // 
            // DataGroup_comb
            // 
            this.DataGroup_comb.FormattingEnabled = true;
            this.DataGroup_comb.Items.AddRange(new object[] {
            "PI23A",
            "PI23B",
            "IS23A",
            "IS23B",
            "EI23A",
            "EI23B",
            "KI23A",
            "KI23B"});
            this.DataGroup_comb.Location = new System.Drawing.Point(392, 67);
            this.DataGroup_comb.Name = "DataGroup_comb";
            this.DataGroup_comb.Size = new System.Drawing.Size(130, 21);
            this.DataGroup_comb.TabIndex = 14;
            // 
            // DataSubject_comb
            // 
            this.DataSubject_comb.FormattingEnabled = true;
            this.DataSubject_comb.Items.AddRange(new object[] {
            "Program systems",
            "Electronics engineering",
            "Information systems",
            "Computer engineering"});
            this.DataSubject_comb.Location = new System.Drawing.Point(392, 26);
            this.DataSubject_comb.Name = "DataSubject_comb";
            this.DataSubject_comb.Size = new System.Drawing.Size(130, 21);
            this.DataSubject_comb.TabIndex = 13;
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
            // BackLecturerData_btn
            // 
            this.BackLecturerData_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.BackLecturerData_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.BackLecturerData_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
            this.BackLecturerData_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackLecturerData_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackLecturerData_btn.ForeColor = System.Drawing.Color.White;
            this.BackLecturerData_btn.Location = new System.Drawing.Point(615, 153);
            this.BackLecturerData_btn.Name = "BackLecturerData_btn";
            this.BackLecturerData_btn.Size = new System.Drawing.Size(80, 40);
            this.BackLecturerData_btn.TabIndex = 10;
            this.BackLecturerData_btn.Text = "BACK";
            this.BackLecturerData_btn.UseVisualStyleBackColor = false;
            this.BackLecturerData_btn.Click += new System.EventHandler(this.BackLecturerData_btn_Click);
            // 
            // DeleteLecturerData_btn
            // 
            this.DeleteLecturerData_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.DeleteLecturerData_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.DeleteLecturerData_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
            this.DeleteLecturerData_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteLecturerData_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteLecturerData_btn.ForeColor = System.Drawing.Color.White;
            this.DeleteLecturerData_btn.Location = new System.Drawing.Point(817, 153);
            this.DeleteLecturerData_btn.Name = "DeleteLecturerData_btn";
            this.DeleteLecturerData_btn.Size = new System.Drawing.Size(80, 40);
            this.DeleteLecturerData_btn.TabIndex = 9;
            this.DeleteLecturerData_btn.Text = "DELETE";
            this.DeleteLecturerData_btn.UseVisualStyleBackColor = false;
            this.DeleteLecturerData_btn.Click += new System.EventHandler(this.DeleteLecturerData_btn_Click);
            // 
            // AddLecturerData_btn
            // 
            this.AddLecturerData_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.AddLecturerData_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.AddLecturerData_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
            this.AddLecturerData_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddLecturerData_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLecturerData_btn.ForeColor = System.Drawing.Color.White;
            this.AddLecturerData_btn.Location = new System.Drawing.Point(715, 153);
            this.AddLecturerData_btn.Name = "AddLecturerData_btn";
            this.AddLecturerData_btn.Size = new System.Drawing.Size(80, 40);
            this.AddLecturerData_btn.TabIndex = 8;
            this.AddLecturerData_btn.Text = "ADD";
            this.AddLecturerData_btn.UseVisualStyleBackColor = false;
            this.AddLecturerData_btn.Click += new System.EventHandler(this.AddLecturerData_btn_Click);
            // 
            // DataRole_comb
            // 
            this.DataRole_comb.FormattingEnabled = true;
            this.DataRole_comb.Items.AddRange(new object[] {
            "admin",
            "lecturer",
            "student"});
            this.DataRole_comb.Location = new System.Drawing.Point(119, 150);
            this.DataRole_comb.Name = "DataRole_comb";
            this.DataRole_comb.Size = new System.Drawing.Size(130, 21);
            this.DataRole_comb.TabIndex = 7;
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
            // DataLecturerID_txt
            // 
            this.DataLecturerID_txt.Location = new System.Drawing.Point(119, 25);
            this.DataLecturerID_txt.Multiline = true;
            this.DataLecturerID_txt.Name = "DataLecturerID_txt";
            this.DataLecturerID_txt.Size = new System.Drawing.Size(130, 22);
            this.DataLecturerID_txt.TabIndex = 4;
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
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lecturer ID:";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.White;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(945, -7);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(26, 29);
            this.exit.TabIndex = 2;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // addDeleteLecturerTableAdapter
            // 
            this.addDeleteLecturerTableAdapter.ClearBeforeFill = true;
            // 
            // AddDeleteLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(968, 553);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDeleteLecturer";
            this.Load += new System.EventHandler(this.AddDeleteLecturer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDeleteLecturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edukacijaDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DataRole_comb;
        private System.Windows.Forms.TextBox DataPassword_txt;
        private System.Windows.Forms.TextBox DataUsername_txt;
        private System.Windows.Forms.TextBox DataLecturerID_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BackLecturerData_btn;
        private System.Windows.Forms.Button DeleteLecturerData_btn;
        private System.Windows.Forms.Button AddLecturerData_btn;
        private System.Windows.Forms.ComboBox DataGroup_comb;
        private System.Windows.Forms.ComboBox DataSubject_comb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label exit;
        private EdukacijaDataSet edukacijaDataSet;
        private System.Windows.Forms.BindingSource addDeleteLecturerBindingSource;
        private EdukacijaDataSetTableAdapters.AddDeleteLecturerTableAdapter addDeleteLecturerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupesDataGridViewTextBoxColumn;
    }
}
