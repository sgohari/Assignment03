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
            comm = new SqlCommand("SELECT * FROM Students where StudentID IN (select StudentID from Enrollments where CourseID=" + CourseID+")", conn);
            // Enclose database code in Try-Catch-Finally
            try
            {
                // Open the connection
                conn.Open();
                // Execute the command
                reader = comm.ExecuteReader();
                // Bind the reader to the DataList
                GvCourse1.DataSource = reader;
                GvCourse1.DataBind();

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

        }
    }
}