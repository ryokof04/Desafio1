using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1.ArbolGenerico
{
    public class Nodo
    {
        // Dato que podrá almacenar el nodo
        public string dato { get; set; }

        // Referencias del nodo hacia su hermano y hacia su hijo
        public Nodo NodoHermano { get; set; }
        public Nodo NodoHijo { get; set; }

        // Constructor de la clase nodo
        public Nodo() {
            NodoHermano = null;
            NodoHijo = null;
            dato = "";
        }

    }
}
