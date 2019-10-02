using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medidas
{
    class Celsius
    {
        double grados;
        double equivalenteFarenheit;


        Celsius(double grados)
        {
            this.grados = grados;
        }


        explicit operator Farenheit(Celsius grados)
        {
            Farenheit gradosFarenheit;

            grados * (9 / 5) + 32;

        }


    }
}
