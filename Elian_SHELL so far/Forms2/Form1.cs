using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HilosFormsPARAM
{ 
    delegate void Callback( object o );
    public partial class Form1: Form
    {

        private Thread hilo;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load( object sender, EventArgs e )
        {
            this.labelContador.Text = "0";
            this.hilo = new Thread(new ParameterizedThreadStart(Contar));
            this.hilo.Start(10);
        }


        private void Contar( object cant )
        {
            while (true)
            {
                this.ActualizarLabel(cant);
                Thread.Sleep(1000);
            }
        }

        private void ActualizarLabel( object o )
        {

            if (this.labelContador.InvokeRequired)
            {
                object[] objs = new object[] { o };
                Callback d = new Callback(this.ActualizarLabel);
                this.Invoke(d, objs);
            }
            else
            {
                if (o != null)
                    this.labelContador.Text = (Convert.ToInt32(this.labelContador.Text) + (int) o).ToString();
            }


        }

        private void button1_Click( object sender, EventArgs e )
        {
            this.richTextBox1.Text = "XD";
        }

        private void Form1_FormClosing( object sender, FormClosingEventArgs e )
        {
            if (this.hilo.IsAlive && this.hilo != null)
                hilo.Abort();
        }
    }
}
