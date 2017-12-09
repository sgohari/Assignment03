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
    public partial class enrollment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CourseBindList();
            
        }
        private void CourseBindList()
        {
            int CourseID = Convert.ToInt32(Request.QueryString["CourseID"]);
            // Define data objects
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            // Read the connection string from Web.config
            string connectionString = ConfigurationManager.ConnectionStrings["Students"].ConnectionString;
            // Initialize connection
            conn = new SqlConnection(connectionString);
            // Create command
            comm = new SqlCommand("SELECT * FROM Students WHERE StudentID IN (SELECT StudentID FROM Enrollments WHERE CourseID=@CourseID)", conn);
            comm.Parameters.AddWithValue("@CourseID", CourseID);
            // Enclose database code in Try-Catch-Finally
            try
            {
                // Open the connection
                conn.Open();
                // Execute the command
                reader = comm.ExecuteReader();
                // Bind the reader to the DataList
                GvCourse.DataSource = reader;
                GvCourse.DataBind();

                // Close the reader
                reader.Close();
            }
            finally
            {
                // Close the connection
                conn.Close();
            }
        }

        //This GvCourse_RowDeleting is only removing student from Course Not from all database. 
        protected void GvCourse_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //declearing variable to store StudenID and convert it to Int, than running the query. 
            int CourseID = Convert.ToInt32(Request.QueryString["CourseID"]);
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
            commTwo = new SqlCommand("DELETE FROM Enrollments WHERE CourseID=@CourseID", conn);
            commTwo.Parameters.AddWithValue("@CourseID", CourseID);
            //command for deleting from student table.
            comm = new SqlCommand("DELETE FROM Courses WHERE CourseID=@CourseID",conn);
           
            comm.Parameters.AddWithValue("@CourseID", CourseID);
            comm.Parameters.AddWithValue("@StudentID", StudentID);
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