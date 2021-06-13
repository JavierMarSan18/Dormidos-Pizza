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
    public partial class DPizzaForm : Form
    {
        public DPizzaForm()
        {
            InitializeComponent();
        }

        Sucursal guatemala = new Sucursal("Guatemala");
        Sucursal elProgreso = new Sucursal("El Progreso");
        Sucursal jalapa = new Sucursal("Jalapa");

        private Sucursal _guatemala;
        private Sucursal _elProgreso;
        private Sucursal _jalapa;

        public Sucursal Guatemala { get => _guatemala; set => _guatemala = value; }
        public Sucursal ElProgreso { get => _elProgreso; set => _elProgreso = value; }
        public Sucursal Jalapa { get => _jalapa; set => _jalapa = value; }

        private void objetos()
       {
           _guatemala = guatemala;
           _elProgreso = elProgreso;
           _jalapa = jalapa;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Sucursal guatemala = new Sucursal("Guatemala");
            Admin admin = new Admin();
            AddOwnedForm(admin);
            admin.Show();
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            Ordenes orden = new Ordenes();
            AddOwnedForm(orden);
            orden.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objetos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
