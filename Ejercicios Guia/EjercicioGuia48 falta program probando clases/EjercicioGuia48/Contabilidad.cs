using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia48
{
    public class Contabilidad<T, U>  where T : Documento where U : Documento , new ()
    {
        private List<T> egresos;
        private List<U> ingresos;


        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }

        #region Metodos
        public static Contabilidad<T,U> operator + (Contabilidad<T, U> c, T egreso)
        {
            if (!(c.egresos.Contains(egreso)))
            {
                c.egresos.Add(egreso);
            }
            return c;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            if (!(c.ingresos.Contains(ingreso)))
            {
                c.ingresos.Add(ingreso);
            }
            return c;
        }

        public string Mostrar ()
        {
            StringBuilder descripcion = new StringBuilder();
            descripcion.AppendLine("Ingresos:");

            foreach (U ingreso in this.ingresos)
            descripcion.AppendLine((ingreso.Numero).ToString());


            descripcion.AppendLine("Egresos:");

            foreach(T egreso in this.egresos)
            descripcion.AppendLine((egreso.Numero).ToString());

            return descripcion.ToString();

        }
        #endregion


    }
}
