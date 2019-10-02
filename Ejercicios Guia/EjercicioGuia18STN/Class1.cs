using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * a. La clase Punto ha de tener dos atributos privados con acceso de sólo lectura (sólo con getters), que serán las coordenadas del punto. También un constructor que reciba los parámetros x e y.
b. La clase Rectangulo tiene los atributos de tipo Punto vertice1, vertice2, vertice3 y vertice4 (que corresponden a los cuatro vértices del rectángulo).
c. La base de todos los rectángulos de esta clase será siempre horizontal. Por lo tanto, debe tener un constructor para construir el rectángulo por medio de los vértices 1 y 3 (utilizar el método Abs de la clase Math, dicho método retorna el valor absoluto de un número, para obtener la distancia entre puntos).
d. Realizar los métodos getters para los atributos privados área y perímetro.
e. Los atributos área (base * altura) y perímetro ((base + altura)*2) se deberán calcular sólo una vez, al llamar por primera vez a su correspondiente método getter. Luego se deberá retornar siempre el mismo valor.
En el espacio de nombres PruebaGeometria es donde se escribirá una clase con el método Main.
f. Probar las funcionalidades de las clases Punto y Rectangulo.
i. Generar un nuevo Rectangulo.
ii. Imprimir por pantalla los valores de área y perímetro.
g. Desarrollar un método de clase que muestre todos los datos del rectángulo que recibe como parámetro.*/

namespace Geometria
{
    public class Punto
    {
        private int x;
        private int y;

        #region constructor
        public Punto(int x, int y)
        {

            this.x = x;
            this.y = y;

            return;
        }
        #endregion

        #region metodos
        public int GetX()
        {
            return this.x;
        }
        public int GetY()
        {
            return this.y;

        }
        #endregion
    }

    public class Rectangulo
    {
        #region Atributos

        Punto vertice1;


        Punto vertice2;
        Punto vertice3;


        Punto vertice4;

        private float area;
        private float perimetro;

        /*Supongo que el rectangulo es asi->
         *v1 _____________ v2
         * |                |
         * |                |
         * v3_______________v4*/
         // no me especifica la posicion de los vertices asi que no voy a hacer la base el doble de la altura y listo

        #endregion


        #region Constructor

        public Rectangulo(Punto vertice1 , Punto vertice3)
        {

            vertice1 = new Punto(vertice1.GetX(),vertice1.GetY()) ;
            vertice3 = new Punto(vertice3.GetX(), vertice3.GetY());

        }

        #endregion

        #region Metodos

        public float Area()
        {
            float altura;
            float valorX ;
            float valorY;


            altura = Math.Abs(g)


            return area;
        }




        #endregion


    }
}
