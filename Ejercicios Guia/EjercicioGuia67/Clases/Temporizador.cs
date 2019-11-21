using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Clases
{

    public class Temporizador
    {
        private Thread hilo;
        private int intervalo;

        //evento
        public event EncargadoTiempo EventoTiempo;

        //delegado
        public delegate void EncargadoTiempo();

        //public Temporizador()
        //{
        //       this.hilo = new Thread(new ThreadStart(Corriendo));
        //       hilo.Start();
        //}

        public bool Activo
        {
            get
            {
                if (this.hilo != null)
                {
                    if (this.hilo.IsAlive)
                    {
                        return true;
                    }
                }

                return false;

            }

            set
            {
                if (value == true)
                {
                    if (this.hilo == null)
                    {

                        //this.hilo = new Thread(new ThreadStart(Corriendo));
                        //this.hilo.Start();

                        EncargadoTiempo llamarACorriendo = new EncargadoTiempo(Corriendo);
                        this.hilo = new Thread(new ThreadStart(llamarACorriendo));
                        this.hilo.Start();



                    }

                    if (this.hilo.IsAlive == false)
                    {
                        //    this.hilo = new Thread(new ThreadStart(Corriendo));
                        //    this.hilo.Start();

                        EncargadoTiempo llamarACorriendo = new EncargadoTiempo(Corriendo);
                        this.hilo = new Thread(new ThreadStart(llamarACorriendo));
                        this.hilo.Start();
                    }
                }


                if (value == false)
                {
                    if (this.hilo != null)
                    {
                        if (this.hilo.IsAlive == true)
                        {
                            this.hilo.Abort();
                        }
                    }
                }

            }
        }


        public int Intervalo
        {
            get { return this.intervalo; }
            set { this.intervalo = value; }
        }

        //metodo
        private void Corriendo()
        {
            while (true)
            {
                if (this.EventoTiempo != null)
                {
                    this.EventoTiempo.Invoke();
                    Thread.Sleep(this.Intervalo);
                }
            }
        }

    }
}
