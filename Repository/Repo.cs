using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DAL;
using ModelsDb;
using System.Data.SqlClient;

namespace Repository
{
    public class Repo:DataContexto
    {
        public void Registrar(Registros reg)
        {
            try
            {
                openCon();
                string strIn = string.Format(@"INSERT INTO Registros VALUES(@DataRegistro,@SerialHDD,@ModelMachine,@SerialMachine,@Usuario,@FabricanteId,@TipoId,@Status)");
                using(cmd = new SqlCommand(strIn, con))
                {
                    string data = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                    cmd.Parameters.AddWithValue("@DataRegistro", data);
                    cmd.Parameters.AddWithValue("@SerialHDD", reg.SerialHDD);
                    cmd.Parameters.AddWithValue("@SerialMachine", reg.SerialMachine);
                    cmd.Parameters.AddWithValue("@SerialMachine", reg.SerialMachine);
                    cmd.Parameters.AddWithValue("@Usuario", reg.Usuario);
                    cmd.Parameters.AddWithValue("@FabricanteId", reg.FabricanteId);
                    cmd.Parameters.AddWithValue("@TipoId", reg.TipoId);
                    cmd.Parameters.AddWithValue("@Status", reg.Status);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                closedConn();
            }
        }
    }
}