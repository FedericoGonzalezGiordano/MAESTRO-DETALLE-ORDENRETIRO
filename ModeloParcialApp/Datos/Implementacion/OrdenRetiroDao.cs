using ModeloParcialApp.Datos.Interfaz;
using ModeloParcialApp.Entidades;
using ModeloParcialApp.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ModeloParcialApp.Datos.Implementacion
{
    public class OrdenRetiroDao : IOrdenRetiroDao
    {
        public int Crear(OrdenRetiro oRetiro)
        {
            int OrdenNum = 0;
            SqlConnection conexion = HelperDao.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand("SP_INSERTAR_ORDEN", conexion, t);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@responsable", oRetiro.Responsable);

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@nro";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parametro);

                comando.ExecuteNonQuery();

                OrdenNum = (int)parametro.Value;
                int detalleNro = 1;


                SqlCommand cmdOrdenDetalle;

                foreach (DetalleOrden d in oRetiro.Detalles)
                {
                    cmdOrdenDetalle = new SqlCommand("SP_INSERTAR_DETALLES", conexion, t);
                    cmdOrdenDetalle.CommandType = CommandType.StoredProcedure;
                    cmdOrdenDetalle.Parameters.AddWithValue("@nro_orden", OrdenNum); //
                    cmdOrdenDetalle.Parameters.AddWithValue("@detalle", detalleNro); //output
                    cmdOrdenDetalle.Parameters.AddWithValue("@codigo", d.Material.CodMaterial);
                    cmdOrdenDetalle.Parameters.AddWithValue("@codigo", d.Cantidad);


                    detalleNro++;
                }
                t.Commit();
            }
            catch
            {
                if (t != null)
                    t.Rollback();
                
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return OrdenNum;
        }

        public List<Material> ObtenerMaterial()
        {
            List<Material> list = new List<Material>();
            DataTable dt = HelperDao.ObtenerInstancia().ConsultarSp("SP_CONSULTAR_MATERIALES");
            foreach (DataRow fila in dt.Rows)
            {
                int CodMaterial = Convert.ToInt32(fila["codigo"]);
                string Nombre = fila["nombre"].ToString();
                int Stock = Convert.ToInt32(fila["stock"]);
               
               Material material = new Material(CodMaterial, Nombre, Stock);
               list.Add(material);
               
            }
            return list;
        }
    }
}
