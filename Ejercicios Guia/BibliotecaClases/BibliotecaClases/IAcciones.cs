﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    interface IAcciones
    {
        ConsoleColor Color { get; set; }

        float UnidadesDeEscritura { get; set; }

        EscrituraWrapper Escribir(string Texto);

        bool Recargar(int unidades);


    }
}
