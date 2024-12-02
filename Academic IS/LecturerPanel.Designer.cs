namespace Edukacija
{
    partial class LecturerPanel
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GRADE_BTN = new System.Windows.Forms.Button();
            this.SignOut_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(207, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(777, 504);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
            this.panel2.Controls.Add(this.GRADE_BTN);
            this.panel2.Controls.Add(this.SignOut_btn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 504);
            this.panel2.TabIndex = 4;
            // 
            // GRADE_BTN
            // 
            this.GRADE_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GRADE_BTN.FlatAppearance.BorderSize = 3;
            this.GRADE_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.GRADE_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.GRADE_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GRADE_BTN.Font = new System.Drawing.Font("Tahoma", 10F);
            this.GRADE_BTN.ForeColor = System.Drawing.Color.White;
            this.GRADE_BTN.Location = new System.Drawing.Point(11, 205);
            this.GRADE_BTN.Name = "GRADE_BTN";
            this.GRADE_BTN.Size = new System.Drawing.Size(180, 38);
            this.GRADE_BTN.TabIndex = 8;
            this.GRADE_BTN.Text = "ADD/UPDATE GRADE";
            this.GRADE_BTN.UseVisualStyleBackColor = true;
            this.GRADE_BTN.Click += new System.EventHandler(this.GRADE_BTN_Click);
            // 
            // SignOut_btn
            // 
            this.SignOut_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignOut_btn.FlatAppearance.BorderSize = 3;
            this.SignOut_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.SignOut_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.SignOut_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignOut_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SignOut_btn.ForeColor = System.Drawing.Color.White;
            this.SignOut_btn.Location = new System.Drawing.Point(12, 459);
            this.SignOut_btn.Name = "SignOut_btn";
            this.SignOut_btn.Size = new System.Drawing.Size(73, 33);
            this.SignOut_btn.TabIndex = 7;
            this.SignOut_btn.Text = "Sign out";
            this.SignOut_btn.UseVisualStyleBackColor = true;
            this.SignOut_btn.Click += new System.EventHandler(this.SignOut_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(17, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Welcome, User";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 57);
            this.panel1.TabIndex = 3;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Location = new System.Drawing.Point(944, 13);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(26, 29);
            this.exit.TabIndex = 2;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(499, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lecturer Panel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Academic IS System";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(107)))), ((int)(((byte)(177)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(11, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "DASHBOARD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LecturerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LecturerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LecturerPanel";
            this.Load += new System.EventHandler(this.LecturerPanel_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button GRADE_BTN;
        private System.Windows.Forms.Button SignOut_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}