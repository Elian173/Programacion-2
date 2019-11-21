using System;
using System.IO;
using System.Windows.Forms;
using BibliotecaClases;

namespace ArchivoLocoForm
{
    public partial class FormLoco : Form
    {
        private const string EXTENSION_VALIDA = ".txt";

        public FormLoco()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                string textoIngresado = richTextBoxTexto.Text;

                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                Archivador.GuardarTexto(textoIngresado, path, false, "Archivo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonLeer_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                string textoLeido = Archivador.Leer(path, "Archivo");

                this.richTextBoxTexto.Text = textoLeido;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


    }
}
