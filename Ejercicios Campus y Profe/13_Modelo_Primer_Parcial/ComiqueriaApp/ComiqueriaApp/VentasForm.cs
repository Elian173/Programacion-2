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
        //CONSTRUCTOR
        private Comiqueria comiqueria;
        private Producto producto;
        

        public VentasForm(Comiqueria comiqueria, Producto producto)
        {
            InitializeComponent();

            this.comiqueria = comiqueria;
            this.producto = producto;

        }
        
        #region Metodos


       

        private void VentasForm_Activated(object sender, EventArgs e) //esto iria en LOAD-
        {
            this.labelDescripcion.Text = this.producto.Descripcion;
            this.labelPrecio.Text = (Venta.CalcularPrecioFinal(this.producto.Precio, (int)this.numericUpDownCantidad.Value)).ToString();
            //numericUpDownCantidad_ValueChanged(null,null);
        }

        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            this.labelPrecio.Text = (Venta.CalcularPrecioFinal(this.producto.Precio, (int)this.numericUpDownCantidad.Value)).ToString();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonVender_Click(object sender, EventArgs e)
        {
            double stockDisponible = this.producto.Stock;
            bool ventaValida = false ;

            if(( (double) this.numericUpDownCantidad.Value) <= stockDisponible)
            {
                ventaValida = true;
            }


            if(ventaValida)
            {
                this.comiqueria.Vender(producto);
                this.DialogResult= DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error, no hay stock","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            #endregion
        }
    }
}
