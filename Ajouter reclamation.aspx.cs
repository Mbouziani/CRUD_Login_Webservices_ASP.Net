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
    public partial class Ajouter_reclamation : System.Web.UI.Page
    {
        chaine c = new chaine();
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
                c.connect();
                c.cmd = new SqlCommand($"select noTelephone from Abonnement where cin ='{Session["cin"].ToString()}'", c.cnx);
                c.dt = new DataTable();
                c.dt.Load(c.dr = c.cmd.ExecuteReader());

                DropDownList1.DataValueField = "noTelephone";
                DropDownList1.DataTextField = "noTelephone";
                DropDownList1.DataSource = c.dt;
                DropDownList1.DataBind();

                DropDownList2.Items.Add("en cours");
                DropDownList2.Items.Add("résolue");
                DropDownList2.Items.Add("annulée");
                DropDownList2.Items.Add("non résolue");
                c.deconnect();
            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            c.connect();
            c.cmd = new SqlCommand($"insert into Reclamation values({tb_id.Text},'{DropDownList1.SelectedValue}','{tb_date.Text}','{tb_obejectif.Text}','{DropDownList2.SelectedItem.ToString()}')", c.cnx);
            c.cmd.ExecuteNonQuery();
            c.deconnect();
        }
    }
}