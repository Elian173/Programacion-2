using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia16
{
    public class Alumno
    {
        #region Atributos
        private byte nota1;
        private byte nota2;
        private double notaFinal;
        private string apellido;
        private int legajo;
        private string nombre;

        #endregion

        #region Metodos
   

        //Notas ->
        /// <summary>
        /// Carga la nota del alumno
        /// </summary>
        /// <param name="nota1">Nota del primer parcial</param>
        /// <param name="nota2">Nota del segundo parcial</param>
        public void Estudiar(byte nota1, byte nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            return;
        }

        public void CalcularFinal(byte nota1, byte nota2)
        {

            int notaGenerada;

            if (nota1 >= 4 && nota2 >= 4)
            {
                //genero nota final;
                Random notaFinalRandom = new Random();
                notaGenerada = notaFinalRandom.Next(1, 11);
            }
            else
            {
                notaGenerada = -1;
            }

            this.notaFinal = notaGenerada;

            return;
        }

        public string Mostrar()
        {
            /*
            string mensaje;
            string mensajeNotaFinal = "Alumno desaprobado";
            
            if(this.nota1 >= 4 && this.nota2 >= 4)
            {
                mensajeNotaFinal = Convert.ToString(this.notaFinal);
            }

            mensaje = "Alumno:" + this.nombre + " " + this.apellido +"\nLegajo:" + this.legajo + "\nNota1:" + this.nota1 +
                  "\nNota2:" + this.nota2 + "\nNota final :" +mensajeNotaFinal;

            return mensaje;
            */
            string mostrar = string.Empty;
            mostrar += String.Format("Nombre :{0}\n",this.nombre);
            mostrar += String.Format("Apellido:{0}\n", this.apellido);
            mostrar += String.Format("Legajo :{0}\n", this.legajo);
            mostrar += String.Format("NotaFinal:{0}\n", this.notaFinal);

            return mostrar;
        }
        #endregion

        #region Constructores

        public Alumno(string apellido, int legajo, string nombre)
        {

            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
            return;
        }

        #endregion
        
    }

}
