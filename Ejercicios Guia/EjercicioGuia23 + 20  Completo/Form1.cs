using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

namespace Ejercicio23_Forms_
{
    public partial class Ventana: Form
    {
        public Ventana()
        {
            InitializeComponent();
        }

        #region Cotizacion

        private void LockButton_Click( object sender, EventArgs e )
        {

            bool flag = false;

            if (this.CotizacionPesoInputTextBox.Enabled == true && flag == false)
            {
                this.CotizacionPesoInputTextBox.Enabled = false;
                flag = true;
            }

            if (this.CotizacionPesoInputTextBox.Enabled == false && flag == false)
            {
                this.CotizacionPesoInputTextBox.Enabled = true;
                flag = true;
            }

        }


        private void CotizacionPesoInputTextBox_Leave( object sender, EventArgs e )
        {
            double cotizacion;

            if (double.TryParse(CotizacionPesoInputTextBox.Text, out cotizacion))
            {
                Peso.SetCotizacion(cotizacion);
            }
            else
            {
                CotizacionPesoInputTextBox.Focus();
            }

        }


        private void CotizacionEuroInputTextBox1_Leave( object sender, EventArgs e )
        {
            double cotizacion;

            if (double.TryParse(CotizacionEuroInputTextBox1.Text, out cotizacion))
            {
                Euro.SetCotizacion(cotizacion);
            }
            else
            {
                CotizacionEuroInputTextBox1.Focus();
            }
        }
        #endregion


        #region Botones Transformacion

        private void DolarButton_Click( object sender, EventArgs e )
        {
            Dolar dolar = new Dolar();
            Peso peso = new Peso();
            Euro euro = new Euro();

            double cantidad;

            if (double.TryParse(DolarInputTextBox.Text, out cantidad))
            {



                dolar = cantidad;
                DolarXDolarOutputTextBox.Text = Convert.ToString(dolar.GetCantidad());

                peso = (Peso) dolar;
                DolarXPesoOutputBox.Text = Convert.ToString(peso.GetCantidad());

                euro = (Euro) dolar;
                DolarXEuroTextBox.Text = Convert.ToString(euro.GetCantidad());

            }

        }

        private void PesoButton_Click( object sender, EventArgs e )
        {
            Dolar dolar = new Dolar();
            Peso peso = new Peso();
            Euro euro = new Euro();

            double cantidad;

            if (double.TryParse(PesoInputTextBox.Text, out cantidad))
            {

                peso = cantidad;
                PesoXPesoOutputTextBox.Text = Convert.ToString(peso.GetCantidad());

                dolar = (Dolar) peso;
                PesoXDolarOutputTextBox.Text = Convert.ToString(dolar.GetCantidad());

                euro = (Euro) peso;                                                                                                                                //ESTO MAL
                PesoXEuroTextBox.Text = Convert.ToString(euro.GetCantidad());

            }

        }


        private void EuroButton_Click( object sender, EventArgs e )
        {

            Dolar dolar = new Dolar();
            Euro euro = new Euro();
            Peso peso = new Peso();

            double cantidad;

            if (double.TryParse(EuroInputTextBox.Text, out cantidad))
            {

                euro = cantidad;
                EuroXEuroTextBox.Text = Convert.ToString(euro.GetCantidad());

                dolar = (Dolar) euro;
                EuroXDolarTextBox.Text = Convert.ToString(dolar.GetCantidad());


                peso = (Peso) euro;                                                                                                                               //ESTO MAL
                EuroXPesoTextBox.Text = Convert.ToString(peso.GetCantidad());
            }


        }








        #endregion


    }
}
