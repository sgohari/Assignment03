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
            int StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);
            // Define data objects
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            // Read the connection string from Web.config
            string connectionString = ConfigurationManager.ConnectionStrings["Students"].ConnectionString;
            // Initialize connection
            conn = new SqlConnection(connectionString);
            // Create command
            comm = new SqlCommand(
              "SELECT * FROM Students where StudentID="+StudentID,conn);
            // Enclose database code in Try-Catch-Finally
            try
            {
                // Open the connection
                conn.Open();
                // Execute the command
                reader = comm.ExecuteReader();
                // Bind the reader to the DataList
                SgvStudent.DataSource = reader;
                SgvStudent.DataBind();

                // Close the reader
                reader.Close();
            }
            finally
            {
                // Close the connection
                conn.Close();
            }
        }

        
        protected void SgvStudent_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}