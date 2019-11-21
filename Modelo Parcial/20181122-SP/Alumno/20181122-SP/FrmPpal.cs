using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;
using Archivos;
using System.Threading;
using Patentes;

namespace _20181122_SP
{
    public partial class FrmPpal: Form
    {
        Queue<Patente> cola;
        private List<Thread> hilos = null;

        public FrmPpal()
        {
            InitializeComponent();
            this.hilos = new List<Thread>();
            this.cola = new Queue<Patente>();
        }

        private void FrmPpal_Load( object sender, EventArgs e )
        {
            vistaPatente1.finExposicion += ProximaPatente;
            vistaPatente2.finExposicion += ProximaPatente;

        }

        private void FrmPpal_FormClosing( object sender, FormClosingEventArgs e )
        {
            FinalizarSimulacion();
        }

        private void btnXml_Click( object sender, EventArgs e )
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/patentes.xml";
            List<Patente> aux = new List<Patente>();
            Xml<List<Patente>> xml = new Xml<List<Patente>>();

            try
            {
                xml.Leer(path, out aux);

                foreach (Patente p in aux)
                {
                    this.cola.Enqueue(p);
                }

            }
            catch (Exception)
            {

            }

            IniciarSimulacion();

        }

        private void IniciarSimulacion()
        {
            FinalizarSimulacion();
            ProximaPatente(vistaPatente1);
            ProximaPatente(vistaPatente2);

        }

        private void btnTxt_Click( object sender, EventArgs e )
        {

        }

        private void btnSql_Click( object sender, EventArgs e )
        {

        }

        private void ProximaPatente( Patentes.VistaPatente p )
        {
            if (this.cola != null && this.cola.Count != 0)
            {
                Thread hilo = new Thread(new ParameterizedThreadStart(p.MostrarPatente));
                hilo.Start(cola.Dequeue());
                this.hilos.Add(hilo);
            }

        }

        private void FinalizarSimulacion()
        {
            foreach (Thread hilo in this.hilos)
            {

                if (hilo.IsAlive && hilo != null)
                {
                    hilo.Abort();
                }

            }
        }
    }
}
