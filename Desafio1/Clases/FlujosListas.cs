using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1.Clases
{
    public static class FlujosListas
    {
        // Lista para manejar pacientes en flujo de aplicación
        public static List<Paciente> pacientes { get; set; } = default!;

        // Lista para dibujar pacientes en el arbol binario
        public static List<Paciente> pacientesDibujo { get; set; } = default!;
    }
}
