using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp229_Assign03
{
    public partial class update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.UpdateBindList();
            }
        }
        private void UpdateBindList()
        {
            int StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);
            String LName = Convert.ToString(txtBxFname.Text);
            // Define data objects
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            // Read the connection string from Web.config
            string connectionString = ConfigurationManager.ConnectionStrings["Students"].ConnectionString;
            // Initialize connection
            conn = new SqlConnection(connectionString);
            // Create command
            comm = new SqlCommand("SELECT * FROM Students where StudentID="+StudentID, conn);
            // Enclose database code in Try-Catch-Finally
            try
            {
                // Open the connection
                conn.Open();
                // Execute the command
                reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    txtBxLname.Text += reader["LastName"];
                    txtBxFname.Text += reader["FirstMidName"];
                    txtBxEnrDate.Text += reader["EnrollmentDate"];
                    //txtBxEnrDate.Text += reader["EnrollmentDate"];
                }

                
                // Bind the reader to the DataList
                //GvStudent.DataSource = reader;
                //GvStudent.DataBind();

                // Close the reader
                reader.Close();
            }
            finally
            {
                // Close the connection
                conn.Close();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            // Read the connection string from Web.config
            string connectionString = ConfigurationManager.ConnectionStrings["Students"].ConnectionString;
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                comm = conn.CreateCommand();
                comm.CommandType = CommandType.Text;
                //comm.CommandText = update Students set LastName = 'Amooo' WHERE StudentID = 301001;
                comm.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception) { }
            finally
            {
                Response.Redirect("default.aspx");
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);
            String LName = Convert.ToString(txtBxFname.Text);
            // Define data objects
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            // Read the connection string from Web.config
            string connectionString = ConfigurationManager.ConnectionStrings["Students"].ConnectionString;
            // Initialize connection
            conn = new SqlConnection(connectionString);
            // Create command
            comm = new SqlCommand("update Students set LastName = '" + txtBxLname.Text+"', FirstMidName='"+txtBxFname.Text+"', EnrollmentDate= '"+txtBxEnrDate.Text+"' WHERE StudentID = " + StudentID, conn);
            // Enclose database code in Try-Catch-Finally
            try
            {
                // Open the connection
                conn.Open();
                // Execute the command
                reader = comm.ExecuteReader();
                   // Close the reader
                reader.Close();
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