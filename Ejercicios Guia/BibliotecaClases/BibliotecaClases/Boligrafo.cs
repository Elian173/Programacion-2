using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Boligrafo
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(ConsoleColor colorTinta , float tinta)
        {
             this.colorTinta = colorTinta;
             this.tinta = tinta;
        }


        public ConsoleColor Color
        {
            get { return this.colorTinta; }
            set { this.colorTinta = value; }
        }

        public float Tinta
        {
            get { return this.tinta; }
            set { this.tinta = value; }
        }


    }
}
