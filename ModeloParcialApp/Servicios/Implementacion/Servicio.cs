using ModeloParcialApp.Datos.Implementacion;
using ModeloParcialApp.Datos.Interfaz;
using ModeloParcialApp.Entidades;
using ModeloParcialApp.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcialApp.Servicios.Implementacion
{
    public class Servicio : IServicio
    {
        private IOrdenRetiroDao dao;
        public Servicio()
        {
            dao=new OrdenRetiroDao();
        }

        public int CrearOrdenRetiro(OrdenRetiro oRetiro)
        {
            return dao.Crear(oRetiro);
        }

        public List<Material> TraerMateriales()
        {
            return dao.ObtenerMaterial();
        }
    }
}
