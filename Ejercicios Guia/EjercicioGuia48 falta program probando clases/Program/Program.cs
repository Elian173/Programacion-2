using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioGuia48;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();
            Factura fact1 = new Factura(100);
            Recibo rec1 = new Recibo();
            Recibo rec2 = new Recibo(120);
            Documento doc = new Documento(130);


            contabilidad = contabilidad + fact1;
            contabilidad = contabilidad + rec1;
            contabilidad += rec2;
            //Contabilidad += doc; //Intento meter un tipo Documento


            Console.WriteLine(contabilidad.Mostrar());

            Console.ReadKey();
            







        }
    }
}
