using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcialApp.Entidades
{
    public class Material
    {
        public int CodMaterial { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public Material(int codMaterial, string nombre, int stock)
        {
            CodMaterial = codMaterial;
            Nombre = nombre;
            Stock = stock;
        }
        public Material()
        {
            CodMaterial = 0;
            Nombre = string.Empty;
            Stock = 0;
        }
       
        public override string ToString()
        {
            return Nombre + CodMaterial + Stock;
        }


    }
}
