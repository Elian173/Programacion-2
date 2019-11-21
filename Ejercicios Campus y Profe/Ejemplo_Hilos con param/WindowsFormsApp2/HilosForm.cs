using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class HilosForm : Form
    {
        private delegate void Callback(object o);
        private Thread hilo;

        public HilosForm()
        {
            InitializeComponent();
            
        }

        private void buttonEscribir_Click(object sender, EventArgs e)
        {
            this.richTextBoxTexto.Text += this.textBoxEscribir.Text + "\n";
            this.textBoxEscribir.Clear();
            
        }

        private void HilosForm_Load(object sender, EventArgs e)
        {
            this.hilo = new Thread(new ParameterizedThreadStart(Contar));
            hilo.Start(2);
        }

        private void Contar(object cant)
        {
            while(true)
            {
                this.ActualizarLabel(cant);
                Thread.Sleep(1000);
            }
        }

        private void ActualizarLabel(object o)
        {

                if (this.labelContador.InvokeRequired)
                {
                    object[] objs = new object[] { o };
                    Callback d = new Callback(this.ActualizarLabel);
                    this.Invoke(d, objs);
                }
                else
                {
                if(o != null)
                    this.labelContador.Text = (Convert.ToInt32(this.labelContador.Text) + (int)o).ToString();
                }
            

        }

        private void HilosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.hilo.IsAlive && this.hilo != null)
                hilo.Abort();
            
        }

        //private void ContarASaltos(object cantidadASaltar)
        //{
        //    while(true)
        //    {
        //        this.ActualizarLabel(cantidadASaltar);
        //        Thread.Sleep(1000);
        //    }
        //}

        //private void ActualizarLabel(object cantidadASaltar)
        //{
        //    if (this.labelContador.InvokeRequired)
        //    {
        //        object[] parametros = new object[] { cantidadASaltar };
        //        this.labelContador.Invoke(new Callback(this.ActualizarLabel), parametros);
        //    }
        //    else
        //    {
        //        this.labelContador.Text = (Convert.ToInt32(this.labelContador.Text) + (int) cantidadASaltar).ToString();
        //    }
        //}
    }
}
