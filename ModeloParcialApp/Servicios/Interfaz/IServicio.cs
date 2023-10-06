using ModeloParcialApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcialApp.Servicios.Interfaz
{
    public interface IServicio
    {
        List<Material> TraerMateriales();

        int CrearOrdenRetiro(OrdenRetiro oRetiro);
    }
}

