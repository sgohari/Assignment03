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
        protected void StudentGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //for responsing the user requestion. 
            int StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);
            //String LName = Convert.ToString(txtBxFname.Text);
            // Define data objects
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            // Read the connection string from Web.config
            string connectionString = ConfigurationManager.ConnectionStrings["Students"].ConnectionString;
            // Initialize connection
            conn = new SqlConnection(connectionString);
            // Create command
            //comm = new SqlCommand("DELETE FROM Enrollments where StudentID =" + StudentID, conn);
            comm = new SqlCommand("DELETE FROM Enrollments WHERE StudentID = @StudentID", conn);
            comm.Parameters.AddWithValue("@StudentID", StudentID);
            comm = new SqlCommand("DELETE FROM Students WHERE StudentID = @StudentID", conn);
            comm.Parameters.AddWithValue("@StudentID", StudentID);
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
                //Redirect the user back to Home page.
                Response.Redirect("default.aspx");
            }
        }
    }
    
}