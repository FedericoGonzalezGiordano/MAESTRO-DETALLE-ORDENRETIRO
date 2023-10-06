using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcialApp.Datos
{
    public class HelperDao
    {
        private static HelperDao instancia;
        private SqlConnection conexion;

        private HelperDao()
        {
            conexion = new SqlConnection(Properties.Resources.CadenaConexion);
        }

        public static HelperDao ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new HelperDao();
            }
            return instancia;
        }
        public SqlConnection ObtenerConexion()
        {
            return this.conexion;
        }
        public DataTable ConsultarSp(string nombreSP)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(nombreSP, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conexion.Close();
            return dt;
        }

        
    }
}
