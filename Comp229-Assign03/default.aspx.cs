using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Comp229_Assign03
{
    public partial class _default : System.Web.UI.Page
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
              "SELECT LastName,FirstMidName FROM Students",
              conn);
            // Enclose database code in Try-Catch-Finally
            try
            {
                // Open the connection
                conn.Open();
                // Execute the command
                reader = comm.ExecuteReader();
                // Bind the reader to the DataList
                MyRepeater.DataSource = reader;
                MyRepeater.DataBind();

                // Close the reader
                reader.Close();
            }
            finally
            {
                // Close the connection
                conn.Close();
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
          
        }
    }
}