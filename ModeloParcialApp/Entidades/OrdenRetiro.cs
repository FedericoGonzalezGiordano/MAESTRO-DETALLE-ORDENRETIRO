using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcialApp.Entidades
{
    public class OrdenRetiro
    {
        public int NroOrden { get; set; }
        public DateTime Fecha { get; set; }
        public string Responsable { get; set; }
        public List<DetalleOrden> Detalles { get; set; }
        public OrdenRetiro(int nroOrden, DateTime fecha, string responsable)
        {
            nroOrden = NroOrden;
            fecha = Fecha;
            responsable = Responsable;
            Detalles = new List<DetalleOrden>();
        }

        public OrdenRetiro()
        {
            Detalles = new List<DetalleOrden>();
        }

        public void AgregarDetalle(DetalleOrden detalle)
        {
            Detalles.Add(detalle);
        }
        public void QuitarDetalle(int posicion) 
        {
            Detalles.RemoveAt(posicion); 
        }
    }
}
