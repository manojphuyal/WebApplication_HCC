using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HetaudaCityCollageWebApplication.Repository
{
    public class DBConnection
    {
        public SqlConnection con;
        public void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["HetaudaCityCollageDBConnection"].ToString();
            con = new SqlConnection(constring);
        }
    }
}