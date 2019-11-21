using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    public partial class Form1: Form
    {
    
    private Persona persona;

    public Form1()
    {
        InitializeComponent();

    }

    private void Form1_Load( object sender, EventArgs e )
    {
        //persona.EventoString += NotificarCambio;
    }

    private void buttonGenerar_Click( object sender, EventArgs e )
    {

        if (this.persona == null)
        {
            this.persona = new Persona();
            persona.EventoString += NotificarCambio;
            persona.Nombre = this.textBoxNombre.Text;
            persona.Apellido = this.textBoxApellido.Text;
            this.buttonGenerar.Text = "Actualizar";

        }
        else
        {
            persona.Nombre = this.textBoxNombre.Text;
            persona.Apellido = this.textBoxApellido.Text;
        }


        persona.Mostrar();


    }

    public static void NotificarCambio( string msj )
    {
        MessageBox.Show(msj);
    }


}
}
