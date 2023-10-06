using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcialApp.Entidades
{
    public class DetalleOrden
    {
        public double Cantidad { get; set; }
        public Material Material { get; set; }
        public DetalleOrden(double cantidad, Material material)
        {
            Cantidad = cantidad;
            Material = material;
        } 
    }
}
