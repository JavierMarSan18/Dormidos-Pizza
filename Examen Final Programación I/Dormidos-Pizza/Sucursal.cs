using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormidos_Pizza
{
    public class Sucursal
    {
        public string nombre;
        public List<orden> listOrden = new List<orden>();
        public List<Pizza> list = new List<Pizza>();
        
        public Sucursal(string nombre)
        {
            this.nombre = nombre;
        }

        public void agregarPizza(Pizza pizza)
        {
            list.Add(pizza);
        }

        public void agregarOrden(orden orden)
        {
            listOrden.Add(orden);
        }
    }
}
