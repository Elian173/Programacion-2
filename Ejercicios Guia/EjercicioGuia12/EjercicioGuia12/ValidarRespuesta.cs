using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia12
{
    public class ValidarRespuesta
    {

        public static bool ValidaS_N(char input)
        {
            bool isValid = false;

            if(input == 'S' || input == 's')
            {
                isValid = true;
            }
            return isValid;
        }
    }
}
