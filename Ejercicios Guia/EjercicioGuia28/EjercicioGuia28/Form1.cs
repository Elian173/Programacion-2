using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjercicioGuia28
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HacerCosas( Dictionary<string, int> contadorPalabras, int cantidadAMostrar )
        {
            List<KeyValuePair<string, int>> lista = contadorPalabras.ToList();

            lista.Sort(Comparar);//tambien asi sin hacer la funcion->
                                 // lista.Sort((x, y) => y.Value - x.Value);

            //_____________ Mostrar ______________

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("PALABRAS MAS REPETIDAS:");

            for (int i = 0, j = 0; i < lista.Count && j < cantidadAMostrar; i++)
            {
                sb.AppendFormat("<<Puesto {0:0#}>> {1}, {2} repeticiones.\n", i + 1, lista[i].Key, lista[i].Value);

                if (lista[i].Value != lista[i + 1].Value)
                {
                    j++;
                }
            }

            MessageBox.Show(sb.ToString(), "Palabras más repetidas", MessageBoxButtons.OK);

            /*
              Caso de prueba:

              "Prueba Test Prueba PRUEBA Hola hola test test gato gato prueba casa perro hola gato esto es laboratorio y programación 2 casa"

              Resultado
              prueba 04
              test 03
              hola 03
              gato 03
              casa 02
           */
        }

        private int Comparar( KeyValuePair<string, int> x, KeyValuePair<string, int> y )
        {
            return y.Value - x.Value;
        }

        private void Button_Click( object sender, EventArgs e )
        {
            // Declaro un atributo que almacenará mi diccionario (contador de palabras)
            Dictionary<string, int> contadorPalabras;

            // Las colecciones son objetos, hay que instanciarlos.
            contadorPalabras = new Dictionary<string, int>();

            //Separo las palabras que pone el usuario en base a cada espacio que pone
            string[] palabras = this.txtUser.Text.Split(' ');

            foreach (string palabra in palabras)
            {
                string palabraAux = palabra.ToLower();

                if (contadorPalabras.ContainsKey(palabraAux))
                {
                    contadorPalabras[palabraAux]++;
                }
                else
                {
                    contadorPalabras.Add(palabraAux, 1);
                }
            }
            this.HacerCosas(contadorPalabras, 3);
        }
    }
}