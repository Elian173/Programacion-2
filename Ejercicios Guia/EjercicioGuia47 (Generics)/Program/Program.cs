using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioGuia47__Generics_;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //esto es de Interfaces , nada que ver 
            /*
            IEnumerable<string> x = new List<string>();
            List<string> y = new List<string>();

            foreach(string texto in x)
            {

                ( (List<string>)x ).Add ("A") ;
                y.Add("B");

            }
            */
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("TORNEO DE BASQUET" );
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("TORNEO DE FUTBOL");

            EquipoFutbol equipo1, equipo2, equipo3;
            equipo1 = new EquipoFutbol("UNO", DateTime.Now);
            equipo2 = new EquipoFutbol("DOS", DateTime.Now);
            equipo3 = new EquipoFutbol("TRES", DateTime.Now);

            EquipoBasquet equipoB1, equipoB2, equipoB3;
            equipoB1 = new EquipoBasquet("B UNO", DateTime.Now);
            equipoB2 = new EquipoBasquet("B DOS", DateTime.Now);
            equipoB3 = new EquipoBasquet("B TRES", DateTime.Now);


            torneoBasquet = torneoBasquet + equipoB1;
            torneoBasquet = torneoBasquet + equipoB2;
            torneoBasquet = torneoBasquet + equipoB3;
            torneoBasquet = torneoBasquet + equipoB1; //repetido
            //torneoBasquet = torneoBasquet + equipo3; // intento meter equipo de futbol en basquet

            torneoFutbol = torneoFutbol + equipo1;
            torneoFutbol = torneoFutbol + equipo2;
            torneoFutbol = torneoFutbol + equipo3;
            torneoFutbol = torneoFutbol + equipo1; // repetido
            //torneoFutbol = torneoFutbol + equipoB3; // Intento meter equipo de basquet en futbol



            Console.WriteLine("TORNEO BASQUET");
            Console.WriteLine(torneoBasquet.Mostrar());
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine();

            Console.WriteLine("TORNEO FUTBOL");
            Console.WriteLine(torneoFutbol.Mostrar());
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);

            Console.ReadKey();


        }

    }
}
