using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*a. La cantidad máxima de tinta para todos los bolígrafos será de 100. Generar una constante
en el Boligrafo llamada cantidadTintaMaxima donde se guardará dicho valor.
b. Generar los métodos GetColor y GetTinta para los correspondientes atributos (sólo
retornarán el valor del mismo).
c. Generar el método privado SetTinta que valide el nivel de tinta y asigne en el atributo.
i. tinta será el valor a agregar (cambiar )  de tinta, pudiendo ser positivo (cargar tinta) o negativo
(gastar tinta)
ii. Se deberá validar que el nivel de tinta quede entre los valores válidos mayor o igual a
0 y menor o igual a cantidadTintaMaxima.
d. Recargar() colocará a tinta en su nivel máximo de tinta. Reutilizar código.
e. En el Main, crear un bolígrafo de tinta azul (ConsoleColor.Blue) y una cantidad inicial de tinta
de 100 y otro de tinta roja (ConsoleColor.Red) y 50 de tinta.
f. El método Pintar(short, out string) restará la tinta gastada (reutilizar código SetTinta), sin
poder quedar el nivel en negativo, avisando si pudo pintar (nivel de tinta mayor a 0).
También informará mediante el out string tantos "*" como haya podido "gastar" del nivel de
tinta. O sea, si nivel de tinta es 10 y gasto es 2 valdrá "**" y si nivel de tinta es 3 y gasto es
10 "***".
g. Utilizar todos los métodos en el Main.
h. Al utilizar Pintar, si corresponde, se deberá dibujar por pantalla con el color de dicho
bolígrafo.
Nota: Crear el constructor que crea conveniente. La clase Boligrafo y el Program deben estar en
namespaces distintos.*/


namespace Tinta
{
    public class Boligrafo
    {
        #region atributos           


        private const short cantidadMaximaTinta = 100;
        private short tinta;
        ConsoleColor color;

        #endregion

        #region Constructor

       public Boligrafo(short tinta , ConsoleColor color)
        {

            this.tinta = tinta ;
            this.color = color;

            return; 
        }

        #endregion

        #region Metodos

        /// <summary>
        /// 
        /// </summary>
        /// <returns>El color del boligrafo</returns>
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns>El nivel de tinta</returns>
        public short GetTinta()
        {
            return this.tinta;
        }

        /// <summary>
        /// Permite asignar un nivel de tinta entre 100 y -100
        /// </summary>
        /// <param name="tinta"></param>
        /// <returns>True si se ingreso un valor valid , false si no.</returns>
        public bool SetTinta(short tinta)
        {
            bool isValid = false;

            if (!(tinta > 100 || tinta < -100))
            {
                isValid = true;
                this.tinta = tinta;
            }

            return isValid;
        }

        /// <summary>
        /// Pone el nivel de tinta en 100
        /// </summary>
        public void Recargar ()
        {
            SetTinta(100);
            return;
        }


        public bool Pintar (short gasto , out string dibujo)
        {
            bool hayTinta = true;
            short nivelDeTinta = this.tinta;
            dibujo = "";
            Console.ForegroundColor = this.color;

            if(this.tinta < 0)
            {
                hayTinta = false;
            }
            else
            {
                while (this.tinta > 0 && gasto > 0)
                {
                   // supongamos que toma 10 de tinta pintar un *
                   if(gasto % 10 == 0)
                    {
                        dibujo = dibujo + "*";
                    }

                   nivelDeTinta--;
                    gasto--;
                    SetTinta(nivelDeTinta);
                    
                }

            }
            return hayTinta;
        }

        #endregion
    }
}
