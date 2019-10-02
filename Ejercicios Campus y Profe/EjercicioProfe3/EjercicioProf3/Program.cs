using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProf3
{
    class Program
    {
        static void Main(string[] args)
        {



            String Value = "A";
            String Key = "2";
            Dictionary<string  , string > diccionario = new Dictionary<string, string >();

            for (int i = 0; i < 5; i++)
            {

                diccionario.Add(Value += "A" ,   Key += "1");

            }


            foreach (KeyValuePair<string, string> par in diccionario)
            {
                Console.WriteLine("{0} - {1}" ,par.Key,par.Value);
            }

            Console.ReadKey();

        }
    }
}
