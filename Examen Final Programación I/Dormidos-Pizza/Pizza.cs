using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dormidos_Pizza
{
    public class Pizza
    {
        public string nombre;
        public int precio;
        public string descripcion;

        public Pizza(string nombre, int precio, string descripcion)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.descripcion = descripcion;
        }
    }
}
