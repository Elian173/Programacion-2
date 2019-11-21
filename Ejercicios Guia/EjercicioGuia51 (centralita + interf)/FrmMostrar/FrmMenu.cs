using BibliotecaClases;
using System;
using System.Windows.Forms;

namespace FrmMostrar
{
    public partial class FrmMenu: Form
    {
        private Centralita c;

        public FrmMenu()
        {
            InitializeComponent();
            this.c = new Centralita("Elian");
        }

        private void FrmMenu_Load( object sender, EventArgs e )
        {
            /*
            //sacar esto despues *************************************************************************
            // hardcode
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

            c = c + l1;
            c = c + l2;
            c = c + l3;
            c = c + l4;
            */
        }

        private void botonFacturacionTotal_Click( object sender, EventArgs e )
        {
            FrmFacturacion frmFacturacion = new FrmFacturacion(this.c, Llamada.TipoLlamada.Todas);
            frmFacturacion.ShowDialog();
        }

        private void botonFacturacionLocal_Click( object sender, EventArgs e )
        {
            FrmFacturacion frmFacturacion = new FrmFacturacion(this.c, Llamada.TipoLlamada.Local);
            frmFacturacion.ShowDialog();
        }

        private void botonFacturacionProvincial_Click( object sender, EventArgs e )
        {
            FrmFacturacion frmFacturacion = new FrmFacturacion(this.c, Llamada.TipoLlamada.Provincial);
            frmFacturacion.ShowDialog();
        }

        private void botonGenerarLlamada_Click( object sender, EventArgs e )
        {
            FrmGenerarLlamada frmGenerarLlamada = new FrmGenerarLlamada(this.c);
            frmGenerarLlamada.ShowDialog();
        }

        private void botonSalir_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}