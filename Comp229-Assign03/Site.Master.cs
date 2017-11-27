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
                    Page.Title = string.Format("Institution Home Page");
                    break;
                case "student":
                    home.Attributes.Add("Class", "Active");
                    Page.Title = string.Format("Institution Students Page");
                    break;
                case "course":
                    home.Attributes.Add("Class", "Active");
                    Page.Title = string.Format("Institution Course Page");
                    break;
                case "update":
                    home.Attributes.Add("Class", "Active");
                    Page.Title = string.Format("Institution Update Page");
                    break;
            }
        }
    }
}