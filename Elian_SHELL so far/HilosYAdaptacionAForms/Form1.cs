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

namespace HilosYAdaptacionAForms
{
 delegate void Callback();
    public partial class Form1: Form
    {
        
        private Thread hilo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load( object sender, EventArgs e )
        {
            this.hilo = new Thread(new ThreadStart(Contar));
            this.hilo.Start();
            this.labelContador.Text = "0";
        }

        private void ActualizarLabel()
        {
            if (this.labelContador.InvokeRequired)
            {
                Callback callback = new Callback(this.ActualizarLabel);
                this.labelContador.Invoke(callback);
            }
            else
            {
                this.labelContador.Text = (Convert.ToInt32(this.labelContador.Text) + 1).ToString();
            }
        }
        public void Contar()
        {
            while (true)
            {
                this.ActualizarLabel();
                Thread.Sleep(1000);
            }
        }

        private void Form1_FormClosing( object sender, FormClosingEventArgs e )
        {
            if (this.hilo.IsAlive && this.hilo != null)
                hilo.Abort();
        }

        private void button1_Click( object sender, EventArgs e )
        {

        }
    }
}
