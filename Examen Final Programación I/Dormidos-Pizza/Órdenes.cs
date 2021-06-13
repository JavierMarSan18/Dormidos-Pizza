using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dormidos_Pizza
{
    public partial class Ordenes : Form
    {
        public Ordenes()
        {
            InitializeComponent();
        }

        Sucursal guatemala;
        Sucursal elProgreso;
        Sucursal jalapa;

        private void enviarDato()
        {
            DPizzaForm frm = Owner as DPizzaForm;

            frm.Guatemala = guatemala;
            frm.ElProgreso = elProgreso;
            frm.Jalapa = jalapa;
        }

        private void recibirDato()
        {
            DPizzaForm frm = Owner as DPizzaForm;

            guatemala = frm.Guatemala;
            elProgreso = frm.ElProgreso;
            jalapa = frm.Jalapa;
        }

        private void label4_Click(object sender, EventArgs e)
        {
        
        }
        
        private void agregarOrden(orden orden)
        {
            if (cbxSucursal.Text == "Guatemala")
            {
                orden.no = guatemala.listOrden.Count+1;
                guatemala.listOrden.Add(orden);
            }
            else if (cbxSucursal.Text == "El Progreso")
            {
                orden.no = elProgreso.listOrden.Count+1;
                elProgreso.listOrden.Add(orden);
            }

            if (cbxSucursal.Text == "Jalapa")
            {
                orden.no = jalapa.listOrden.Count+1;
                jalapa.listOrden.Add(orden);
            }

            enviarDato();
            mostrarDato(cbxSucursal.Text);
        }

        private void mostrarDato(string sucursal)
        {
            tblPizza.Rows.Clear();

            if (sucursal == "Guatemala")
            {
                foreach(orden orden in guatemala.listOrden)
                {
                    tblPizza.Rows.Add(orden.no,orden.nombre, orden.descripcion, orden.sucursal);
                }
            }
            else if (cbxSucursal.Text == "El Progreso")
            {
                foreach (orden orden in elProgreso.listOrden)
                {
                    tblPizza.Rows.Add(orden.no, orden.nombre, orden.descripcion, orden.sucursal);
                }
            }

            else if (cbxSucursal.Text == "Jalapa" )
            {
                foreach (orden orden in jalapa.listOrden)
                {
                    tblPizza.Rows.Add(orden.no, orden.nombre, orden.descripcion, orden.sucursal);
                }
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            orden orden = new orden(cbxPizza.Text, txtDescripcion.Text, cbxSucursal.Text);
            agregarOrden(orden);
        }

        private void cbxSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarDato(cbxSucursal.Text);

            cbxPizza.Items.Clear();

            if (cbxSucursal.Text == "Guatemala")
            {
                foreach (Pizza pizza in guatemala.list)
                {
                    cbxPizza.Items.Add(pizza.nombre);

                }
            }
            else if (cbxSucursal.Text == "El Progreso")
            {
                foreach (Pizza pizza in elProgreso.list)
                {
                    cbxPizza.Items.Add(pizza.nombre);
                }
            }
            
            if (cbxSucursal.Text == "Jalapa")
            {
                foreach (Pizza pizza in jalapa.list)
                {
                    cbxPizza.Items.Add(pizza.nombre);
                }
            }
        }

        private void mostrarDato(Sucursal sucursal)
        {
            tblPizza.Rows.Clear();
            if (cbxSucursal.Text == sucursal.nombre)
            {
                foreach (Pizza pizza in sucursal.list)
                {
                    tblPizza.Rows.Add(pizza.nombre, pizza.descripcion, pizza.precio);
                }
            }
        }

        private void cbxPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSucursal.Text == "Guatemala")
            {
                foreach (Pizza pizza in guatemala.list)
                {
                    if(cbxPizza.Text == pizza.nombre)
                    {
                        lblPrecio.Text = $"Q {pizza.precio.ToString()}";
                        txtDescripcion.Text = pizza.descripcion;
                        break;
                    }

                }
            }
            else if (cbxSucursal.Text == "El Progreso")
            {
                foreach (Pizza pizza in elProgreso.list)
                {
                    if (cbxPizza.Text == pizza.nombre)
                    {
                        lblPrecio.Text = $"Q {pizza.precio.ToString()}";
                        txtDescripcion.Text = pizza.descripcion;
                        break;
                    }
                }
            }

            if (cbxSucursal.Text == "Jalapa")
            {
                foreach (Pizza pizza in jalapa.list)
                {
                    if (cbxPizza.Text == pizza.nombre)
                    {
                        lblPrecio.Text = $"Q {pizza.precio.ToString()}";
                        txtDescripcion.Text = pizza.descripcion;
                        break;
                    }
                }
            }
        }

        private void Ordenes_Load(object sender, EventArgs e)
        {
            recibirDato();
            cbxSucursal.Items.Add(guatemala.nombre);
            cbxSucursal.Items.Add(elProgreso.nombre);
            cbxSucursal.Items.Add(jalapa.nombre);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
