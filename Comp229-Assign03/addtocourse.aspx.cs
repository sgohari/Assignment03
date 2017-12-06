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
    public partial class addtocourse : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlCommand comm;
        // Read the connection string from Web.config
        string connectionString = ConfigurationManager.ConnectionStrings["Students"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                conn = new SqlConnection(connectionString);

                comm = conn.CreateCommand();
                comm.CommandType = CommandType.Text;
                comm = new SqlCommand("INSERT INTO Course (Title,Credits,DepartmentID) Values(@Title, @Credits, @DepartmentID)", conn);
                comm.Parameters.AddWithValue("@Title", txtBxTitle.Text);
                comm.Parameters.AddWithValue("@Credit", txtBxCredit.Text);
                comm.Parameters.AddWithValue("@DepartmentID", txtBxDepartmentID.Text);

                conn.Open();
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

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}