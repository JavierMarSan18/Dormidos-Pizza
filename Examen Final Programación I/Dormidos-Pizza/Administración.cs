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
    public partial class Admin : Form
    {
        public Admin()
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

        private void agregar(Pizza pizza)
        {
            if (cbxSucursal.Text == guatemala.nombre)
            {
                guatemala.agregarPizza(pizza);
                mostrarDato(guatemala);
            }
            else if (cbxSucursal.Text == elProgreso.nombre)
            {
                elProgreso.agregarPizza(pizza);
                mostrarDato(elProgreso);
            }
            else if (cbxSucursal.Text == jalapa.nombre)
            {
                jalapa.agregarPizza(pizza);
                mostrarDato(jalapa);
            }

            enviarDato();
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

        private void Administración_Load(object sender, EventArgs e)
        {
            recibirDato();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Pizza pizza = new Pizza(txtNombre.Text, int.Parse(txtPrecio.Text), txtDescripcion.Text);
            agregar(pizza);
        }

        private void cbxSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxSucursal.Text == "Guatemala")
            {
                mostrarDato(guatemala);
            }
            else if (cbxSucursal.Text == "El Progreso")
            {
                mostrarDato(elProgreso);
            }
            if (cbxSucursal.Text == "Jalapa")
            {
                mostrarDato(jalapa);
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dtaGWPizza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tblPizza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxSucursal_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
