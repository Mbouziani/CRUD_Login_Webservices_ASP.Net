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
    public partial class intervention : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["idoperateur"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    lb_idopertaeur.Text = Session["idoperateur"].ToString();

                    c.connect();
                    c.cmd = new SqlCommand($" select idrec from Reclamation", c.cnx);
                    c.dt = new DataTable();
                    c.dt.Load(c.dr = c.cmd.ExecuteReader());

                    DropDownList1.DataValueField = "idrec";
                    DropDownList1.DataTextField = "idrec";
                    DropDownList1.DataSource = c.dt;
                    DropDownList1.DataBind();
                }
            }
        }
        chaine c = new chaine();
        protected void Button1_Click(object sender, EventArgs e)
        {
            c.connect();
            c.cmd = new SqlCommand($"insert into Intervention values ({tb_id.Text},{DropDownList1.SelectedValue},'{tb_date.Text}','{tb_natur.Text}',{Session["idoperateur"].ToString()})", c.cnx);
            c.cmd.ExecuteNonQuery();
            c.deconnect();
        }
    }
}