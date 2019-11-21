using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProf
{
    public class Mensaje <T , Pepe>  //where T : struct //solo tipo valor//
                                     //where T :class // solo referencia
                                     //where T:new() // que tenga constructor
    {
        private T mensaje;
        private Pepe atributo;
    }


    public class Prueba
    {
        public static void Metodo <T>(T param) // where T  : algo
        {

        }
        //sobrecarga 
        public static void Metodo<T>(T param , int param2 )
        { }

    }


}
