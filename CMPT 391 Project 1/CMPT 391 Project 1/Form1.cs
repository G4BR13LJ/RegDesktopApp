using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT_391_Project_1
{
    public partial class Form1 : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public Form1()
        {
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "StudentLogin";
            myCommand.Parameters.Clear();
            myCommand.Parameters.AddWithValue("@SID", Username.Text);
            myReader = myCommand.ExecuteReader();

            if (myReader.HasRows)
            {
                while (myReader.Read())
                {
                    string studentFName = myReader["FirstName"].ToString();
                    string studentLName = myReader["LastName"].ToString();
                    string studentID = myReader["Student_ID"].ToString();

                    HomePage main = new HomePage(Int32.Parse(studentID));
                    main.GetStudentInfo(studentFName, studentLName, studentID);
                    main.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid Student");
            }

            myReader.Close();

        }
    }
}
