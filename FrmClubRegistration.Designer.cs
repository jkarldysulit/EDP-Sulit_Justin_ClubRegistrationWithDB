namespace Sulit_Justin_RegistrationWithDB
{
    partial class FrmClubRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            grpRegistration = new GroupBox();
            cmbGender = new ComboBox();
            cmbProgram = new ComboBox();
            lblGender = new Label();
            lblAge = new Label();
            txtAge = new TextBox();
            txtMiddleName = new TextBox();
            lblMiddleName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            lblProgram = new Label();
            txtStudentId = new TextBox();
            lblStudentId = new Label();
            btnRegister = new Button();
            btnUpdate = new Button();
            grpList = new GroupBox();
            dataGridView = new DataGridView();
            btnRefresh = new Button();
            grpRegistration.SuspendLayout();
            grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // grpRegistration
            // 
            grpRegistration.Controls.Add(cmbGender);
            grpRegistration.Controls.Add(cmbProgram);
            grpRegistration.Controls.Add(lblGender);
            grpRegistration.Controls.Add(lblAge);
            grpRegistration.Controls.Add(txtAge);
            grpRegistration.Controls.Add(txtMiddleName);
            grpRegistration.Controls.Add(lblMiddleName);
            grpRegistration.Controls.Add(txtFirstName);
            grpRegistration.Controls.Add(lblFirstName);
            grpRegistration.Controls.Add(txtLastName);
            grpRegistration.Controls.Add(lblLastName);
            grpRegistration.Controls.Add(lblProgram);
            grpRegistration.Controls.Add(txtStudentId);
            grpRegistration.Controls.Add(lblStudentId);
            grpRegistration.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpRegistration.ForeColor = Color.FromArgb(128, 203, 196);
            grpRegistration.Location = new Point(16, 15);
            grpRegistration.Name = "grpRegistration";
            grpRegistration.Size = new Size(590, 235);
            grpRegistration.TabIndex = 0;
            grpRegistration.TabStop = false;
            grpRegistration.Text = "Member Information";
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.FromArgb(44, 50, 60);
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FlatStyle = FlatStyle.Flat;
            cmbGender.ForeColor = Color.FromArgb(236, 239, 244);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(208, 185);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(170, 25);
            cmbGender.TabIndex = 14;
            // 
            // cmbProgram
            // 
            cmbProgram.BackColor = Color.FromArgb(44, 50, 60);
            cmbProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProgram.FlatStyle = FlatStyle.Flat;
            cmbProgram.ForeColor = Color.FromArgb(236, 239, 244);
            cmbProgram.FormattingEnabled = true;
            cmbProgram.Items.AddRange(new object[] { "BS in Information Technology", "BS in Computer Science", "BS in Hospitality Management", "BS in Business Administration" });
            cmbProgram.Location = new Point(318, 55);
            cmbProgram.Name = "cmbProgram";
            cmbProgram.Size = new Size(250, 25);
            cmbProgram.TabIndex = 13;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.ForeColor = Color.FromArgb(200, 206, 214);
            lblGender.Location = new Point(205, 160);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(58, 19);
            lblGender.TabIndex = 12;
            lblGender.Text = "Gender:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.ForeColor = Color.FromArgb(200, 206, 214);
            lblAge.Location = new Point(15, 160);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(36, 19);
            lblAge.TabIndex = 11;
            lblAge.Text = "Age:";
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.FromArgb(44, 50, 60);
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.ForeColor = Color.FromArgb(236, 239, 244);
            txtAge.Location = new Point(18, 185);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 25);
            txtAge.TabIndex = 10;
            // 
            // txtMiddleName
            // 
            txtMiddleName.BackColor = Color.FromArgb(44, 50, 60);
            txtMiddleName.BorderStyle = BorderStyle.FixedSingle;
            txtMiddleName.ForeColor = Color.FromArgb(236, 239, 244);
            txtMiddleName.Location = new Point(398, 120);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(170, 25);
            txtMiddleName.TabIndex = 9;
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.ForeColor = Color.FromArgb(200, 206, 214);
            lblMiddleName.Location = new Point(395, 95);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(94, 19);
            lblMiddleName.TabIndex = 8;
            lblMiddleName.Text = "Middle name:";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(44, 50, 60);
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.ForeColor = Color.FromArgb(236, 239, 244);
            txtFirstName.Location = new Point(208, 120);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(170, 25);
            txtFirstName.TabIndex = 7;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.ForeColor = Color.FromArgb(200, 206, 214);
            lblFirstName.Location = new Point(205, 95);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 19);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "First Name:";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(44, 50, 60);
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.ForeColor = Color.FromArgb(236, 239, 244);
            txtLastName.Location = new Point(18, 120);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(170, 25);
            txtLastName.TabIndex = 5;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.ForeColor = Color.FromArgb(200, 206, 214);
            lblLastName.Location = new Point(15, 95);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(75, 19);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last name:";
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.ForeColor = Color.FromArgb(200, 206, 214);
            lblProgram.Location = new Point(315, 30);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(65, 19);
            lblProgram.TabIndex = 2;
            lblProgram.Text = "Program:";
            // 
            // txtStudentId
            // 
            txtStudentId.BackColor = Color.FromArgb(44, 50, 60);
            txtStudentId.BorderStyle = BorderStyle.FixedSingle;
            txtStudentId.ForeColor = Color.FromArgb(236, 239, 244);
            txtStudentId.Location = new Point(18, 55);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(200, 25);
            txtStudentId.TabIndex = 1;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.ForeColor = Color.FromArgb(200, 206, 214);
            lblStudentId.Location = new Point(15, 30);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(79, 19);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Student ID:";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(38, 166, 154);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnRegister.ForeColor = Color.FromArgb(18, 22, 28);
            btnRegister.Location = new Point(625, 25);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(150, 40);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(92, 107, 192);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(625, 75);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 40);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // grpList
            // 
            grpList.Controls.Add(dataGridView);
            grpList.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grpList.ForeColor = Color.FromArgb(128, 203, 196);
            grpList.Location = new Point(15, 265);
            grpList.Name = "grpList";
            grpList.Size = new Size(590, 250);
            grpList.TabIndex = 3;
            grpList.TabStop = false;
            grpList.Text = "List Of Club Members";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(44, 50, 60);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(236, 239, 244);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(38, 166, 154);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(18, 22, 28);
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.FromArgb(37, 42, 51);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(38, 70, 78);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(38, 70, 78);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeight = 32;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 42, 51);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(128, 203, 196);
            dataGridViewCellStyle3.Padding = new Padding(4, 0, 4, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(38, 166, 154);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(18, 22, 28);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.FromArgb(58, 65, 77);
            dataGridView.Location = new Point(10, 25);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowTemplate.Height = 28;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(570, 215);
            dataGridView.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(69, 90, 100);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(625, 290);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(150, 40);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // FrmClubRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 34, 42);
            ClientSize = new Size(794, 602);
            Controls.Add(btnRefresh);
            Controls.Add(grpList);
            Controls.Add(btnUpdate);
            Controls.Add(btnRegister);
            Controls.Add(grpRegistration);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(236, 239, 244);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmClubRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Registration";
            Load += FrmClubRegistration_Load;
            grpRegistration.ResumeLayout(false);
            grpRegistration.PerformLayout();
            grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpRegistration;
        private Label lblProgram;
        private TextBox txtStudentId;
        private Label lblStudentId;
        private TextBox txtLastName;
        private Label lblLastName;
        private Label lblMiddleName;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private Label lblGender;
        private Label lblAge;
        private TextBox txtAge;
        private TextBox txtMiddleName;
        private ComboBox cmbGender;
        private ComboBox cmbProgram;
        private Button btnRegister;
        private Button btnUpdate;
        private GroupBox grpList;
        private DataGridView dataGridView;
        private Button btnRefresh;
    }
}
