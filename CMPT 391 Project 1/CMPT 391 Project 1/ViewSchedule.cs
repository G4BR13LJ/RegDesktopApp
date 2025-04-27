using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;
using static CMPT_391_Project_1.HomePage;

namespace CMPT_391_Project_1
{
    public partial class ViewSchedule : Form
    {
        public int student_ID;
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public ViewSchedule(int sID)
        {
            student_ID = sID;
            InitializeComponent();
            String connectionString = "Server = DESKTOP-S3E6JLP\\MSSQLSERVER01; Database = University; Trusted_Connection = yes; ";
            //String connectionString = "Server = localhost; Database = University; Trusted_Connection = yes; ";
            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
            // Empty cart table
            fallScheduleBox.Items.Clear();
            winterScheduleBox.Items.Clear();

            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "generateFallSchedule";

            myCommand.Parameters.Clear();
            myCommand.Parameters.AddWithValue("@SID", student_ID);
            myReader = myCommand.ExecuteReader();
            //string sidstring = student_ID.ToString();
            //MessageBox.Show(sidstring);
            // Fill cart table

            while (myReader.Read())
            {
                string cartCourseId = myReader["Course_ID"].ToString();
                string cartTimeStart = myReader["Time_Start"].ToString();
                string cartTimeEnd = myReader["Time_End"].ToString();
                string entry = cartCourseId +  "    " + cartTimeStart + " - " + cartTimeEnd;
                fallScheduleBox.Items.Add(entry);
            }

            myReader.Close();
            //-------------------------------------------------------
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "generateWinterSchedule";

            myCommand.Parameters.Clear();
            myCommand.Parameters.AddWithValue("@SID", student_ID);
            myReader = myCommand.ExecuteReader();
            //string sidstring = student_ID.ToString();
            //MessageBox.Show(sidstring);
            // Fill cart table

            while (myReader.Read())
            {
                string cartCourseId = myReader["Course_ID"].ToString();
                string cartTimeStart = myReader["Time_Start"].ToString();
                string cartTimeEnd = myReader["Time_End"].ToString();
                string entry = cartCourseId + "    " + cartTimeStart + " - " + cartTimeEnd;
                winterScheduleBox.Items.Add(entry);
            }

            myReader.Close();
        }
        private void fallScheduleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void winterScheduleBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
