using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rectangulo : Figura
    {

        double altura;
        double baseR;

        public Rectangulo (double baseR, double altura)
        {
            this.baseR = baseR;
            this.altura = altura;
        }

        public override string Dibujar()
        {
            return "Dibujando Rectangulo...";
        }

        public override double CalcularSuperficie()
        {
            return baseR*altura;
        }

        public override double CalcularPerimetro()
        {
            return (baseR + altura) *2;
        }
    }
}
