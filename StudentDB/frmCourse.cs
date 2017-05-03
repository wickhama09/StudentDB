// Program Name:    Student DB
// Author:          Anthony Wickham
// Last Revision:   May 03, 2017

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace StudentDB
{
    public partial class frmCourse : Form
    {
        // Declare class-wide variables
        string studentId;
        string studentName;
        string connectionString;
        SqlConnection connection;
        Form frmOrigin;

        // Initialize dictionary for GPA calculation
        Dictionary<string, float> gradeVals = new Dictionary<string, float>
        {
            { "A", 4.0f   },
            { "A-", 3.67f },
            { "B+", 3.33f },
            { "B", 3.0f   },
            { "B-", 2.67f },
            { "C+", 2.33f },
            { "C", 2.0f   },
            { "C-", 1.67f },
            { "D+", 1.33f },
            { "D", 1.0f   },
            { "D-", 0.67f },
            { "F", 0.0f   },
            { "W", 0.0f   },
        };


        /* This constructor initializes the form with student data*/
        public frmCourse(Form frm, string Id, string name, string gpa)
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["StudentDB.Properties.Settings.RecordsConnectionString"].ConnectionString;

            studentId = Id;
            studentName = name;
            lblGpa.Text = gpa;
            frmOrigin = frm;
        }


        /* This event configures view objects at form load */
        private void frmCourse_Load(object sender, EventArgs e)
        {
            // initialize view properties
            lblId.Text = studentId;
            lblName.Text = studentName;
            grpBlank.Location = grpCourse.Location;
            grpBlank.Size = grpCourse.Size;
            grpBlank.Show();
            grpGrade.Location = grpCourse.Location;
            grpGrade.Size = grpCourse.Size;

            populateRegisteredCourses();
        }


        /* This event populates selectable Courses */
        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateCourses((int)cbSubject.SelectedValue);
            lstCourse.Focus();
        }


        /* This event focuses btnSaveCourse when a term is selected */
        private void cbTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSaveCourse.Focus();
        }


        /* This event enables Add Grade button when necessary */
        private void gridCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridCourse.SelectedRows.Count != 0 && gridCourse.SelectedRows[0].Cells["Grade"].Value == DBNull.Value)
            {
                btnAddGrade.Enabled = true;
            }

            else
            {
                btnAddGrade.Enabled = false;
            }
        }


        /* This event removes focus after a grade is selected */
        private void cbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddSelectedGrade.Focus();
        }


        /* This event returns user to frmMain */
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmOrigin.Show();
            Close();
        }


        /* This event cancels form course entry */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAddCourse.Enabled = true;
            gridCourse.ClearSelection();
            grpBlank.Show();
        }


        /* This event cancels form grade entry */
        private void btnCancelGrade_Click(object sender, EventArgs e)
        {
            grpGrade.Hide();
            grpBlank.Show();
            btnAddCourse.Enabled = true;
            gridCourse.ClearSelection();
        }


        /* This event prepares form to add a grade */
        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            grpGrade.Show();
            cbGrade.SelectedIndex = 0;
            txtGradeCourse.Text = (string)gridCourse.SelectedRows[0].Cells["Name"].Value;
            txtGradeTerm.Text = (string)gridCourse.SelectedRows[0].Cells["Term"].Value;
            btnAddGrade.Enabled = false;
            btnAddCourse.Enabled = false;
        }


        /* This event prepares view objects to add a course */
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            btnAddCourse.Enabled = false;
            btnAddGrade.Enabled = false;
            grpBlank.Hide();
            populateSubjects();
            populateCourses(Convert.ToInt32(cbSubject.SelectedValue));
            populateTerm();
            gridCourse.ClearSelection();
        }


        /* This event queries the database and adds a course to the table StudentCourse */
        private void btnAddCourse_Click_1(object sender, EventArgs e)
        {

            DialogResult confirmation = MessageBox.Show("Please confirm your course registration.\n\n" +
                    "Student:\t" + studentName +
                    "\nCourse:\t" + lstCourse.Text +
                    "\nTerm:\t" + cbTerm.Text

                    , "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (confirmation == DialogResult.OK)
            {
                try
                {
                    using (connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand("INSERT INTO StudentCourse VALUES (@StudentId, @CourseId, @Grade, @GradeValue, @Term)", connection))
                    {
                        command.Parameters.AddWithValue("@StudentId", studentId);
                        command.Parameters.AddWithValue("@CourseId", lstCourse.SelectedValue);
                        command.Parameters.AddWithValue("@Grade", DBNull.Value);
                        command.Parameters.AddWithValue("@GradeValue", DBNull.Value);
                        command.Parameters.AddWithValue("@Term", cbTerm.Text);

                        connection.Open();
                        command.ExecuteNonQuery();

                        // configure and refresh view objects
                        populateRegisteredCourses();
                        grpBlank.Show();
                        btnAddCourse.Enabled = true;
                    }
                }

                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Could not connect to Records Database! " + sqlEx.Message);
                    connection.Close();
                    return;
                }

                catch (NoNullAllowedException nnaEx)
                {
                    MessageBox.Show("Null value exception! " + nnaEx);
                    connection.Close();
                    return;
                }
            }
        }


        /* This event adds a grade to table StudentCourse, also calculates and updates GPA in table Student */
        private void btnAddSelectedGrade_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Please confirm your entry.\n\n" +
                    "Grade:\t" + cbGrade.Text +
                    "\nCourse:\t" + (string)gridCourse.SelectedRows[0].Cells["Name"].Value +
                    "\nTerm:\t" + (string)gridCourse.SelectedRows[0].Cells["Term"].Value

                    , "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (confirmation == DialogResult.OK)
            {
                try
                {
                    int id = (int)gridCourse.SelectedRows[0].Cells["Id"].Value;

                    using (connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand("UPDATE StudentCourse SET Grade = @Grade, GradeValue = @GradeValue " +
                        " WHERE Id = @StudentCourseId", connection))
                    {
                        command.Parameters.AddWithValue("@GradeValue", gradeVals[cbGrade.Text]);
                        command.Parameters.AddWithValue("@StudentCourseId", id);
                        command.Parameters.AddWithValue("@Grade", cbGrade.Text);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    // Retrieve grades and calculate a new GPA
                    using (connection = new SqlConnection(connectionString))
                    using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT StudentCourse.GradeValue, StudentCourse.Grade, Course.Hours FROM StudentCourse INNER JOIN Course ON Course.Id = StudentCourse.CourseId WHERE StudentId = @StudentId", connection))
                    {
                        // NOTE: A SqlDataAdapter will call connection.open() automatically

                        adapter.SelectCommand.Parameters.AddWithValue("@StudentId", studentId);

                        // Create a reference to query results
                        DataTable gpaTable = new DataTable();
                        adapter.Fill(gpaTable);

                        float gradeHrs;
                        float gradeVal;
                        float gradeHrsCnt = 0;
                        float gradePoints = 0;

                        foreach (DataRow row in gpaTable.Rows)
                        {
                            if (row["GradeValue"] != DBNull.Value && (string)row["Grade"] != "W") // A grade of W will not be included in GPA calculation
                            {
                                gradeVal = Convert.ToSingle(row["GradeValue"]);
                                gradeHrs = Convert.ToSingle(row["Hours"]);
                                gradePoints += (gradeVal * gradeHrs);
                                gradeHrsCnt += gradeHrs;
                            }
                        }

                        float gpa = (gradePoints / Convert.ToSingle(gradeHrsCnt));

                        // Update datbase with new GPA
                        using (connection = new SqlConnection(connectionString))
                        using (SqlCommand command = new SqlCommand("UPDATE Student SET Gpa = @Gpa" +
                            " WHERE Id = @StudentId", connection))
                        {
                            command.Parameters.AddWithValue("@Gpa", gpa);
                            command.Parameters.AddWithValue("@StudentId", studentId);

                            connection.Open();
                            command.ExecuteNonQuery();

                            // configure and refresh view objects
                            populateRegisteredCourses();
                            lblGpa.Text = gpa.ToString("F");
                            grpBlank.Show();
                            grpGrade.Hide();
                            btnAddCourse.Enabled = true;
                        }
                    }
                }

                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Could not connect to Records Database! " + sqlEx.Message);
                    connection.Close();
                    return;
                }

                catch (NoNullAllowedException nnaEx)
                {
                    MessageBox.Show("Null value exception! " + nnaEx);
                    connection.Close();
                    return;
                }
            }
        }


        /* This function populates the DataGridView with the student's courses from the database */
        public void populateRegisteredCourses()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT  Course.Name, StudentCourse.Id, StudentCourse.Term, Course.Hours, StudentCourse.Grade FROM ((Course INNER JOIN StudentCourse ON Course.Id = StudentCourse.CourseId) INNER JOIN Student ON StudentCourse.StudentId = Student.Id) WHERE StudentCourse.StudentId = @StudentID", connection))
            {
                // NOTE: A SqlDataAdapter will call connection.open() automatically

                adapter.SelectCommand.Parameters.AddWithValue("@StudentID", studentId);

                // Create a reference to query results
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Send results to grid and format the grid
                // resize columns
                // hide id column (need to be able to reference studentcourse id for db query)
                gridCourse.DataSource = dt;
                gridCourse.Columns["Name"].Width = (int)(gridCourse.Width * 0.4);
                gridCourse.Columns["Id"].Visible = false;
                gridCourse.Columns["Hours"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gridCourse.Columns["Grade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gridCourse.Columns["Term"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gridCourse.Sort(gridCourse.Columns["Term"], ListSortDirection.Descending);
                gridCourse.ClearSelection();
            }
        }


        /* This function populates the subjects for filtering courses */
        private void populateSubjects()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Subject", connection))
            {
                // NOTE: A SqlDataAdapter will call connection.open() automatically

                // Create a reference to query results
                DataTable subjectTable = new DataTable();
                adapter.Fill(subjectTable);

                // Add selection for Any at a negative index value
                var dr = subjectTable.NewRow();
                dr["Id"] = -1;
                dr["Name"] = "(Any)";
                subjectTable.Rows.InsertAt(dr, 0);

                // Configure properties
                cbSubject.DisplayMember = "Name";
                cbSubject.ValueMember = "Id";
                cbSubject.DataSource = subjectTable;
            }
        }


        /* This function populates the courses in the listbox when adding a course */
        private void populateCourses(int id)
        {
            // NOTE: integer parameter id is the subjectId to filter courses by
            // NOTE: pass -1 to retrieve all courses

            string query;

            // an id < 0 means that "Any" is selected in subject combobox
            if (id < 0)
            {
                query = "SELECT * FROM Course";
            }

            else
            {
                query = "SELECT* FROM Course INNER JOIN Subject ON Course.SubjectId = Subject.Id WHERE Subject.Id = @Subject";
            }

            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                // NOTE: A SqlDataAdapter will call connection.open() automatically

                if (id >= 0)
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Subject", id.ToString());
                }

                // Create a reference to query results
                DataTable courseTable = new DataTable();
                adapter.Fill(courseTable);

                // Configure properties
                lstCourse.DisplayMember = "Name";
                lstCourse.ValueMember = "Id";
                lstCourse.DataSource = courseTable;
            }
        }


        /* This function populates the Term combobox with realistic years */
        private void populateTerm()
        {
            // Set default Term selection relative to the current month of the year
            DateTime currentYear = DateTime.Now;
            string currentYY = currentYear.ToString("yy");
            int yyInt = Convert.ToUInt16(currentYY);

            cbTerm.Items.Add(currentYY + "/SP");
            cbTerm.Items.Add(currentYY + "/SU");
            cbTerm.Items.Add(currentYY + "/FA");
            cbTerm.Items.Add((yyInt + 1).ToString() + "/SP");

            if (currentYear.Month < 3)
                cbTerm.SelectedIndex = 0;

            else if (currentYear.Month <= 6)
                cbTerm.SelectedIndex = 1;

            else if (currentYear.Month <= 9)
                cbTerm.SelectedIndex = 2;

            else
                cbTerm.SelectedIndex = 3;
        }
    }
}
