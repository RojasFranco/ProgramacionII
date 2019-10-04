using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;

namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        private Comiqueria comiqueria;
        private Producto productoSeleccionado;
        private int cantidad=1;

        public VentasForm(Comiqueria comiqueria, Producto productoSeleccionado)
        {
            InitializeComponent();
            this.comiqueria = comiqueria;
            this.productoSeleccionado = productoSeleccionado;
            //this.cantidad = int.Parse(this.lblCantidad.Text);
            this.lblDescripcion.Text = this.productoSeleccionado.Descripcion;
            //this.lvlPrecioMostrar.Text = Venta.CalcularPrecioFinal(productoSeleccionado.Precio, cantidad);
            this.lvlPrecioMostrar.Text = (Venta.CalcularPrecioFinal(productoSeleccionado.Precio, this.cantidad)).ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.cantidad = int.Parse(this.numericUpDown1.Value.ToString());
            this.lvlPrecioMostrar.Text = (Venta.CalcularPrecioFinal(productoSeleccionado.Precio, this.cantidad)).ToString();
            //MessageBox.Show(this.cantidad.ToString()); PARA VER
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if(this.cantidad <= this.productoSeleccionado.Stock)
            {
                comiqueria.Vender(productoSeleccionado, this.cantidad);
                base.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("superó el stock disponible, disminuir unidades a vender", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
