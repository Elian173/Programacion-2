using BibliotecaClases;
using System;
using System.Windows.Forms;

namespace FrmMostrar
{
    public partial class FrmGenerarLlamada: Form
    {
        #region Fields

        private Centralita centralita;

        #endregion Fields

        #region Constructors

        public FrmGenerarLlamada( Centralita centralita )
        {
            InitializeComponent();
            this.centralita = centralita;
            comboBoxFranjas.DataSource = Enum.GetValues(typeof(Provincial.Franja));
        }

        #endregion Constructors

        #region Properties

        public Centralita Centralita
        {
            get
            {
                return this.centralita;
            }
        }

        #endregion Properties

        #region Methods

        private void BotonLimpiar_Click( object sender, EventArgs e )
        {
            this.textoNumeroDestino.Text = string.Empty;
        }

        private void botonLlamar_Click( object sender, EventArgs e )
        {
            string numeroDestino = this.textoNumeroDestino.Text;
            string numeroOrigen = this.textoNumeroOrigen.Text;
            bool esValido = true;

            #region Validaciones

            if (numeroOrigen == string.Empty || numeroDestino == string.Empty ||
                numeroOrigen == "Nro Origen" || numeroDestino == "Nro Destino")
            {
                esValido = false;
                MessageBox.Show("Complete todos los campos");
            }

            //valido destino
            if (esValido)
            {
                int asteriscos = 0, numerales = 0;

                foreach (char x in numeroDestino)
                {
                    if (x == '*')
                        asteriscos++;

                    if (x == '#')
                        numerales++;

                    if (asteriscos > 1 || numerales > 1)
                    {
                        MessageBox.Show("aya");
                        esValido = false;
                        break;
                    }
                }

                if (numeroDestino.Length > 20 || numeroDestino.Length < 8)
                {
                    esValido = false;
                }

                if (esValido == false)
                {
                    MessageBox.Show("Numero de Destino Invalido", "Error", MessageBoxButtons.OK);
                }
            }
            //valido origen

            if (esValido)
            {
                int asteriscos = 0, numerales = 0;

                foreach (char x in numeroOrigen)
                {
                    if (x == '*')
                        asteriscos++;
                    if (x == '#')
                        numerales++;

                    if (asteriscos > 1 || numerales > 1)
                    {
                        esValido = false;
                        break;
                    }
                }

                if (numeroOrigen.Length > 20 || numeroOrigen.Length < 8)
                {
                    esValido = false;
                }

                if (esValido == false)
                {
                    MessageBox.Show("Numero de Origen Invalido", "Error", MessageBoxButtons.OK);
                }
            }

            #endregion Validaciones

            //Genero la llamada->

            if (esValido)
            {
                Random r = new Random();
                float duracion = r.Next(1, 50);
                float costo = (float) (5.6 * r.NextDouble());

                Llamada nuevaLlamada;

                Provincial.Franja franjas;
                Enum.TryParse<Provincial.Franja>(comboBoxFranjas.SelectedValue.ToString(), out franjas);

                //Veo si es local o prov.
                switch (numeroDestino[0])
                {
                    case '#':
                    nuevaLlamada = new Provincial(numeroOrigen, franjas, duracion, numeroDestino);
                    break;

                    default:
                    nuevaLlamada = new Local(numeroOrigen, duracion, numeroDestino, costo);
                    break;
                }

                centralita = centralita + nuevaLlamada;
                MessageBox.Show("Llamada realizada", "", MessageBoxButtons.OK);
            }
        }

        private void botonSalir_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void TextoNumeroOrigen_Click(object sender, EventArgs e)
        {
            this.textoNumeroOrigen.Text = string.Empty;
        }

        private void textoNumeroDestino_TextChanged( object sender, EventArgs e )
        {
            string numero = textoNumeroDestino.Text.ToString();

            //Si no esta vacio->
            if (numero != string.Empty)
            {
                //Si es la primera vez
                if (numero[0] == 'N')
                {
                    this.textoNumeroDestino.Text = numero[11].ToString();
                }

                /*Si Es provincial*/
                if (numero[0] == '#')
                {
                    this.comboBoxFranjas.Enabled = true;
                }
                else
                {
                    this.comboBoxFranjas.Enabled = false;
                }
            }
        }

        #region Botones numeros

        private void Button0_Click( object sender, EventArgs e )
        {
            this.textoNumeroDestino.Text = this.textoNumeroDestino.Text + "0";
        }

        private void Button1_Click( object sender, EventArgs e )
        {
            this.textoNumeroDestino.Text = this.textoNumeroDestino.Text + "1";
        }

        private void Button2_Click( object sender, EventArgs e )
        {
            this.textoNumeroDestino.Text = this.textoNumeroDestino.Text + "2";
        }

        private void Button3_Click( object sender, EventArgs e )
        {
            this.textoNumeroDestino.Text = this.textoNumeroDestino.Text + "3";
        }

        private void Button4_Click( object sender, EventArgs e )
        {
            this.textoNumeroDestino.Text = this.textoNumeroDestino.Text + "4";
        }

        private void Button5_Click( object sender, EventArgs e )
        {
            this.textoNumeroDestino.Text = this.textoNumeroDestino.Text + "5";
        }

        private void Button6_Click( object sender, EventArgs e )
        {
            this.textoNumeroDestino.Text = this.textoNumeroDestino.Text + "6";
        }

        private void Button7_Click( object sender, EventArgs e )
        {
            this.textoNumeroDestino.Text = this.textoNumeroDestino.Text + "7";
        }

        private void Button8_Click( object sender, EventArgs e )
        {
            this.textoNumeroDestino.Text = this.textoNumeroDestino.Text + "8";
        }

        private void Button9_Click( object sender, EventArgs e )
        {
            this.textoNumeroDestino.Text = this.textoNumeroDestino.Text + "9";
        }

        private void ButtonAsterisco_Click( object sender, EventArgs e )
        {
            this.textoNumeroDestino.Text = this.textoNumeroDestino.Text + "*";
        }

        private void ButtonNumeral_Click( object sender, EventArgs e )
        {
            this.textoNumeroDestino.Text = this.textoNumeroDestino.Text + "#";
        }

        #endregion Botones numeros

        #endregion Methods


    }
}