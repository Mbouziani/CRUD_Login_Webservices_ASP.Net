using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace chi_EFM
{
    public class chaine
    {
        public SqlConnection cnx = new SqlConnection(@"Data Source=MOHAMMED\SQLEXPRESS;Initial Catalog=EFF_v2_1;Integrated Security=True");
        public SqlCommand cmd ;
        public DataTable dt;
        public SqlDataReader dr;
        public SqlDataAdapter da;
        public void connect()
        {
            if(cnx.State == ConnectionState.Closed || cnx.State == ConnectionState.Broken)
            {
                cnx.Open();
            }        
        }
        public void deconnect()
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }

    }
}