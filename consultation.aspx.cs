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
    public partial class consultation : System.Web.UI.Page
    {
        chaine c = new chaine();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                refrech();
            }
        }
        public void refrech()
        {
            c.connect();
            c.cmd = new SqlCommand($" select * from Reclamation order by dateRec desc", c.cnx);
            c.dt = new DataTable();
            c.dt.Load(c.dr = c.cmd.ExecuteReader());
            GridView1.DataSource = c.dt;
            GridView1.DataBind();
            c.deconnect();
        }



        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            if(e.CommandName== "aficher")
            {
                c.connect();
                c.cmd = new SqlCommand($" select * from Intervention where idRec={GridView1.Rows[index].Cells[2].Text}", c.cnx);
                c.dt = new DataTable();
                c.dt.Load(c.dr = c.cmd.ExecuteReader());
                GridView2.DataSource = c.dt;
                GridView2.DataBind();
                c.deconnect();
            }
            if (e.CommandName == "Annulertach")
            {
                c.connect();
                c.cmd = new SqlCommand($"update Reclamation set etatRec='annulee' where idrec= '{GridView1.Rows[index].Cells[2].Text}'", c.cnx);
                c.cmd.ExecuteNonQuery();
                refrech();
            }
           /* else 
            {
                Response.Write($"<script>alert('Asi rah fiha anuuler')</script>");
            }*/








        }

    }
}