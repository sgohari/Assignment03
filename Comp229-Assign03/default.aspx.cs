using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Comp229_Assign03
{
    public partial class _default : System.Web.UI.Page
    {
        private SqlConnection connect;
        private SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                connect = new SqlConnection(@"Data Source=laptop-o8ug7h3u\SQLEXPRESS; Initial Catalog = Comp229Assign03; Integrated Security = True");
                connect.Open();
                cmd = new SqlCommand("SELECT * FROM Students");
                connect.Close();
            }
            catch (Exception)
            {
                
            }
        }

        
        
    }
}