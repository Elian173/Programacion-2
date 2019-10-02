using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fomrs
{
    public partial class woow : Form
    {
        public woow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSaludo_OnClick(object sender, EventArgs e)
        {
            String nombre = this.ook.Text;
            DialogResult result = MessageBox.Show("Hola"+ nombre, "Saludo" , MessageBoxButtons.RetryCancel,MessageBoxIcon.Exclamation);

            if (result == DialogResult.Retry)
            {
                woow form = new woow();
                form.ShowDialog();
            }


        }

        private void ook_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormSaludarOnLoad(object sender, EventArgs e)
        {
            this.ook.Text = "Ingrese su nombre";
        }
    }
}
