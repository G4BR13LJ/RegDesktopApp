using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace CMPT_391_Project_1
{   
    public partial class HomePage : Form
    {
        public SqlConnection myConnection;
        public SqlCommand enrollCommand;
        public SqlCommand removeFromCartCommand;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public SqlDataReader myRemoveReader;
        public int ClassListIndex = 0;
        public int studentID;
        public string selectedCourseID;
        public int selectedSectionID;
        public HomePage(int sID)
        {
            InitializeComponent();
            RemoveClass.Hide();
            AddToCart.Hide();
            String connectionString = "Server = DESKTOP-S3E6JLP\\MSSQLSERVER01; Database = University; Trusted_Connection = yes; ";
            //String connectionString = "Server = localhost; Database = University; Trusted_Connection = yes; ";
            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                enrollCommand = new SqlCommand();
                enrollCommand.Connection = myConnection;
                removeFromCartCommand = new SqlCommand();
                removeFromCartCommand.Connection = myConnection;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
            studentID = sID;

            // Add all courses to course table
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "FillClassTablesF";
            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                string courseID = myReader["Course_ID"].ToString();
                string sectionID = myReader["Section_ID"].ToString();
                string courseInfo = myReader["Course_ID"].ToString() + " Section: " + myReader["Section_ID"].ToString() + " " + myReader["Name"].ToString() + " " + myReader["Dept_Name"].ToString();
                ClassListBox.Items.Add(new Course_Info(courseID, sectionID, courseInfo));
            }

            myReader.Close();
            generateCart(sID);


        }
        public class Course_Info
        {
            public string CourseID { get; set; }
            public string SectionID { get; set; }
            public string FullInfo { get; set; }

            public Course_Info(string CourseID, string SectionID, string FullInfo)
            {
                this.CourseID = CourseID;
                this.SectionID = SectionID;
                this.FullInfo = FullInfo;
            }
            public override string ToString()
            {
                return FullInfo;
            }
        }
        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SemesterSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ClassSearch_Click(object sender, EventArgs e)
        {
            ClassListBox.Items.Clear();
            ClassListIndex = 0;
            myCommand.CommandType = CommandType.StoredProcedure;

            // Get info from fall or winter courses
            if (SemesterSelect.SelectedItem != null && SemesterSelect.SelectedItem.ToString() == "Winter")
            {
                myCommand.CommandText = "FillClassTablesW";
                //MessageBox.Show("Winter Selected");
            }
            else
            {
                myCommand.CommandText = "FillClassTablesF";
                //MessageBox.Show("Fall Selected");
            }
            myCommand.Parameters.Clear();
            myReader = myCommand.ExecuteReader();

            // Add each course to course table
            while (myReader.Read())
            {
                string courseID = myReader["Course_ID"].ToString();
                string sectionID = myReader["Section_ID"].ToString();
                string courseInfo = myReader["Course_ID"].ToString() + " Section: " + myReader["Section_ID"].ToString() + " " + myReader["Name"].ToString() + " " + myReader["Dept_Name"].ToString();

                // Only add to table if it matches search criteria
                if (courseInfo.Contains(TextSearch.Text))
                {
                    ClassListBox.Items.Add(new Course_Info(courseID, sectionID, courseInfo));

                }
            }
            myReader.Close();
        }

        public void GetStudentInfo(string StudentFName, string StudentLName, string studentID)
        {
            // Display student info
            StudentName.Text = StudentFName + " " + StudentLName;
            StudentID.Text = studentID;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CartBox_Click(object sender, EventArgs e)
        {
            if (CartBox.SelectedItem != null)
            {
                Course_Info selectedSection = CartBox.SelectedItem as Course_Info;
                SelectedCourse.Text = selectedSection.CourseID;
                Section.Text = selectedSection.SectionID;

                // Get info from fall or winter courses
                myCommand.CommandType = CommandType.StoredProcedure;
                if (SemesterSelect.SelectedItem != null && SemesterSelect.SelectedItem.ToString() == "Winter")
                {
                    myCommand.CommandText = "SectionSearchW";
                }
                else
                {
                    myCommand.CommandText = "SectionSearchF";
                }

                // Add course specific parameters
                myCommand.Parameters.Clear();
                myCommand.Parameters.AddWithValue("@SecID", selectedSection.SectionID);
                myCommand.Parameters.AddWithValue("@CouID", selectedSection.CourseID);
                myReader = myCommand.ExecuteReader();

                // Add course to course info table
                while (myReader.Read())
                {
                    ClassName.Text = myReader["Name"].ToString() + " " + myReader["Dept_Name"].ToString();
                    Semester.Text = myReader["Semester"].ToString();
                    Year.Text = myReader["Year"].ToString();
                    Capacity.Text = myReader["Enrolled"].ToString() + "/" + myReader["Capacity"].ToString();
                    Time.Text = myReader["Time_Start"].ToString() + " - " + myReader["Time_End"].ToString();
                    Instructor.Text = myReader["First_Name"].ToString() + " " + myReader["Last_Name"].ToString(); ;
                    if ((int)myReader["Enrolled"] >= (int)myReader["Capacity"])
                    {
                        AddToCart.Hide();
                    }
                }
                myReader.Close();
                myCommand.Parameters.Clear();
                AddToCart.Hide();
                RemoveClass.Show();
            }
        }

        private void ClassListBox_Click(object sender, EventArgs e)
        {
            if (ClassListBox.SelectedItem != null)
            {
                Course_Info selectedSection = ClassListBox.SelectedItem as Course_Info;
                SelectedCourse.Text = selectedSection.CourseID;
                Section.Text = selectedSection.SectionID;

                // Get info from fall or winter courses
                myCommand.CommandType = CommandType.StoredProcedure;
                if (SemesterSelect.SelectedItem != null && SemesterSelect.SelectedItem.ToString() == "Winter")
                {
                    myCommand.CommandText = "SectionSearchW";
                }
                else
                {
                    myCommand.CommandText = "SectionSearchF";
                }

                // Add course specific parameters
                myCommand.Parameters.Clear();
                myCommand.Parameters.AddWithValue("@SecID", selectedSection.SectionID);
                myCommand.Parameters.AddWithValue("@CouID", selectedSection.CourseID);
                myReader = myCommand.ExecuteReader();

                // Add course to course info table
                while (myReader.Read())
                {
                    ClassName.Text = myReader["Name"].ToString() + " " + myReader["Dept_Name"].ToString();
                    Semester.Text = myReader["Semester"].ToString();
                    Year.Text = myReader["Year"].ToString();
                    Capacity.Text = myReader["Enrolled"].ToString() + "/" + myReader["Capacity"].ToString();
                    Time.Text = myReader["Time_Start"].ToString() + " - " + myReader["Time_End"].ToString();
                    Instructor.Text = myReader["First_Name"].ToString() + " " + myReader["Last_Name"].ToString(); ;

                }
                selectedCourseID = selectedSection.CourseID;
                selectedSectionID = int.Parse(selectedSection.SectionID);

                myReader.Close();
                myCommand.Parameters.Clear();
                AddToCart.Show();
                RemoveClass.Hide();

            }
        }

        private void generateCart(int sID)
        {
            // Empty cart table
            CartBox.Items.Clear();

            // Get cart info for student
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "QueryCart";

            myCommand.Parameters.Clear();
            myCommand.Parameters.AddWithValue("@SID", sID);
            myReader = myCommand.ExecuteReader();

            // Fill cart table
            while (myReader.Read())
            {

              string cartCourseId = myReader["Course_ID"].ToString();
              string cartSectionId = myReader["Section_ID"].ToString();
              string cartCourseInfo = myReader["Course_ID"].ToString() + " Section: " + myReader["Section_ID"].ToString();
              CartBox.Items.Add(new Course_Info(cartCourseId, cartSectionId, cartCourseInfo));
            }
            
            myReader.Close();
        }

        private void Enroll_Click(object sender, EventArgs e)
        {
            // --- 1st, query the current students cart, iterate ovr courses in cart, attempt to enroll in each course in cart
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "QueryCart";
            myCommand.Parameters.Clear();

            myCommand.Parameters.AddWithValue("@SID", studentID);
            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                // grab needed paramters for enrolling procedure from the reader that queries the cart and grabs our needed params
                string courseID = myReader["Course_ID"].ToString();
                string semester = myReader["Semester"].ToString();
                int sectionID = int.Parse(myReader["Section_ID"].ToString());
                int year = int.Parse(myReader["Year"].ToString());

                // Prepare new command for the stored procedure to enroll into a class
                enrollCommand.CommandType = CommandType.StoredProcedure;
                enrollCommand.CommandText = "txEnrollClass";
                enrollCommand.Parameters.Clear();

                enrollCommand.Parameters.AddWithValue("@StudentID", studentID);
                enrollCommand.Parameters.AddWithValue("@SectionID", sectionID);
                enrollCommand.Parameters.AddWithValue("@Semester", semester);
                enrollCommand.Parameters.AddWithValue("@Year", year);
                enrollCommand.Parameters.AddWithValue("@CourseID", courseID);

                myReader.Close();

                try
                {
                    enrollCommand.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show(courseID  + " is now full");
                }
                finally
                {
                    //------Delete the class from the current students cart------------
                    removeFromCartCommand.CommandType = CommandType.StoredProcedure;
                    removeFromCartCommand.CommandText = "RemoveFromCart";
                    removeFromCartCommand.Parameters.Clear();

                    //MessageBox.Show(studentID + " " + courseID);
                    removeFromCartCommand.Parameters.AddWithValue("@studentID", Int32.Parse(StudentID.Text));
                    removeFromCartCommand.Parameters.AddWithValue("@sectionID", sectionID);
                    removeFromCartCommand.Parameters.AddWithValue("@semester", semester);
                    removeFromCartCommand.Parameters.AddWithValue("@year", year);
                    removeFromCartCommand.Parameters.AddWithValue("@courseID", courseID);
                    myRemoveReader = removeFromCartCommand.ExecuteReader();
                    myRemoveReader.Close();

                    // Reopen the DataReader for the next iteration of the loop and to grab the next class from the cart to enroll into
                    myCommand.Parameters.Clear();
                    myCommand.Parameters.AddWithValue("@SID", studentID);
                    myReader = myCommand.ExecuteReader();
                }
            }

            myReader.Close();
            generateCart(studentID);
        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            Course_Info selectedSection = ClassListBox.SelectedItem as Course_Info;

            myReader.Close();
            // Check if course is already in cart
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "Check_Course_In_Cart";
            myCommand.Parameters.Clear();
            myCommand.Parameters.AddWithValue("@Student_ID", StudentID.Text);
            myCommand.Parameters.AddWithValue("@Course_ID_to_take", selectedSection.CourseID);
            myReader = myCommand.ExecuteReader();

            if (myReader.HasRows)
            {
                myReader.Read();
                MessageBox.Show("Course already in cart.");
                myReader.Close();
            }
            else
            {
                myReader.Close();

                //Check if taken
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.CommandText = "Check_Taken";
                myCommand.Parameters.Clear();
                myCommand.Parameters.AddWithValue("@Student_ID", Int32.Parse(StudentID.Text));
                myCommand.Parameters.AddWithValue("@Course_ID_to_take", selectedSection.CourseID);
                myCommand.Parameters.AddWithValue("@Semester", Semester.Text);
                myCommand.Parameters.AddWithValue("@Year", Int32.Parse(Year.Text));
                myCommand.Parameters.AddWithValue("@Section_ID", Int32.Parse(Section.Text));
                myReader = myCommand.ExecuteReader();

                if (myReader.HasRows)
                {
                    myReader.Read();
                    MessageBox.Show($"You have already taken {myReader["Course_ID"].ToString()}.");
                    myReader.Close();
                }
                else
                {
                    myReader.Close();

                    //Check if another taken class is in the timeslot
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.CommandText = "Check_Taken_TimeSlot";
                    myCommand.Parameters.Clear();
                    myCommand.Parameters.AddWithValue("@Student_ID", Int32.Parse(StudentID.Text));
                    myCommand.Parameters.AddWithValue("@Course_ID_to_take", selectedSection.CourseID);
                    myCommand.Parameters.AddWithValue("@Semester", Semester.Text);
                    myCommand.Parameters.AddWithValue("@Year", Int32.Parse(Year.Text));
                    myCommand.Parameters.AddWithValue("@Section_ID_to_take", Int32.Parse(Section.Text));
                    myReader = myCommand.ExecuteReader();

                    if (!myReader.HasRows)
                    {
                        MessageBox.Show("You are already taking a class in that timeslot.");
                        myReader.Close();
                    }
                    else
                    {
                        myReader.Close();
                        // Check to see if student has pre-requisites for course

                        // check if sem is fall winter, branch on result
                        myCommand.CommandType = CommandType.StoredProcedure;
                        if (Semester.Text == "Winter"){
                            myCommand.CommandText = "Check_Pre_Req_Winter";
                        }
                        else
                        {
                            myCommand.CommandText = "Check_Pre_Req_Fall";
                        }
                        myCommand.Parameters.Clear();
                        myCommand.Parameters.AddWithValue("@Student_ID", StudentID.Text);
                        myCommand.Parameters.AddWithValue("@Course_ID_to_take", selectedSection.CourseID);
                        myCommand.Parameters.AddWithValue("@Year", Int32.Parse(Year.Text));
                        myReader = myCommand.ExecuteReader();
                            if (myReader.HasRows)
                            {
                                myReader.Read();
                                MessageBox.Show($"You are missing a prereq: {myReader["Pre_Req_Course_ID"].ToString()}.");
                                myReader.Close();
                            }
                            else
                            {
                                myReader.Close();

                                // Check to see if there are time conflicts with other courses in cart
                                myCommand.CommandType = CommandType.StoredProcedure;
                                myCommand.CommandText = "CheckTimeSlot";
                                myCommand.Parameters.Clear();
                                myCommand.Parameters.AddWithValue("@Semester", Semester.Text);
                                myCommand.Parameters.AddWithValue("@Year", Year.Text);
                                myCommand.Parameters.AddWithValue("@Section_ID", Section.Text);
                                myCommand.Parameters.AddWithValue("@Course_ID", selectedSection.CourseID);
                                myCommand.Parameters.AddWithValue("@Student_ID", StudentID.Text);

                                myReader = myCommand.ExecuteReader();
                                if (myReader.HasRows)
                                {
                                    myReader.Read();
                                    MessageBox.Show($"This course conflicts with another course in the cart.");
                                    myReader.Close();
                                }
                                else
                                {
                                    // Add course to cart
                                    myReader.Close();
                                    myCommand.CommandType = CommandType.StoredProcedure;
                                    myCommand.CommandText = "AddToCart";
                                    myCommand.Parameters.Clear();
                                    myCommand.Parameters.AddWithValue("@studentID", Int32.Parse(StudentID.Text));
                                    myCommand.Parameters.AddWithValue("@sectionID", Int32.Parse(Section.Text));
                                    myCommand.Parameters.AddWithValue("@semester", Semester.Text);
                                    myCommand.Parameters.AddWithValue("@year", Int32.Parse(Year.Text));
                                    myCommand.Parameters.AddWithValue("@courseID", selectedSection.CourseID);
                                    myReader = myCommand.ExecuteReader();
                                    myReader.Close();

                                    generateCart(Int32.Parse(StudentID.Text));

                            }
                        }
                    }
                }
            }
        }

        private void RemoveClass_Click(object sender, EventArgs e)
        {
            Course_Info selectedSection = ClassListBox.SelectedItem as Course_Info;

            // Remove course from cart
            myReader.Close();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "RemoveFromCart";
            myCommand.Parameters.Clear();
            myCommand.Parameters.AddWithValue("@studentID", Int32.Parse(StudentID.Text));
            myCommand.Parameters.AddWithValue("@sectionID", Int32.Parse(Section.Text));
            myCommand.Parameters.AddWithValue("@semester", Semester.Text);
            myCommand.Parameters.AddWithValue("@year", Int32.Parse(Year.Text));
            myCommand.Parameters.AddWithValue("@courseID", SelectedCourse.Text);
            myReader = myCommand.ExecuteReader();
            myReader.Close();

            generateCart(Int32.Parse(StudentID.Text));

            // Remove course from course info page
            RemoveClass.Hide();
            SelectedCourse.Text = null;
            Section.Text = null;
            ClassName.Text = null;
            Semester.Text = null;
            Year.Text = null;
            Capacity.Text = null;
            Time.Text = null;
            Instructor.Text = null;
        }

        private void ViewScheduleBtn_Click(object sender, EventArgs e)
        {
            ViewSchedule scheduleForm = new ViewSchedule(studentID);

            // Display the form as a modal dialog (pops up on top and blocks input to other forms)
            scheduleForm.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
    

}
