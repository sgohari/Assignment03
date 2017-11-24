using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp229_Assign03
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TitlePage();
        }

        private void TitlePage()
        {
            switch (Page.Title)
            {
                case "Home":
                    home.Attributes.Add("Class", "Active");
                    Page.Title = string.Format("Nasir Home");
                    break;
                case "Student":
                    home.Attributes.Add("Class", "Active");
                    Page.Title = string.Format("Instituation Students");
                    break;
                case "Enrollment":
                    home.Attributes.Add("Class", "Active");
                    Page.Title = string.Format("Instituation Enrollment");
                    break;
                case "Update":
                    home.Attributes.Add("Class", "Active");
                    Page.Title = string.Format("Instituation Update");
                    break;
            }
        }
    }
}