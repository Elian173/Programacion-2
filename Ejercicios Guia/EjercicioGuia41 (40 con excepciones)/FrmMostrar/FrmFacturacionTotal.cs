using BibliotecaClases;
using System;
using System.Windows.Forms;

namespace FrmMostrar
{
    public partial class FrmFacturacion: Form
    {
        private Llamada.TipoLlamada tipollamada;
        private Centralita c;

        public Llamada.TipoLlamada TipoLlamada
        {
            set
            {
                tipollamada = value;
            }
        }

        public FrmFacturacion( Centralita c, Llamada.TipoLlamada tipo )
        {
            InitializeComponent();
            this.TipoLlamada = tipo;
            this.c = c;
        }

        private void FrmFacturacion_Activated( object sender, EventArgs e )
        {
            switch (this.tipollamada)
            {
                case
                Llamada.TipoLlamada.Local:
                this.textoFacturacion.Text = c.GananciaPorLocal.ToString();
                this.textoMasInformacion.Text = c.ToString();
                this.labelFacturacion.Text = "Facturacion local";

                break;

                case
                    Llamada.TipoLlamada.Provincial:
                this.textoFacturacion.Text = c.GananciaPorProvincial.ToString();
                this.textoMasInformacion.Text = c.ToString();
                this.labelFacturacion.Text = "Facturacion provincial";
                break;

                case
                    Llamada.TipoLlamada.Todas:
                this.textoFacturacion.Text = c.GananciaPorTotal.ToString();
                this.textoMasInformacion.Text = c.ToString();
                this.labelFacturacion.Text = "Facturacion Total";
                break;
            }
        }
    }
}