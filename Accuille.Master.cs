using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chi_EFM
{
    public partial class Accuille : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["NameUser"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                Label1.Text = "Bonjour Mr " + Session["NameUser"].ToString();
            }
        }

    }
}