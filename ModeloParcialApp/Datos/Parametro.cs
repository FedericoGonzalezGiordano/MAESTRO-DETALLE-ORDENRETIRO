using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcialApp.Datos
{
    public class Parametro
    {
        private string nombre;
        private object valor;

        public Parametro(string nombre, object valor)
        {
            this.nombre = nombre;
            this.valor = valor;
        }
    }
}
