namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        #region Propiedades

        public string Nombre
        {
            set
            {
                this.nombre = value;
            }
            get
            {
                return this.nombre;
            }
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        #endregion Propiedades

        #region Constructores

        public Cliente( int numero )
        {
            this.numero = numero;
        }

        public Cliente( int numero, string nombre )
        {
            this.numero = numero;
            this.nombre = nombre;
        }

        #endregion Constructores

        #region Comparaciones

        public static bool operator !=( Cliente c1, Cliente c2 )
        {
            if (!(c1 == c2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==( Cliente c1, Cliente c2 )
        {
            if (c1.numero == c2.numero)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion Comparaciones
    }
}