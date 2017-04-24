
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
    public partial class frmMain : Form
    {
        // Declare class-wide variables
        string connectionString;
        SqlConnection connection;

        string mode = "";

        const string exampleName = "First";
        const string exampleAddress = "Street";
        const string exampleAddressLine2 = "Apt, Room, Building (optional)";
        const string exampleCity = "City";
        const string exampleZip = "Zip Code";
        const string examplePhone = "XXX-XXX-XXXX";
        const string exampleLastName = "Last";
        const string examplePhoneExt = "Ext (optional)";
        const string exampleMonth = "MM";
        const string exampleDay = "DD";
        const string exampleYear = "YYYY";
        const string exampleState = "State";

        int maxYear, minYear;




        public frmMain()
        {
            InitializeComponent();

            // Initialize connectionString
            connectionString = ConfigurationManager.ConnectionStrings["StudentDB.Properties.Settings.RecordsConnectionString"].ConnectionString;


        }


        private void getStudentInfo()
        {
            try
            {
                // create reference for database WHERE clause
                string selected = lstStudents.Text;

                // NOTE: using() will automatically dispose objects since they conform to IDisposable
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand commandId = new SqlCommand("SELECT Id FROM Student WHERE Name = @namestring", connection))
                using (SqlCommand commandFirstName = new SqlCommand("SELECT FirstName FROM Student WHERE Name = @namestring", connection))
                using (SqlCommand commandLastName = new SqlCommand("SELECT LastName FROM Student WHERE Name = @namestring", connection))
                using (SqlCommand commandAddress = new SqlCommand("SELECT AddressLine1 FROM Student WHERE Name = @namestring", connection))
                using (SqlCommand commandAddressLine2 = new SqlCommand("SELECT AddressLine2 FROM Student WHERE Name = @namestring", connection))
                using (SqlCommand commandCity = new SqlCommand("SELECT City FROM Student WHERE Name = @namestring", connection))
                using (SqlCommand commandState = new SqlCommand("SELECT State FROM Student WHERE Name = @namestring", connection))
                using (SqlCommand commandZip = new SqlCommand("SELECT Zip FROM Student WHERE Name = @namestring", connection))
                using (SqlCommand commandBirthdate = new SqlCommand("SELECT Birthdate FROM Student WHERE Name = @namestring", connection))
                using (SqlCommand commandPhone = new SqlCommand("SELECT Phone FROM Student WHERE Name = @namestring", connection))
                using (SqlCommand commandPhoneExt = new SqlCommand("SELECT PhoneExt FROM Student WHERE Name = @namestring", connection))
                {
                    // NOTE: A SqlDataAdapter will call connection.open() when connection is passed to the adapter

                    connection.Open();



                    commandId.Parameters.AddWithValue("@namestring", selected);
                    commandFirstName.Parameters.AddWithValue("@namestring", selected);
                    commandLastName.Parameters.AddWithValue("@namestring", selected);
                    commandAddress.Parameters.AddWithValue("@namestring", selected);
                    commandAddressLine2.Parameters.AddWithValue("@namestring", selected);
                    commandCity.Parameters.AddWithValue("@namestring", selected);
                    commandState.Parameters.AddWithValue("@namestring", selected);
                    commandZip.Parameters.AddWithValue("@namestring", selected);
                    commandBirthdate.Parameters.AddWithValue("@namestring", selected);
                    commandPhone.Parameters.AddWithValue("@namestring", selected);
                    commandPhoneExt.Parameters.AddWithValue("@namestring", selected);







                    // test objects for null values before casting types
                    // set views to display the appropriate information

                    object objTest = objTest = commandId.ExecuteScalar();
                    if (objTest != DBNull.Value && objTest != null)
                    {
                        int id = (int)objTest;
                        lblId.Text = Convert.ToString((int)objTest);
                    }
                    else
                    {
                        lblId.Text = "";
                    }


                    objTest = commandFirstName.ExecuteScalar();
                    if (objTest != DBNull.Value)
                    {
                        txtStudentFirstName.Text = (string)objTest;
                    }
                    else
                    {
                        txtStudentFirstName.Clear();
                    }


                    objTest = commandLastName.ExecuteScalar();
                    if (objTest != DBNull.Value)
                    {
                        txtStudentLastName.Text = (string)objTest;
                    }
                    else
                    {
                        txtStudentLastName.Clear();
                    }


                    objTest = commandAddress.ExecuteScalar();
                    if (objTest != DBNull.Value)
                    {
                        txtStudentAddress.Text = (string)objTest;
                    }
                    else
                    {
                        txtStudentAddress.Clear();
                    }


                    objTest = commandAddressLine2.ExecuteScalar();
                    if (objTest != DBNull.Value)
                    {
                        txtStudentAddressLine2.Text = (string)objTest;
                    }
                    else
                    {
                        txtStudentAddressLine2.Clear();
                    }


                    objTest = commandCity.ExecuteScalar();
                    if (objTest != DBNull.Value)
                    {
                        txtStudentCity.Text = (string)objTest;
                    }
                    else
                    {
                        txtStudentCity.Clear();
                    }


                    objTest = commandState.ExecuteScalar();
                    if (objTest != DBNull.Value)
                    {
                        cbState.Text = (string)objTest;
                    }
                    else
                    {
                        cbState.Text = "";
                    }


                    objTest = commandZip.ExecuteScalar();
                    if (objTest != DBNull.Value)
                    {
                        txtStudentZip.Text = (string)objTest;
                    }
                    else
                    {
                        txtStudentZip.Clear();
                    }


                    objTest = commandBirthdate.ExecuteScalar();
                    if (objTest != DBNull.Value && objTest != null)
                    {
                        DateTime returnedBirthdate = (DateTime)commandBirthdate.ExecuteScalar();
                        cbDay.Text = returnedBirthdate.Day.ToString();
                        cbMonth.Text = returnedBirthdate.Month.ToString();
                        cbYear.Text = returnedBirthdate.Year.ToString();
                    }
                    else
                    {
                        cbDay.Text = "";
                        cbMonth.Text = "";
                        cbMonth.Text = "";
                    }


                    objTest = commandPhone.ExecuteScalar();
                    if (objTest != DBNull.Value)
                    {
                        txtStudentPhone.Text = (string)objTest;
                    }
                    else
                    {
                        txtStudentPhone.Clear();
                    }


                    objTest = commandPhoneExt.ExecuteScalar();
                    if (objTest != DBNull.Value)
                    {
                        txtStudentExt.Text = (string)objTest;
                    }
                    else
                    {
                        txtStudentExt.Clear();
                    }






                    //TODO: GPA














                    // Set appropriate display properties for lstStudents


                }
            }

            catch (SqlException sqlEx)
            {
                MessageBox.Show("Could not connect to Records Database! " + sqlEx.Message);
                connection.Close();
                return;

            }

            catch (NullReferenceException nrEx)
            {
                MessageBox.Show("Null value exception! " + nrEx);
                connection.Close();
                return;
            }
        }



        private void lblStudentName_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            populateStudents();

            // Sets available years for birthdate to be within a realistic range 
            // Sets max and min year at the class level for input validation
            maxYear = DateTime.Now.Year;
            minYear = maxYear - 120;
            for (int i = maxYear; i >= minYear; i--)
            {
                cbYear.Items.Add(i);
            }


        }


        /* This Function will populate lstStudents with student names */
        private void populateStudents()
        {
            // NOTE: using() will automatically dispose objects since they conform to IDisposable
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Student", connection))
            {
                // NOTE: A SqlDataAdapter will call connection.open() when connection is passed to the adapter

                // Create a DataTable object to hold student data in memory, and fill with the query results
                DataTable studentTable = new DataTable();
                adapter.Fill(studentTable);

                // Set appropriate display properties for lstStudents
                lstStudents.DisplayMember = "Name";
                lstStudents.ValueMember = "Id";
                lstStudents.DataSource = studentTable;

            }
        }


        /* This Function will make textboxes non-editable */
        private void disableFrmEntry()
        {
            txtStudentFirstName.ReadOnly = true;
            txtStudentLastName.ReadOnly = true;
            txtStudentAddress.ReadOnly = true;
            txtStudentAddressLine2.ReadOnly = true;
            txtStudentZip.ReadOnly = true;
            txtStudentCity.ReadOnly = true;
            cbState.Enabled = false;
            txtStudentPhone.ReadOnly = true;
            txtStudentExt.ReadOnly = true;
            cbState.Enabled = false;
            cbMonth.Enabled = false;
            cbDay.Enabled = false;
            cbYear.Enabled = false;

            lstStudents.Enabled = true;
            populateStudents();
            lstStudents.ClearSelected();
            
            btnAddStudent.Enabled = true;
            txtSearchStudent.Focus();
            lblId.Visible = true;
            lblStudentId.Text = "Student ID:";
            btnSaveChanges.Visible = false;
            btnCancel.Visible = false;
            lblGpa.Visible = true;
            lblStudentGpa.Visible = true;


            txtStudentFirstName.Clear();
            txtStudentLastName.Clear();
            txtStudentAddress.Clear();
            txtStudentAddressLine2.Clear();
            txtStudentZip.Clear();
            txtStudentCity.Clear();
            txtStudentPhone.Clear();
            txtStudentExt.Clear();

            cbMonth.Text = "";
            cbDay.Text = "";
            cbYear.Text = "";
            cbState.Text = "";

            
        }


        /* This Function will make textboxes editable */
        private void enableFrmEntry()
        {
            txtStudentFirstName.ReadOnly = false;
            txtStudentLastName.ReadOnly = false;
            txtStudentAddress.ReadOnly = false;
            txtStudentAddressLine2.ReadOnly = false;
            txtStudentZip.ReadOnly = false;
            txtStudentCity.ReadOnly = false;
            txtStudentPhone.ReadOnly = false;
            txtStudentExt.ReadOnly = false;
            cbState.Enabled = true;
            cbMonth.Enabled = true;
            cbDay.Enabled = true;
            cbYear.Enabled = true;



            if (mode == "add")
            {
                Font italic = new Font(Font, FontStyle.Italic);

                txtStudentFirstName.Font = italic;
                txtStudentFirstName.Text = exampleName;
                txtStudentFirstName.ForeColor = System.Drawing.Color.Gray;

                txtStudentLastName.Font = italic;
                txtStudentLastName.Text = exampleLastName;
                txtStudentLastName.ForeColor = System.Drawing.Color.Gray;

                txtStudentAddress.Font = italic;
                txtStudentAddress.Text = exampleAddress;
                txtStudentAddress.ForeColor = System.Drawing.Color.Gray;

                txtStudentAddressLine2.Font = italic;
                txtStudentAddressLine2.Text = exampleAddressLine2;
                txtStudentAddressLine2.ForeColor = System.Drawing.Color.Gray;

                txtStudentCity.Font = italic;
                txtStudentCity.Text = exampleCity;
                txtStudentCity.ForeColor = System.Drawing.Color.Gray;

                txtStudentZip.Font = italic;
                txtStudentZip.Text = exampleZip;
                txtStudentZip.ForeColor = System.Drawing.Color.Gray;


                txtStudentPhone.Font = italic;
                txtStudentPhone.Text = examplePhone;
                txtStudentPhone.ForeColor = System.Drawing.Color.Gray;

                txtStudentExt.Font = italic;
                txtStudentExt.Text = examplePhoneExt;
                txtStudentExt.ForeColor = System.Drawing.Color.Gray;


                italic.Dispose();

                lstStudents.ClearSelected();
                lstStudents.Enabled = false;

                lblGpa.Visible = false;
                lblStudentGpa.Visible = false;
                lblId.Visible = false;
                lblStudentId.Text = "Add Student";



                btnSaveChanges.Visible = true;
                btnSaveChanges.Enabled = true;
                btnSaveChanges.Text = "Add";
                btnCancel.Visible = true;
                btnCancel.Enabled = true;

                cbMonth.Visible = true;
                cbDay.Visible = true;
                cbYear.Visible = true;
                cbState.Visible = true;

                cbState.SelectedIndex = -1;
                cbState.Text = exampleState;
                cbDay.SelectedIndex = -1;
                cbDay.Text = exampleDay;
                cbMonth.SelectedIndex = -1;
                cbMonth.Text = exampleMonth;
                cbYear.SelectedIndex = -1;
                cbYear.Text = exampleYear;
            }

            else if (mode == "edit")
            {


                // set example text in case selected student has null values in these fields
                if (txtStudentAddressLine2.Text == "")
                {
                    Font italic = new Font(Font, FontStyle.Italic);
                    txtStudentAddressLine2.Font = italic;
                    txtStudentAddressLine2.Text = exampleAddressLine2;
                    txtStudentAddressLine2.ForeColor = System.Drawing.Color.Gray;
                    italic.Dispose();
                }

                if (txtStudentExt.Text == "")
                {
                    Font italic = new Font(Font, FontStyle.Italic);
                    txtStudentExt.Font = italic;
                    txtStudentExt.Text = examplePhoneExt;
                    txtStudentExt.ForeColor = System.Drawing.Color.Gray;
                    italic.Dispose();
                }







                lstStudents.Enabled = false;



                lblStudentId.Text = "Editing ID:";

                lblGpa.Hide();
                lblStudentGpa.Hide();

                btnAddStudent.Enabled = false;


                btnSaveChanges.Visible = true;
                btnSaveChanges.Enabled = true;
                btnSaveChanges.Text = "Save";
                btnCancel.Visible = true;
                btnCancel.Enabled = true;




            }

        }


        /* This event prepares the interface and sets the mode to Add */
        private void btnAddStudent_Click(object sender, EventArgs e)
        {

            // Set mode to be referenced by Save and Cancel buttons
            mode = "add";

            // Set view objects to the correct visibility
            enableFrmEntry();



        }





        /* This event removes example text from it's textbox on Focus */
        private void txtBox_Enter(object sender, EventArgs e)
        {
            if (mode != "")
            {
                if (sender.Equals(txtStudentFirstName))
                {
                    if (txtStudentFirstName.Text == exampleName)
                    {
                        txtStudentFirstName.Clear();
                        Font regular = new Font(Font, FontStyle.Regular);
                        txtStudentFirstName.Font = regular;
                        txtStudentFirstName.ForeColor = System.Drawing.SystemColors.WindowText;
                        regular.Dispose();
                    }
                }

                else if (sender.Equals(txtStudentLastName))
                {
                    if (txtStudentLastName.Text == exampleLastName)
                    {
                        txtStudentLastName.Clear();
                        Font regular = new Font(Font, FontStyle.Regular);
                        txtStudentLastName.Font = regular;
                        txtStudentLastName.ForeColor = System.Drawing.SystemColors.WindowText;
                        regular.Dispose();
                    }
                }

                else if (sender.Equals(txtStudentAddress))
                {
                    if (txtStudentAddress.Text == exampleAddress)
                    {
                        txtStudentAddress.Clear();
                        Font regular = new Font(Font, FontStyle.Regular);
                        txtStudentAddress.Font = regular;
                        txtStudentAddress.ForeColor = System.Drawing.SystemColors.WindowText;
                        regular.Dispose();
                    }
                }

                else if (sender.Equals(txtStudentAddressLine2))
                {
                    if (txtStudentAddressLine2.Text == exampleAddressLine2)
                    {
                        txtStudentAddressLine2.Clear();
                        Font regular = new Font(Font, FontStyle.Regular);
                        txtStudentAddressLine2.Font = regular;
                        txtStudentAddressLine2.ForeColor = System.Drawing.SystemColors.WindowText;
                        regular.Dispose();
                    }
                }

                else if (sender.Equals(txtStudentCity))
                {
                    if (txtStudentCity.Text == exampleCity)
                    {
                        txtStudentCity.Clear();
                        Font regular = new Font(Font, FontStyle.Regular);
                        txtStudentCity.Font = regular;
                        txtStudentCity.ForeColor = System.Drawing.SystemColors.WindowText;
                        regular.Dispose();
                    }
                }

                else if (sender.Equals(txtStudentZip))
                {
                    if (txtStudentZip.Text == exampleZip)
                    {
                        txtStudentZip.Clear();
                        Font regular = new Font(Font, FontStyle.Regular);
                        txtStudentZip.Font = regular;
                        txtStudentZip.ForeColor = System.Drawing.SystemColors.WindowText;
                        regular.Dispose();
                    }
                }

                else if (sender.Equals(txtStudentPhone))
                {
                    if (txtStudentPhone.Text == examplePhone)
                    {
                        txtStudentPhone.Clear();
                        Font regular = new Font(Font, FontStyle.Regular);
                        txtStudentPhone.Font = regular;
                        txtStudentPhone.ForeColor = System.Drawing.SystemColors.WindowText;
                        regular.Dispose();
                    }
                }

                else if (sender.Equals(txtStudentExt))
                {
                    if (txtStudentExt.Text == examplePhoneExt)
                    {
                        txtStudentExt.Clear();
                        Font regular = new Font(Font, FontStyle.Regular);
                        txtStudentExt.Font = regular;
                        txtStudentExt.ForeColor = System.Drawing.SystemColors.WindowText;
                        regular.Dispose();
                    }
                }
            }


        }



        /* This event adds example text to it's textbox on leaving Focus if textbox is empty */
        private void txtBox_Leave(object sender, EventArgs e)
        {
            if (mode != "")
            {
                if (sender.Equals(txtStudentFirstName))
                {
                    if (txtStudentFirstName.Text == "")
                    {
                        Font italic = new Font(Font, FontStyle.Italic);
                        txtStudentFirstName.Font = italic;
                        txtStudentFirstName.Text = exampleName;
                        txtStudentFirstName.ForeColor = System.Drawing.Color.Gray;
                        italic.Dispose();
                    }
                }

                else if (sender.Equals(txtStudentLastName))
                {
                    if (txtStudentLastName.Text == "")
                    {
                        Font italic = new Font(Font, FontStyle.Italic);
                        txtStudentLastName.Font = italic;
                        txtStudentLastName.Text = exampleLastName;
                        txtStudentLastName.ForeColor = System.Drawing.Color.Gray;
                        italic.Dispose();
                    }
                }

                else if (sender.Equals(txtStudentAddress))
                {
                    if (txtStudentAddress.Text == "")
                    {
                        Font italic = new Font(Font, FontStyle.Italic);
                        txtStudentAddress.Font = italic;
                        txtStudentAddress.Text = exampleAddress;
                        txtStudentAddress.ForeColor = System.Drawing.Color.Gray;
                        italic.Dispose();
                    }
                }

                else if (sender.Equals(txtStudentAddressLine2))
                {
                    if (txtStudentAddressLine2.Text == "")
                    {
                        Font italic = new Font(Font, FontStyle.Italic);
                        txtStudentAddressLine2.Font = italic;
                        txtStudentAddressLine2.Text = exampleAddressLine2;
                        txtStudentAddressLine2.ForeColor = System.Drawing.Color.Gray;
                        italic.Dispose();
                    }
                }

                else if (sender.Equals(txtStudentCity))
                {
                    if (txtStudentCity.Text == "")
                    {
                        Font italic = new Font(Font, FontStyle.Italic);
                        txtStudentCity.Font = italic;
                        txtStudentCity.Text = exampleCity;
                        txtStudentCity.ForeColor = System.Drawing.Color.Gray;
                        italic.Dispose();
                    }
                }

                else if (sender.Equals(txtStudentZip))
                {
                    if (txtStudentZip.Text == "")
                    {
                        Font italic = new Font(Font, FontStyle.Italic);
                        txtStudentZip.Font = italic;
                        txtStudentZip.Text = exampleZip;
                        txtStudentZip.ForeColor = System.Drawing.Color.Gray;
                        italic.Dispose();
                    }
                }

                else if (sender.Equals(txtStudentPhone))
                {
                    if (txtStudentPhone.Text == "")
                    {
                        Font italic = new Font(Font, FontStyle.Italic);
                        txtStudentPhone.Font = italic;
                        txtStudentPhone.Text = examplePhone;
                        txtStudentPhone.ForeColor = System.Drawing.Color.Gray;
                        italic.Dispose();
                    }
                }

                else if (sender.Equals(txtStudentExt))
                {
                    if (txtStudentExt.Text == "")
                    {
                        Font italic = new Font(Font, FontStyle.Italic);
                        txtStudentExt.Font = italic;
                        txtStudentExt.Text = examplePhoneExt;
                        txtStudentExt.ForeColor = System.Drawing.Color.Gray;
                        italic.Dispose();
                    }
                }
            }

        }











        /* This event Adds or Edits a student in the database */
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {



            // Perform thorough user input validation before attempting to query the database
            if (txtStudentFirstName.Text.Length > 50)
            {
                txtStudentFirstName.Focus();
                MessageBox.Show("Student's first name can not exceed 50 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            else if (txtStudentLastName.Text.Length > 50)
            {
                txtStudentLastName.Focus();
                MessageBox.Show("Student's last name can not exceed 50 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            else if (txtStudentAddress.Text.Length > 75)
            {
                txtStudentAddress.Focus();
                MessageBox.Show("Address line 1 can not exceed 75 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            else if (txtStudentAddressLine2.Text.Length > 75)
            {
                txtStudentAddressLine2.Focus();
                MessageBox.Show("Address line 2 can not exceed 75 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            else if (txtStudentCity.Text.Length > 75)
            {
                txtStudentCity.Focus();
                MessageBox.Show("City name can not exceed 75 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            else if (txtStudentZip.Text.Length > 5 || txtStudentZip.Text.Length < 5)
            {
                txtStudentZip.Focus();
                MessageBox.Show("Zip code must be 5 digits.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            else if (txtStudentPhone.Text.Length < 12)
            {
                txtStudentPhone.Focus();
                MessageBox.Show("Phone number must be 10 digits.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            else if (cbState.Text == exampleState)
            {
                cbState.Focus();
                MessageBox.Show("A state must be selected", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            else if (cbMonth.Text == exampleMonth)
            {
                cbMonth.Focus();
                MessageBox.Show("A month must be selected", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            else if (cbDay.Text == exampleDay)
            {
                cbDay.Focus();
                MessageBox.Show("A day must be selected", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            else if (cbYear.Text == exampleYear)
            {
                cbYear.Focus();
                MessageBox.Show("A year must be selected", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            else if (Convert.ToUInt16(cbMonth.Text) > 12)
            {
                cbMonth.Focus();
                MessageBox.Show("A month within 1-12 must be selected", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            else if (Convert.ToUInt16(cbDay.Text) > 31)
            {
                cbMonth.Focus();
                MessageBox.Show("A month within 1-31 must be selected", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            else if (Convert.ToUInt16(cbDay.Text) == 31)
            {

                if (Convert.ToUInt16(cbDay.Text) == 4 || Convert.ToUInt16(cbDay.Text) == 6 || Convert.ToUInt16(cbDay.Text) == 9 || Convert.ToUInt16(cbDay.Text) == 11)
                {
                    cbDay.Focus();
                    MessageBox.Show("There are only 30 days in the month you have selected.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

            }

            else if (Convert.ToUInt16(cbMonth.Text) == 2)
            {


                if (Convert.ToUInt16(cbDay.Text) > 29)
                {
                    cbDay.Focus();
                    MessageBox.Show("There are only 29 days in the month you have selected.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

                else if (Convert.ToUInt16(cbDay.Text) == 29)
                {

                    if (!DateTime.IsLeapYear(Convert.ToUInt16(cbYear.Text)))
                    {
                        cbDay.Focus();
                        MessageBox.Show("Selected year is not a leap year. February can not have 29 days. ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                }
            }

            // TODO: Fix user input error for blank date
            // TODO: Create event to replace exampleState, day, month etc.. 
            // TODO: Create event to not allow numeric input on state



            else
            {

                // To make sure any potential example text does not show up in the dialog box
                string dialogExtension = "";
                if (txtStudentExt.Text != examplePhoneExt)
                {
                    dialogExtension = "ext " + txtStudentExt.Text;
                }

                string dialogAddressLine2 = "";
                if (txtStudentAddressLine2.Text != exampleAddressLine2 )
                {
                    dialogAddressLine2 = txtStudentAddressLine2.Text;
                }
                


                DialogResult confirmation = MessageBox.Show("Please confirm that your entries are correct.\n\n" +
                    "Name:\t" + txtStudentFirstName.Text + " " + txtStudentLastName.Text +
                    "\nAddress:\t" + txtStudentAddress.Text + ", " + dialogAddressLine2 + 
                    "\nCity:\t" + txtStudentCity.Text +
                    "\nState:\t" + cbState.Text +
                    "\nZip:\t" + txtStudentZip.Text +
                    "\nBirthdate:\t" + cbMonth.Text + "/" + cbDay.Text + "/" + cbYear.Text +
                    "\nPhone:\t" + txtStudentPhone.Text + " " + dialogExtension
                    , "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (confirmation == DialogResult.OK)
                {
                    try
                    {

                        string query;

                        if (mode == "add")
                        {
                            query = "INSERT INTO Student VALUES (@StudentFullName, @StudentFirstName, @StudentLastName, @StudentAddress, @StudentAddressLine2," +
                            " @StudentCity, @StudentState, @StudentZip, @StudentBirthdate, @StudentPhone, @StudentExt, @StudentGpa)";
                        }

                        else
                        {
                            query = "UPDATE Student SET Name = @StudentFullName, FirstName = @StudentFirstName, LastName = @StudentLastName, AddressLine1 = @StudentAddress, AddressLine2 = @StudentAddressLine2," +
                            " City = @StudentCity, State = @StudentState, Zip = @StudentZip, Birthdate = @StudentBirthdate, Phone = @StudentPhone, PhoneExt = @StudentExt" +
                            " WHERE Id = @StudentId";
                        }



                        // NOTE: using() will automatically dispose objects since they conform to IDisposable
                        using (connection = new SqlConnection(connectionString))
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {




                            // format strings to conform to expected database parameters
                            // NOTE: Other data formatting is validated elsewhere
                            string fullName = txtStudentLastName.Text + ", " + txtStudentFirstName.Text;
                            string birthDate = cbYear.Text + "-" + cbMonth.Text + "-" + cbDay.Text;


                            // Set up missing parameters per needed query 
                            if (mode == "add")
                            {
                                command.Parameters.AddWithValue("@StudentGpa", DBNull.Value);
                            }

                            else
                            {
                                command.Parameters.AddWithValue("@StudentId", lblId.Text);
                            }


                            // Feed database null values if needed
                            if (txtStudentAddressLine2.Text == exampleAddressLine2 || txtStudentAddressLine2.Text == "")
                            {
                                command.Parameters.AddWithValue("@StudentAddressLine2", DBNull.Value);
                            }

                            else
                            {
                                command.Parameters.AddWithValue("@StudentAddressLine2", txtStudentAddressLine2.Text);
                            }

                            if (txtStudentExt.Text == examplePhoneExt || txtStudentAddressLine2.Text == "")
                            {
                                command.Parameters.AddWithValue("@StudentExt", DBNull.Value);
                            }

                            else
                            {
                                command.Parameters.AddWithValue("@StudentExt", txtStudentExt.Text);
                            }



                            command.Parameters.AddWithValue("@StudentFullName", fullName);
                            command.Parameters.AddWithValue("@StudentFirstName", txtStudentFirstName.Text);
                            command.Parameters.AddWithValue("@StudentLastName", txtStudentLastName.Text);
                            command.Parameters.AddWithValue("@StudentAddress", txtStudentAddress.Text);
                            command.Parameters.AddWithValue("@StudentCity", txtStudentCity.Text);
                            command.Parameters.AddWithValue("@StudentState", cbState.Text);
                            command.Parameters.AddWithValue("@StudentZip", txtStudentZip.Text);
                            command.Parameters.AddWithValue("@StudentBirthdate", birthDate);
                            command.Parameters.AddWithValue("@StudentPhone", txtStudentPhone.Text);





                            connection.Open();
                            command.ExecuteNonQuery();

                            disableFrmEntry();
                            mode = "";
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
                




        }







        /* This event queries database and updates form views with the selected student's information */
        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable/Disable appropriate buttons when a student is/isn't selected in the list
            // NOTE: -1 represents no index selected
            if (lstStudents.SelectedIndex == -1)
            {
                btnEditStudent.Enabled = false;
                btnViewCourse.Enabled = false;
            }
            else
            {
                btnEditStudent.Enabled = true;
                btnViewCourse.Enabled = true;
            }



            getStudentInfo();



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //TODO: Can condense these to no ifs?

            if (mode == "add")
            {
                txtSearchStudent.Focus();

                lstStudents.ClearSelected();

                /*
                txtStudentFirstName.Text = "";
                txtStudentLastName.Text = "";
                txtStudentAddress.Text = "";
                txtStudentAddressLine2.Text = "";
                txtStudentCity.Text = "";
                txtStudentZip.Text = "";
                txtStudentPhone.Text = "";
                txtStudentExt.Text = "";
                 */

                disableFrmEntry();







                btnSaveChanges.Visible = false;
                btnCancel.Visible = false;

                lstStudents.ClearSelected();
                lstStudents.Enabled = true;

                lblStudentId.Text = "Student ID:";
                lblStudentGpa.Visible = true;
                lblGpa.Visible = true;





                mode = "";

            }

            else if (mode == "edit")
            {
                txtSearchStudent.Focus();
                disableFrmEntry();

                btnSaveChanges.Visible = false;
                btnCancel.Visible = false;

                lstStudents.ClearSelected();
                lstStudents.Enabled = true;

                lblStudentId.Text = "Student ID:";
                lblStudentGpa.Visible = true;
                lblGpa.Visible = true;
            }
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            mode = "edit";

            enableFrmEntry();




        }



        /* This event prevents non-numeric input and formats text for a phone number */
        private void txtStudentPhone_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Deny keypress on invalid input
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (txtStudentPhone.TextLength >= 12 && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {

                // Accept keypress and format text to a valid phone number format


                if (txtStudentPhone.TextLength == 3 && !Char.IsControl(e.KeyChar))
                {
                    txtStudentPhone.AppendText("-");
                }
                else if (txtStudentPhone.TextLength == 7 && !Char.IsControl(e.KeyChar))
                {
                    txtStudentPhone.AppendText("-");
                }

                if (txtStudentPhone.TextLength == 9 && Char.IsControl(e.KeyChar))
                {
                    txtStudentPhone.Text = txtStudentPhone.Text.Remove(txtStudentPhone.Text.Length - 1);
                    txtStudentPhone.SelectionStart = txtStudentPhone.TextLength + 1;
                }
                else if (txtStudentPhone.TextLength == 5 && Char.IsControl(e.KeyChar))
                {
                    txtStudentPhone.Text = txtStudentPhone.Text.Remove(txtStudentPhone.Text.Length - 1);
                    txtStudentPhone.SelectionStart = txtStudentPhone.TextLength + 1;
                }



            }
        }

        private void txtStudentZip_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Prevent keypress unless it is a digit or control
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (txtStudentZip.TextLength >= 5 && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }





        private void cb_numKeyPress(object sender, KeyPressEventArgs e)
        {
            // Prevent keypress unless it is a digit or control
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            else
            {
                if (sender.Equals(cbDay))
                {
                    if (cbDay.Text.Length >= 2 && !Char.IsControl(e.KeyChar) && cbDay.SelectedText.Length < 1)
                    {
                        e.Handled = true;
                    }
                }

                else if (sender.Equals(cbMonth))
                {
                    if (cbMonth.Text.Length >= 2 && !Char.IsControl(e.KeyChar) && cbMonth.SelectedText.Length < 1)
                    {
                        e.Handled = true;
                    }
                }

                else if (sender.Equals(cbYear))
                {
                    if (cbYear.Text.Length >= 4 && !Char.IsControl(e.KeyChar) && cbYear.SelectedText.Length < 1)
                    {
                        e.Handled = true;
                    }
                }
            }


        }

        private void cb_stateKeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
