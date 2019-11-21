using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using ControlCantina;

namespace FrmCantina
{
    public partial class FrmCantina : Form
    {
        Cantina cantina;

        public FrmCantina()
        {
            InitializeComponent();
            
        }

        private void FrmCantina_Load(object sender, EventArgs e)
        {
            this.numericUpDownCapacidad.Value = 1000;
            this.numericUpDownContenido.Value = 1000;
            this.barra1.SetCantina = Cantina.GetCantina(10);
            this.comboBoxBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
            this.cantina = Cantina.GetCantina(100);
        }

        /// <summary>
        /// Agrega una botella a la barra, dependiendo su tipo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Botella.Tipo tipo;
            Enum.TryParse<Botella.Tipo>(comboBoxBotellaTipo.SelectedValue.ToString(), out tipo);

            if (radioButtonAgua.Checked)
            {
                Agua agua = new Agua(this.txtMarca.Text,(int) this.numericUpDownCapacidad.Value,(int) this.numericUpDownCapacidad.Value);
                barra1.AgregarBotella(agua);
            }
            
            if(radioButtonCerveza.Checked)
            {
                Cerveza cerveza = new Cerveza(this.txtMarca.Text, (int)this.numericUpDownCapacidad.Value, (int)this.numericUpDownCapacidad.Value,tipo);
                barra1.AgregarBotella(cerveza);
            }
                 
        }
    }
}
