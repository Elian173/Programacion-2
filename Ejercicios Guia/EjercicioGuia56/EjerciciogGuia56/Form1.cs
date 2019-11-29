using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EjerciciogGuia56
{
    public partial class Form1 : Form
    {

        private string pathArchivoAbierto = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path;
            string textoLeido;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                textoLeido = Archivador.Leer(path);
                this.richTxtBox.Text = textoLeido;


                //Me guardo el directorio del archivo que estoy usando
                this.pathArchivoAbierto = path;
            }

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.pathArchivoAbierto != null)
            {
                Guardar();
            }
            else
            {
                GuardarComo();
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarComo();
        }


        private void Guardar()
        {

            Archivador.GuardarTexto(this.richTxtBox.Text, this.pathArchivoAbierto, false);

        }

        private void GuardarComo()
        {

            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.pathArchivoAbierto = Path.GetFullPath(saveFileDialog.FileName);
                Guardar();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click( object sender, EventArgs e )
        {
            MessageBox.Show("Julian pelotudo");
        }
    }
}
