using ModeloParcialApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcialApp.Datos.Interfaz
{
    public interface IOrdenRetiroDao
    {
        int Crear(OrdenRetiro oRetiro);
        List<Material> ObtenerMaterial();
    }
}
