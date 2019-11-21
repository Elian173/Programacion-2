using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class EscrituraWrapper
    {
        private ConsoleColor color;
        private string texto;

        public EscrituraWrapper( ConsoleColor color, string texto)
        {
            this.color = color;
            this.texto = texto;
        }
    }
}
