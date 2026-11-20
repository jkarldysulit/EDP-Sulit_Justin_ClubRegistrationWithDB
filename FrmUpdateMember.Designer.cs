namespace Sulit_Justin_RegistrationWithDB
{
    partial class FrmUpdateMember
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
            lblStudentId = new Label();
            cmbStudentId = new ComboBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblMiddleName = new Label();
            txtMiddleName = new TextBox();
            lblAge = new Label();
            txtAge = new TextBox();
            lblGender = new Label();
            cmbGender = new ComboBox();
            cmbProgram = new ComboBox();
            lblProgram = new Label();
            btnConfirm = new Button();
            SuspendLayout();
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.ForeColor = Color.FromArgb(200, 206, 214);
            lblStudentId.Location = new Point(40, 20);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(78, 19);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Student ID:";
            // 
            // cmbStudentId
            // 
            cmbStudentId.BackColor = Color.FromArgb(44, 50, 60);
            cmbStudentId.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudentId.FlatStyle = FlatStyle.Flat;
            cmbStudentId.ForeColor = Color.FromArgb(236, 239, 244);
            cmbStudentId.FormattingEnabled = true;
            cmbStudentId.Location = new Point(43, 45);
            cmbStudentId.Name = "cmbStudentId";
            cmbStudentId.Size = new Size(280, 25);
            cmbStudentId.TabIndex = 2;
            cmbStudentId.SelectedIndexChanged += cmbStudentId_SelectedIndexChanged;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.ForeColor = Color.FromArgb(200, 206, 214);
            lblLastName.Location = new Point(40, 90);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(75, 19);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Last name:";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(44, 50, 60);
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.ForeColor = Color.FromArgb(236, 239, 244);
            txtLastName.Location = new Point(43, 115);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(280, 25);
            txtLastName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.ForeColor = Color.FromArgb(200, 206, 214);
            lblFirstName.Location = new Point(40, 160);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(78, 19);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(44, 50, 60);
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.ForeColor = Color.FromArgb(236, 239, 244);
            txtFirstName.Location = new Point(43, 185);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(280, 25);
            txtFirstName.TabIndex = 6;
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.ForeColor = Color.FromArgb(200, 206, 214);
            lblMiddleName.Location = new Point(40, 230);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(92, 19);
            lblMiddleName.TabIndex = 7;
            lblMiddleName.Text = "Middle name:";
            // 
            // txtMiddleName
            // 
            txtMiddleName.BackColor = Color.FromArgb(44, 50, 60);
            txtMiddleName.BorderStyle = BorderStyle.FixedSingle;
            txtMiddleName.ForeColor = Color.FromArgb(236, 239, 244);
            txtMiddleName.Location = new Point(43, 255);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(280, 25);
            txtMiddleName.TabIndex = 8;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.ForeColor = Color.FromArgb(200, 206, 214);
            lblAge.Location = new Point(40, 300);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(36, 19);
            lblAge.TabIndex = 9;
            lblAge.Text = "Age:";
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.FromArgb(44, 50, 60);
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.ForeColor = Color.FromArgb(236, 239, 244);
            txtAge.Location = new Point(43, 325);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(120, 25);
            txtAge.TabIndex = 10;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.ForeColor = Color.FromArgb(200, 206, 214);
            lblGender.Location = new Point(40, 370);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(57, 19);
            lblGender.TabIndex = 11;
            lblGender.Text = "Gender:";
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.FromArgb(44, 50, 60);
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FlatStyle = FlatStyle.Flat;
            cmbGender.ForeColor = Color.FromArgb(236, 239, 244);
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(43, 395);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(180, 25);
            cmbGender.TabIndex = 12;
            // 
            // cmbProgram
            // 
            cmbProgram.BackColor = Color.FromArgb(44, 50, 60);
            cmbProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProgram.FlatStyle = FlatStyle.Flat;
            cmbProgram.ForeColor = Color.FromArgb(236, 239, 244);
            cmbProgram.FormattingEnabled = true;
            cmbProgram.Location = new Point(43, 465);
            cmbProgram.Name = "cmbProgram";
            cmbProgram.Size = new Size(280, 25);
            cmbProgram.TabIndex = 13;
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.ForeColor = Color.FromArgb(200, 206, 214);
            lblProgram.Location = new Point(40, 440);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(65, 19);
            lblProgram.TabIndex = 14;
            lblProgram.Text = "Program:";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(38, 166, 154);
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.FromArgb(18, 22, 28);
            btnConfirm.Location = new Point(103, 520);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(150, 40);
            btnConfirm.TabIndex = 15;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // FrmUpdateMember
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 34, 42);
            ClientSize = new Size(364, 601);
            Controls.Add(btnConfirm);
            Controls.Add(lblProgram);
            Controls.Add(cmbProgram);
            Controls.Add(cmbGender);
            Controls.Add(lblGender);
            Controls.Add(txtAge);
            Controls.Add(lblAge);
            Controls.Add(txtMiddleName);
            Controls.Add(lblMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(cmbStudentId);
            Controls.Add(lblStudentId);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(236, 239, 244);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUpdateMember";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update Member";
            Load += FrmUpdateMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentId;
        private ComboBox cmbStudentId;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblMiddleName;
        private TextBox txtMiddleName;
        private Label lblAge;
        private TextBox txtAge;
        private Label lblGender;
        private ComboBox cmbGender;
        private ComboBox cmbProgram;
        private Label lblProgram;
        private Button btnConfirm;
    }
}