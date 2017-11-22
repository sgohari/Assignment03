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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.AllKeys.Contains("pro_id") && Request.QueryString.AllKeys.Contains("action"))
            {
                string proID = Request.QueryString["pro_id"];
                string action = Request.QueryString["action"];
            }

        }
        void forDatabases(string quaries)
        {
            string connection = "Data Source= ; Initail Catalog=Comp229Assign03; Integrated Security=True";
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(quaries, connect);
                SqlDataReader read = command.ExecuteReader();
            }
        }
    }
}