using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace chi_EFM
{
    public partial class login : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["NameUser"] = Session["idoperateur"] = Session["cin"]= "";
        }
        
        chaine c = new chaine();
        protected void click_seconnecter(object sender, AuthenticateEventArgs e)
        {
            c.connect();
            c.cmd = new SqlCommand($"select count(*) from Abonne where cin='{Login1.UserName}' and motdepasse='{Login1.Password}' or logiin='{Login1.UserName}' and motdepasse='{Login1.Password}'", c.cnx);
            if((int)c.cmd.ExecuteScalar() != 0)
            {
                c.cmd = new SqlCommand($"select nomAb+' '+PrenomAb from Abonne where cin='{Login1.UserName}' and motdepasse='{Login1.Password}' or logiin='{Login1.UserName}' and motdepasse='{Login1.Password}'", c.cnx);
                Session["NameUser"] = (string)c.cmd.ExecuteScalar();
                Session["cin"] = Login1.UserName;
                Response.Redirect("Ajouter reclamation.aspx");
            }
            else
            {
                string query = $"select idOperateur from Operateur where loginop='{Login1.UserName}' and mdpop='{Login1.Password}'";
                c.cmd = new SqlCommand(query, c.cnx);
                
                if (c.cmd.ExecuteScalar() != null)
                {
                    Session["idoperateur"] = (int)c.cmd.ExecuteScalar();
                    Response.Redirect("intervention.aspx");
                }
            }
        }   
        
        
    }
}