using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp229_Assign03
{
    public partial class addstudents : System.Web.UI.Page
    {

        SqlConnection conn;
        SqlCommand comm;
        
        // Read the connection string from Web.config
        string connectionString = ConfigurationManager.ConnectionStrings["Students"].ConnectionString;
        // Initialize connection
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //redirecting the users to home page
            Response.Redirect("default.aspx");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                // Define data objects. it is taken from demo code. 
                conn = new SqlConnection(connectionString);
               
                comm = conn.CreateCommand();
                comm.CommandType = CommandType.Text;
                // Create command and queris
                comm = new SqlCommand("INSERT INTO Students (FirstMidName,LastName,EnrollmentDate) VALUES(@FirstName, @LastName, @EnrollmentDate)", conn);
                //paramaterarized quary for saving values to the StudentTable.
                comm.Parameters.AddWithValue("FirstName", txtBxFname.Text);
                comm.Parameters.AddWithValue("@LastName", txtBxLname.Text);
                comm.Parameters.AddWithValue("@EnrollmentDate", txtBxEnrDate.Text);
                // Open the connection
                conn.Open();
                //executing the query
                comm.ExecuteNonQuery();
                //Closing the connection
                conn.Close();

            }

            catch (Exception)
            {

            }
            finally
            {
                // Redirect the user back to Home Page
                Response.Redirect("default.aspx");

            }
        }
    }
}