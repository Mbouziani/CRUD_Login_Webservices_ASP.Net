using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using chi_EFM.ServiceReference2;
using System.IO;

namespace chi_EFM
{
    public partial class teste_Web_services : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        serviceblaclassSoapClient wss = new serviceblaclassSoapClient();
        chaine c = new chaine();
        protected void aficher_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = wss.nu(TextBox1.Text);
            GridView1.DataBind();
        }

        protected void Button1bt_json_Click(object sender, EventArgs e)
        {

        }
    }
}