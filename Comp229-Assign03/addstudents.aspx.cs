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
            Response.Redirect("default.aspx");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                comm = conn.CreateCommand();
                comm.CommandType = CommandType.Text;
                comm.CommandText = "Insert into Students values ('" + txtBxFname.Text + "','" + txtBxLname.Text + "','" + txtBxEnrDate.Text + "')";
                comm.Parameters.Add("@txtBxFname", System.Data.SqlDbType.NVarChar, 50);
                comm.Parameters["@FirstMidName"].Value = txtBxFname.Text;
                comm.Parameters.Add("@txtBxLname", System.Data.SqlDbType.NVarChar, 50);
                comm.Parameters["LastName"].Value = txtBxLname.Text;
                comm.Parameters.Add("@EnrollmentDate", System.Data.SqlDbType.Date);
                comm.Parameters["@txtBxEnrDate"].Value = txtBxEnrDate.Text;
                comm.ExecuteNonQuery();
                conn.Close();

            }

            catch (Exception)
            {

            }
            finally
            {
                Response.Redirect("default.aspx");

            }
        }
    }
}