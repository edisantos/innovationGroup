using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataContexto
    {
        protected SqlConnection con;
        protected SqlCommand cmd;
        protected SqlDataAdapter Apd;
        protected SqlDataReader Dr;
        protected DataTable Dt;

        //Open database
        public SqlConnection openCon()
        {
            try
            {
                string strCon = string.Format(@"Data Source=EDYLEMOS\SQLLOCAL;Initial Catalog=RegitroHddCore;User ID=sa;Password=edi318730");
                con = new SqlConnection(strCon);
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                return con;
            }
            catch (SqlException ex)
            {

                throw new Exception("erro ao conectar o banco " + ex.Message);
            }
        }
        //Close database
        public SqlConnection closedConn()
        {
            try
            {
                if(con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return con;
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
