using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia14
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            double area;

            area = lado * 4;

            return area; 
        }

        public static double CalcularTriangulo(double baseTriangulo , double altura)
        {
            double area;

            area = (baseTriangulo * altura) / 2;

            return area;
        }

        public static double CalcularCirculo(double radio)
        {
            double area;

            area = Math.Pow(radio , 2);
            area = area * Math.PI;

            return area;
        }


    }
}
