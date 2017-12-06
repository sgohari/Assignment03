using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp229_Assign03
{
    public partial class student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                BindList();
                CourseBindList();

            }

        }
        protected void StudentsList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            // Which button was clicked?
            if (e.CommandName == "MoreDetails")
            {

            }
            else if (e.CommandName == "Edit")
            {

                BindList();
            }
        }
        private void BindList()
        {
            //declearing variable to store StudenID and convert it to Int, than running the query. 
            int StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);
            // Define data objects. taken from demo codes
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            // Read the connection string from Web.config
            string connectionString = ConfigurationManager.ConnectionStrings["Students"].ConnectionString;
            // Initialize connection
            conn = new SqlConnection(connectionString);
            // Create command and queris
            comm = new SqlCommand("SELECT * FROM Students where StudentID="+StudentID,conn);
            // Enclose database code in Try-Catch-Finally
            try
            {
                // Open the connection
                conn.Open();
                // Execute the command
                reader = comm.ExecuteReader();
                // Bind the reader to the DataList
                GvStudent.DataSource = reader;
                GvStudent.DataBind();

                // Close the reader
                reader.Close();
            }
            finally
            {
                // Close the connection
                conn.Close();
            }
        }

        //Method for Binding data in Course page.
        private void CourseBindList()
        {
            //Variable for storing types and converting than setting it for query
            int StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);
            // Define data objects
            SqlConnection conn;
            SqlCommand comm;
         
            SqlDataReader reader;
            // Read the connection string from Web.config
            string connectionString = ConfigurationManager.ConnectionStrings["Students"].ConnectionString;
            // Initialize connection
            conn = new SqlConnection(connectionString);
            // Create command for database to be shown
            comm = new SqlCommand("SELECT * FROM Courses where CourseID IN (Select CourseID from Enrollments where StudentID=" + StudentID + ")", conn);
            //Enclose database code in Try - Catch - Finally
            try
            {
                // Open the connection
                conn.Open();
                // Execute the command
                reader = comm.ExecuteReader();
                // Bind the reader to the DataList
                GvCourseInStudentPage.DataSource = reader;
                GvCourseInStudentPage.DataBind();

                // Close the reader
                reader.Close();
            }
            finally
            {
                // Close the connection
                conn.Close();
            }
        }

        protected void GvStudent_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //declearing variable to store StudenID and convert it to Int, than running the query. 
            int StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);
            // Define data objects. taken from demo codes
            SqlConnection conn;
            SqlCommand comm;
            SqlCommand commTwo;
            SqlDataReader reader;
            SqlDataReader readerTwo;
            // Read the connection string from Web.config
            string connectionString = ConfigurationManager.ConnectionStrings["Students"].ConnectionString;
            // Initialize connection
            conn = new SqlConnection(connectionString);
            // Create command for deleting the reference
            commTwo = new SqlCommand("DELETE FROM Enrollments where StudentID=" + StudentID, conn);
           //command for deleting from student table.
            comm = new SqlCommand("DELETE FROM Students Where StudentID=" + StudentID, conn);
            // Enclose database code in Try-Catch-Finally
            try
            {
                // Open the connection
                conn.Open();
                // Execute the command
                reader = commTwo.ExecuteReader();
                reader.Close();

                readerTwo = comm.ExecuteReader();

                // Close the reader
                readerTwo.Close();
            }
            finally
            {
                // Close the connection
                conn.Close();
                Response.Redirect("default.aspx");

            }
        }
    }
}