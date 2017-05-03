namespace StudentDB
{
    partial class frmCourse
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.gridCourse = new System.Windows.Forms.DataGridView();
            this.recordsDataSet = new StudentDB.RecordsDataSet();
            this.studentCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentCourseTableAdapter = new StudentDB.RecordsDataSetTableAdapters.StudentCourseTableAdapter();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.grpCourse = new System.Windows.Forms.GroupBox();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cbTerm = new System.Windows.Forms.ComboBox();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.lstCourse = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveCourse = new System.Windows.Forms.Button();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpBlank = new System.Windows.Forms.GroupBox();
            this.grpGrade = new System.Windows.Forms.GroupBox();
            this.txtGradeTerm = new System.Windows.Forms.TextBox();
            this.txtGradeCourse = new System.Windows.Forms.TextBox();
            this.lblGradeSelect = new System.Windows.Forms.Label();
            this.cbGrade = new System.Windows.Forms.ComboBox();
            this.btnCancelGrade = new System.Windows.Forms.Button();
            this.btnAddSelectedGrade = new System.Windows.Forms.Button();
            this.lblAddGrade = new System.Windows.Forms.Label();
            this.lblStudentGpa = new System.Windows.Forms.Label();
            this.lblGpa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCourseBindingSource)).BeginInit();
            this.grpCourse.SuspendLayout();
            this.grpGrade.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(35, 38);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(91, 19);
            this.lblStudent.TabIndex = 1;
            this.lblStudent.Text = "Student ID: ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(150, 38);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(45, 19);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "label1";
            // 
            // gridCourse
            // 
            this.gridCourse.AllowUserToAddRows = false;
            this.gridCourse.AllowUserToDeleteRows = false;
            this.gridCourse.AllowUserToResizeColumns = false;
            this.gridCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCourse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCourse.Location = new System.Drawing.Point(39, 72);
            this.gridCourse.MultiSelect = false;
            this.gridCourse.Name = "gridCourse";
            this.gridCourse.ReadOnly = true;
            this.gridCourse.RowHeadersVisible = false;
            this.gridCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCourse.Size = new System.Drawing.Size(284, 262);
            this.gridCourse.TabIndex = 3;
            this.gridCourse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCourse_CellClick);
            // 
            // recordsDataSet
            // 
            this.recordsDataSet.DataSetName = "RecordsDataSet";
            this.recordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentCourseBindingSource
            // 
            this.studentCourseBindingSource.DataMember = "StudentCourse";
            this.studentCourseBindingSource.DataSource = this.recordsDataSet;
            // 
            // studentCourseTableAdapter
            // 
            this.studentCourseTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(39, 343);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(75, 23);
            this.btnAddCourse.TabIndex = 4;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.Enabled = false;
            this.btnAddGrade.Location = new System.Drawing.Point(248, 343);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(75, 23);
            this.btnAddGrade.TabIndex = 5;
            this.btnAddGrade.Text = "Add Grade";
            this.btnAddGrade.UseVisualStyleBackColor = true;
            this.btnAddGrade.Click += new System.EventHandler(this.btnAddGrade_Click);
            // 
            // grpCourse
            // 
            this.grpCourse.Controls.Add(this.lblTerm);
            this.grpCourse.Controls.Add(this.lblSubject);
            this.grpCourse.Controls.Add(this.cbTerm);
            this.grpCourse.Controls.Add(this.cbSubject);
            this.grpCourse.Controls.Add(this.lstCourse);
            this.grpCourse.Controls.Add(this.btnCancel);
            this.grpCourse.Controls.Add(this.label1);
            this.grpCourse.Controls.Add(this.btnSaveCourse);
            this.grpCourse.Controls.Add(this.lblStudentId);
            this.grpCourse.Location = new System.Drawing.Point(349, 28);
            this.grpCourse.Name = "grpCourse";
            this.grpCourse.Size = new System.Drawing.Size(323, 360);
            this.grpCourse.TabIndex = 6;
            this.grpCourse.TabStop = false;
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerm.Location = new System.Drawing.Point(81, 279);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(82, 17);
            this.lblTerm.TabIndex = 21;
            this.lblTerm.Text = "Select Term:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(47, 49);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(104, 17);
            this.lblSubject.TabIndex = 20;
            this.lblSubject.Text = "Filter by subject:";
            // 
            // cbTerm
            // 
            this.cbTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTerm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTerm.FormattingEnabled = true;
            this.cbTerm.Location = new System.Drawing.Point(169, 278);
            this.cbTerm.Name = "cbTerm";
            this.cbTerm.Size = new System.Drawing.Size(73, 21);
            this.cbTerm.TabIndex = 19;
            this.cbTerm.SelectedIndexChanged += new System.EventHandler(this.cbTerm_SelectedIndexChanged);
            // 
            // cbSubject
            // 
            this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(155, 48);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(121, 21);
            this.cbSubject.TabIndex = 18;
            this.cbSubject.SelectedIndexChanged += new System.EventHandler(this.cbSubject_SelectedIndexChanged);
            // 
            // lstCourse
            // 
            this.lstCourse.FormattingEnabled = true;
            this.lstCourse.Location = new System.Drawing.Point(92, 91);
            this.lstCourse.Name = "lstCourse";
            this.lstCourse.Size = new System.Drawing.Size(139, 160);
            this.lstCourse.TabIndex = 15;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(169, 318);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 14;
            // 
            // btnSaveCourse
            // 
            this.btnSaveCourse.Location = new System.Drawing.Point(61, 318);
            this.btnSaveCourse.Name = "btnSaveCourse";
            this.btnSaveCourse.Size = new System.Drawing.Size(92, 23);
            this.btnSaveCourse.TabIndex = 12;
            this.btnSaveCourse.Text = "Add";
            this.btnSaveCourse.UseVisualStyleBackColor = true;
            this.btnSaveCourse.Click += new System.EventHandler(this.btnAddCourse_Click_1);
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentId.Location = new System.Drawing.Point(60, 16);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(203, 17);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "Select A Course To Be Added";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(39, 375);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(35, 19);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(109, 19);
            this.lblStudentName.TabIndex = 8;
            this.lblStudentName.Text = "Student Name:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(150, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 19);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "label1";
            // 
            // grpBlank
            // 
            this.grpBlank.Location = new System.Drawing.Point(248, 23);
            this.grpBlank.Name = "grpBlank";
            this.grpBlank.Size = new System.Drawing.Size(200, 100);
            this.grpBlank.TabIndex = 10;
            this.grpBlank.TabStop = false;
            // 
            // grpGrade
            // 
            this.grpGrade.Controls.Add(this.txtGradeTerm);
            this.grpGrade.Controls.Add(this.txtGradeCourse);
            this.grpGrade.Controls.Add(this.lblGradeSelect);
            this.grpGrade.Controls.Add(this.cbGrade);
            this.grpGrade.Controls.Add(this.btnCancelGrade);
            this.grpGrade.Controls.Add(this.btnAddSelectedGrade);
            this.grpGrade.Controls.Add(this.lblAddGrade);
            this.grpGrade.Location = new System.Drawing.Point(268, 19);
            this.grpGrade.Name = "grpGrade";
            this.grpGrade.Size = new System.Drawing.Size(323, 360);
            this.grpGrade.TabIndex = 11;
            this.grpGrade.TabStop = false;
            this.grpGrade.Visible = false;
            // 
            // txtGradeTerm
            // 
            this.txtGradeTerm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGradeTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGradeTerm.Location = new System.Drawing.Point(94, 108);
            this.txtGradeTerm.Name = "txtGradeTerm";
            this.txtGradeTerm.ReadOnly = true;
            this.txtGradeTerm.Size = new System.Drawing.Size(135, 15);
            this.txtGradeTerm.TabIndex = 24;
            this.txtGradeTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGradeCourse
            // 
            this.txtGradeCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGradeCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGradeCourse.Location = new System.Drawing.Point(94, 87);
            this.txtGradeCourse.Name = "txtGradeCourse";
            this.txtGradeCourse.ReadOnly = true;
            this.txtGradeCourse.Size = new System.Drawing.Size(135, 15);
            this.txtGradeCourse.TabIndex = 23;
            this.txtGradeCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGradeSelect
            // 
            this.lblGradeSelect.AutoSize = true;
            this.lblGradeSelect.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeSelect.Location = new System.Drawing.Point(84, 184);
            this.lblGradeSelect.Name = "lblGradeSelect";
            this.lblGradeSelect.Size = new System.Drawing.Size(87, 17);
            this.lblGradeSelect.TabIndex = 21;
            this.lblGradeSelect.Text = "Select Grade:";
            // 
            // cbGrade
            // 
            this.cbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGrade.FormattingEnabled = true;
            this.cbGrade.Items.AddRange(new object[] {
            "A",
            "A-",
            "B+",
            "B",
            "B-",
            "C+",
            "C",
            "C-",
            "D+",
            "D",
            "D-",
            "F",
            "W"});
            this.cbGrade.Location = new System.Drawing.Point(176, 183);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.Size = new System.Drawing.Size(63, 21);
            this.cbGrade.TabIndex = 18;
            this.cbGrade.SelectedIndexChanged += new System.EventHandler(this.cbGrade_SelectedIndexChanged);
            // 
            // btnCancelGrade
            // 
            this.btnCancelGrade.Location = new System.Drawing.Point(169, 275);
            this.btnCancelGrade.Name = "btnCancelGrade";
            this.btnCancelGrade.Size = new System.Drawing.Size(92, 23);
            this.btnCancelGrade.TabIndex = 13;
            this.btnCancelGrade.Text = "Cancel";
            this.btnCancelGrade.UseVisualStyleBackColor = true;
            this.btnCancelGrade.Click += new System.EventHandler(this.btnCancelGrade_Click);
            // 
            // btnAddSelectedGrade
            // 
            this.btnAddSelectedGrade.Location = new System.Drawing.Point(61, 275);
            this.btnAddSelectedGrade.Name = "btnAddSelectedGrade";
            this.btnAddSelectedGrade.Size = new System.Drawing.Size(92, 23);
            this.btnAddSelectedGrade.TabIndex = 12;
            this.btnAddSelectedGrade.Text = "Add";
            this.btnAddSelectedGrade.UseVisualStyleBackColor = true;
            this.btnAddSelectedGrade.Click += new System.EventHandler(this.btnAddSelectedGrade_Click);
            // 
            // lblAddGrade
            // 
            this.lblAddGrade.AutoSize = true;
            this.lblAddGrade.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddGrade.Location = new System.Drawing.Point(75, 63);
            this.lblAddGrade.Name = "lblAddGrade";
            this.lblAddGrade.Size = new System.Drawing.Size(172, 17);
            this.lblAddGrade.TabIndex = 0;
            this.lblAddGrade.Text = "Adding Grade To Course";
            // 
            // lblStudentGpa
            // 
            this.lblStudentGpa.AutoSize = true;
            this.lblStudentGpa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentGpa.Location = new System.Drawing.Point(140, 344);
            this.lblStudentGpa.Name = "lblStudentGpa";
            this.lblStudentGpa.Size = new System.Drawing.Size(45, 19);
            this.lblStudentGpa.TabIndex = 12;
            this.lblStudentGpa.Text = "GPA:";
            // 
            // lblGpa
            // 
            this.lblGpa.AutoSize = true;
            this.lblGpa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGpa.Location = new System.Drawing.Point(182, 344);
            this.lblGpa.Name = "lblGpa";
            this.lblGpa.Size = new System.Drawing.Size(37, 19);
            this.lblGpa.TabIndex = 13;
            this.lblGpa.Text = "0.00";
            // 
            // frmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 417);
            this.Controls.Add(this.lblGpa);
            this.Controls.Add(this.lblStudentGpa);
            this.Controls.Add(this.grpGrade);
            this.Controls.Add(this.grpBlank);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpCourse);
            this.Controls.Add(this.btnAddGrade);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.gridCourse);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblStudent);
            this.Name = "frmCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Viewer";
            this.Load += new System.EventHandler(this.frmCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCourseBindingSource)).EndInit();
            this.grpCourse.ResumeLayout(false);
            this.grpCourse.PerformLayout();
            this.grpGrade.ResumeLayout(false);
            this.grpGrade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView gridCourse;
        private RecordsDataSet recordsDataSet;
        private System.Windows.Forms.BindingSource studentCourseBindingSource;
        private RecordsDataSetTableAdapters.StudentCourseTableAdapter studentCourseTableAdapter;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnAddGrade;
        private System.Windows.Forms.GroupBox grpCourse;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.ListBox lstCourse;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveCourse;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cbTerm;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpBlank;
        private System.Windows.Forms.GroupBox grpGrade;
        private System.Windows.Forms.Label lblGradeSelect;
        private System.Windows.Forms.ComboBox cbGrade;
        private System.Windows.Forms.Button btnCancelGrade;
        private System.Windows.Forms.Button btnAddSelectedGrade;
        private System.Windows.Forms.Label lblAddGrade;
        private System.Windows.Forms.TextBox txtGradeCourse;
        private System.Windows.Forms.TextBox txtGradeTerm;
        private System.Windows.Forms.Label lblStudentGpa;
        private System.Windows.Forms.Label lblGpa;
    }
}