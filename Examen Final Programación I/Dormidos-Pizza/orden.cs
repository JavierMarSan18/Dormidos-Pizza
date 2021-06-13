using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormidos_Pizza
{
    public class orden
    {
        public int no;
        public string nombre;
        public string descripcion;
        public string sucursal;

        public orden(string nombre, string descripcion, string sucursal)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.sucursal = sucursal;
        }

        public orden(int no)
        {
            this.no = no;
        }
    }
}
