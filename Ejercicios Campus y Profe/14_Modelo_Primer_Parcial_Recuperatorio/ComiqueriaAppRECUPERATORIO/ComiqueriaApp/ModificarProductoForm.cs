using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaApp;
using ComiqueriaLogic;

namespace ComiqueriaApp
{
    public partial class ModificarProductoForm: Form
    {
        private Producto productoSeleccionado;

        public ModificarProductoForm( Producto productoSeleccionado )
        {
            InitializeComponent();
            this.productoSeleccionado = productoSeleccionado;
        }

        private void ModificarProductoForm_Load( object sender, EventArgs e )
        {
            StringBuilder precio = new StringBuilder();
            precio.AppendFormat("{0:00}", this.productoSeleccionado.Precio);
            this.txtPrecioActual.Text = precio.ToString();
        }

        private void BtnCancelar_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void BtnModificar_Click( object sender, EventArgs e )
        {
            bool invalido = true;
            double nuevoPrecio;

            if (double.TryParse(this.txtNuevoPrecio.Text, out nuevoPrecio))
            {
                invalido = false;
            }

            if (invalido)
            {
                this.lblError.Text = ("Error. Debe ingresar un precio válido.");
            }
            else
            {

                DialogResult confirmacion = MessageBox.Show("Confirmacion", "Esta seguro de que desea realizar los cambios?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    this.productoSeleccionado.Precio = nuevoPrecio;
                    this.Close();
                }
                else
                {

                }

            }

        }

        private void TxtNuevoPrecio_TextChanged( object sender, EventArgs e )
        {
            this.lblError.Text = string.Empty;
        }
    }
}
