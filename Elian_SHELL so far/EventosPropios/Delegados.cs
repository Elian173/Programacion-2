using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosPropios
{
    public delegate void Callback();
    public delegate void CallbackP( object something );
    //Delegado para eventos , meter en el namespace de la clase instanciable ej Persona:
    public delegate void DelegadoString( string x );
    //Evento: meter DENTRO de la clase instanciable
    //public event DelegadoString EventoString;

    //dentro de la clase lanzo el evento asi
    //if (this.EventoString != null)
    //{
    //  EventoString.Invoke("Se hizo algo");
    //}

    //Ese evento tira un string que contiene lo que yo quiera.

    //En un forms, asocio un evento a un metodo que yo quiera, y cada vez que la clase lanze el evento , se ejecuta el metodo
    //persona.EventoString += NotificarCambio;
    //persona.EventoString es el evento , notificarCambio es un metodo dentro del forms que recibe un string, por el tema del delegado



}
