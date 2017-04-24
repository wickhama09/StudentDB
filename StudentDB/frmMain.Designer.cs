namespace StudentDB
{
    partial class frmMain
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
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.lblListStudent = new System.Windows.Forms.Label();
            this.btnViewCourse = new System.Windows.Forms.Button();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentAddress = new System.Windows.Forms.Label();
            this.lblStudentBirthdate = new System.Windows.Forms.Label();
            this.lblStudentPhone = new System.Windows.Forms.Label();
            this.lblStudentGpa = new System.Windows.Forms.Label();
            this.txtStudentFirstName = new System.Windows.Forms.TextBox();
            this.txtStudentAddress = new System.Windows.Forms.TextBox();
            this.txtStudentPhone = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lblGpa = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtStudentZip = new System.Windows.Forms.TextBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.txtStudentExt = new System.Windows.Forms.TextBox();
            this.txtStudentLastName = new System.Windows.Forms.TextBox();
            this.txtStudentAddressLine2 = new System.Windows.Forms.TextBox();
            this.txtStudentCity = new System.Windows.Forms.TextBox();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(42, 440);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Location = new System.Drawing.Point(42, 131);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(195, 303);
            this.lstStudents.Sorted = true;
            this.lstStudents.TabIndex = 1;
            this.lstStudents.SelectedIndexChanged += new System.EventHandler(this.lstStudents_SelectedIndexChanged);
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Location = new System.Drawing.Point(79, 105);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(120, 20);
            this.txtSearchStudent.TabIndex = 0;
            this.txtSearchStudent.Text = "Search By ID...";
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Enabled = false;
            this.btnEditStudent.Location = new System.Drawing.Point(162, 440);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(75, 23);
            this.btnEditStudent.TabIndex = 3;
            this.btnEditStudent.Text = "Edit Student";
            this.btnEditStudent.UseVisualStyleBackColor = true;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // lblListStudent
            // 
            this.lblListStudent.AutoSize = true;
            this.lblListStudent.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListStudent.Location = new System.Drawing.Point(65, 36);
            this.lblListStudent.Name = "lblListStudent";
            this.lblListStudent.Size = new System.Drawing.Size(154, 22);
            this.lblListStudent.TabIndex = 9;
            this.lblListStudent.Text = "Student Database";
            // 
            // btnViewCourse
            // 
            this.btnViewCourse.Enabled = false;
            this.btnViewCourse.Location = new System.Drawing.Point(399, 411);
            this.btnViewCourse.Name = "btnViewCourse";
            this.btnViewCourse.Size = new System.Drawing.Size(145, 23);
            this.btnViewCourse.TabIndex = 4;
            this.btnViewCourse.Text = "View Registered Courses...";
            this.btnViewCourse.UseVisualStyleBackColor = true;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentId.Location = new System.Drawing.Point(22, 16);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(88, 17);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "Student ID: ";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(22, 56);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(55, 17);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Name: ";
            this.lblStudentName.Click += new System.EventHandler(this.lblStudentName_Click);
            // 
            // lblStudentAddress
            // 
            this.lblStudentAddress.AutoSize = true;
            this.lblStudentAddress.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentAddress.Location = new System.Drawing.Point(22, 93);
            this.lblStudentAddress.Name = "lblStudentAddress";
            this.lblStudentAddress.Size = new System.Drawing.Size(72, 17);
            this.lblStudentAddress.TabIndex = 2;
            this.lblStudentAddress.Text = "Address: ";
            // 
            // lblStudentBirthdate
            // 
            this.lblStudentBirthdate.AutoSize = true;
            this.lblStudentBirthdate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentBirthdate.Location = new System.Drawing.Point(22, 210);
            this.lblStudentBirthdate.Name = "lblStudentBirthdate";
            this.lblStudentBirthdate.Size = new System.Drawing.Size(79, 17);
            this.lblStudentBirthdate.TabIndex = 3;
            this.lblStudentBirthdate.Text = "Birthdate: ";
            // 
            // lblStudentPhone
            // 
            this.lblStudentPhone.AutoSize = true;
            this.lblStudentPhone.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentPhone.Location = new System.Drawing.Point(22, 247);
            this.lblStudentPhone.Name = "lblStudentPhone";
            this.lblStudentPhone.Size = new System.Drawing.Size(58, 17);
            this.lblStudentPhone.TabIndex = 4;
            this.lblStudentPhone.Text = "Phone: ";
            // 
            // lblStudentGpa
            // 
            this.lblStudentGpa.AutoSize = true;
            this.lblStudentGpa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentGpa.Location = new System.Drawing.Point(19, 291);
            this.lblStudentGpa.Name = "lblStudentGpa";
            this.lblStudentGpa.Size = new System.Drawing.Size(47, 17);
            this.lblStudentGpa.TabIndex = 5;
            this.lblStudentGpa.Text = "GPA: ";
            // 
            // txtStudentFirstName
            // 
            this.txtStudentFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentFirstName.Location = new System.Drawing.Point(107, 56);
            this.txtStudentFirstName.Name = "txtStudentFirstName";
            this.txtStudentFirstName.ReadOnly = true;
            this.txtStudentFirstName.Size = new System.Drawing.Size(85, 20);
            this.txtStudentFirstName.TabIndex = 0;
            this.txtStudentFirstName.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtStudentFirstName.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // txtStudentAddress
            // 
            this.txtStudentAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentAddress.Location = new System.Drawing.Point(107, 93);
            this.txtStudentAddress.Name = "txtStudentAddress";
            this.txtStudentAddress.ReadOnly = true;
            this.txtStudentAddress.Size = new System.Drawing.Size(181, 20);
            this.txtStudentAddress.TabIndex = 2;
            this.txtStudentAddress.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtStudentAddress.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // txtStudentPhone
            // 
            this.txtStudentPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentPhone.Location = new System.Drawing.Point(107, 244);
            this.txtStudentPhone.Name = "txtStudentPhone";
            this.txtStudentPhone.ReadOnly = true;
            this.txtStudentPhone.Size = new System.Drawing.Size(107, 20);
            this.txtStudentPhone.TabIndex = 10;
            this.txtStudentPhone.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtStudentPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentPhone_KeyPress);
            this.txtStudentPhone.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.Location = new System.Drawing.Point(69, 305);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(92, 23);
            this.btnSaveChanges.TabIndex = 12;
            this.btnSaveChanges.Text = "Save";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // lblGpa
            // 
            this.lblGpa.AutoSize = true;
            this.lblGpa.Location = new System.Drawing.Point(66, 294);
            this.lblGpa.Name = "lblGpa";
            this.lblGpa.Size = new System.Drawing.Size(28, 13);
            this.lblGpa.TabIndex = 13;
            this.lblGpa.Text = "0.00";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(110, 15);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 19);
            this.lblId.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(175, 305);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtStudentZip
            // 
            this.txtStudentZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentZip.Location = new System.Drawing.Point(108, 171);
            this.txtStudentZip.Name = "txtStudentZip";
            this.txtStudentZip.ReadOnly = true;
            this.txtStudentZip.Size = new System.Drawing.Size(85, 20);
            this.txtStudentZip.TabIndex = 6;
            this.txtStudentZip.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtStudentZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentZip_KeyPress);
            this.txtStudentZip.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // cbMonth
            // 
            this.cbMonth.BackColor = System.Drawing.SystemColors.Window;
            this.cbMonth.DropDownHeight = 100;
            this.cbMonth.Enabled = false;
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.IntegralHeight = false;
            this.cbMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbMonth.Location = new System.Drawing.Point(108, 208);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(43, 21);
            this.cbMonth.TabIndex = 7;
            this.cbMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_numKeyPress);
            // 
            // cbDay
            // 
            this.cbDay.BackColor = System.Drawing.SystemColors.Window;
            this.cbDay.DropDownHeight = 100;
            this.cbDay.Enabled = false;
            this.cbDay.FormattingEnabled = true;
            this.cbDay.IntegralHeight = false;
            this.cbDay.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbDay.Location = new System.Drawing.Point(157, 208);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(43, 21);
            this.cbDay.TabIndex = 8;
            this.cbDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_numKeyPress);
            // 
            // cbYear
            // 
            this.cbYear.BackColor = System.Drawing.SystemColors.Window;
            this.cbYear.DropDownHeight = 100;
            this.cbYear.Enabled = false;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.IntegralHeight = false;
            this.cbYear.Location = new System.Drawing.Point(206, 208);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(82, 21);
            this.cbYear.TabIndex = 9;
            this.cbYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_numKeyPress);
            // 
            // txtStudentExt
            // 
            this.txtStudentExt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentExt.Location = new System.Drawing.Point(220, 244);
            this.txtStudentExt.Name = "txtStudentExt";
            this.txtStudentExt.ReadOnly = true;
            this.txtStudentExt.Size = new System.Drawing.Size(68, 20);
            this.txtStudentExt.TabIndex = 11;
            this.txtStudentExt.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtStudentExt.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // txtStudentLastName
            // 
            this.txtStudentLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentLastName.Location = new System.Drawing.Point(198, 56);
            this.txtStudentLastName.Name = "txtStudentLastName";
            this.txtStudentLastName.ReadOnly = true;
            this.txtStudentLastName.Size = new System.Drawing.Size(90, 20);
            this.txtStudentLastName.TabIndex = 1;
            this.txtStudentLastName.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtStudentLastName.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // txtStudentAddressLine2
            // 
            this.txtStudentAddressLine2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentAddressLine2.Location = new System.Drawing.Point(107, 119);
            this.txtStudentAddressLine2.Name = "txtStudentAddressLine2";
            this.txtStudentAddressLine2.ReadOnly = true;
            this.txtStudentAddressLine2.Size = new System.Drawing.Size(181, 20);
            this.txtStudentAddressLine2.TabIndex = 3;
            this.txtStudentAddressLine2.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtStudentAddressLine2.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // txtStudentCity
            // 
            this.txtStudentCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentCity.Location = new System.Drawing.Point(107, 145);
            this.txtStudentCity.Name = "txtStudentCity";
            this.txtStudentCity.ReadOnly = true;
            this.txtStudentCity.Size = new System.Drawing.Size(120, 20);
            this.txtStudentCity.TabIndex = 4;
            this.txtStudentCity.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtStudentCity.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // cbState
            // 
            this.cbState.BackColor = System.Drawing.SystemColors.Window;
            this.cbState.DropDownHeight = 100;
            this.cbState.Enabled = false;
            this.cbState.FormattingEnabled = true;
            this.cbState.IntegralHeight = false;
            this.cbState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DC",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.cbState.Location = new System.Drawing.Point(233, 145);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(55, 21);
            this.cbState.TabIndex = 5;
            this.cbState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_stateKeyPress);
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.cbState);
            this.grpResults.Controls.Add(this.txtStudentCity);
            this.grpResults.Controls.Add(this.txtStudentAddressLine2);
            this.grpResults.Controls.Add(this.txtStudentLastName);
            this.grpResults.Controls.Add(this.txtStudentExt);
            this.grpResults.Controls.Add(this.cbYear);
            this.grpResults.Controls.Add(this.cbDay);
            this.grpResults.Controls.Add(this.cbMonth);
            this.grpResults.Controls.Add(this.txtStudentZip);
            this.grpResults.Controls.Add(this.btnCancel);
            this.grpResults.Controls.Add(this.lblId);
            this.grpResults.Controls.Add(this.lblGpa);
            this.grpResults.Controls.Add(this.btnSaveChanges);
            this.grpResults.Controls.Add(this.txtStudentPhone);
            this.grpResults.Controls.Add(this.txtStudentAddress);
            this.grpResults.Controls.Add(this.txtStudentFirstName);
            this.grpResults.Controls.Add(this.lblStudentGpa);
            this.grpResults.Controls.Add(this.lblStudentPhone);
            this.grpResults.Controls.Add(this.lblStudentBirthdate);
            this.grpResults.Controls.Add(this.lblStudentAddress);
            this.grpResults.Controls.Add(this.lblStudentName);
            this.grpResults.Controls.Add(this.lblStudentId);
            this.grpResults.Location = new System.Drawing.Point(309, 36);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(323, 360);
            this.grpResults.TabIndex = 4;
            this.grpResults.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 532);
            this.Controls.Add(this.btnViewCourse);
            this.Controls.Add(this.lblListStudent);
            this.Controls.Add(this.btnEditStudent);
            this.Controls.Add(this.txtSearchStudent);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.grpResults);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentDB";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Label lblListStudent;
        private System.Windows.Forms.Button btnViewCourse;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentAddress;
        private System.Windows.Forms.Label lblStudentBirthdate;
        private System.Windows.Forms.Label lblStudentPhone;
        private System.Windows.Forms.Label lblStudentGpa;
        private System.Windows.Forms.TextBox txtStudentFirstName;
        private System.Windows.Forms.TextBox txtStudentAddress;
        private System.Windows.Forms.TextBox txtStudentPhone;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label lblGpa;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtStudentZip;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.TextBox txtStudentExt;
        private System.Windows.Forms.TextBox txtStudentLastName;
        private System.Windows.Forms.TextBox txtStudentAddressLine2;
        private System.Windows.Forms.TextBox txtStudentCity;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.GroupBox grpResults;
    }
}

