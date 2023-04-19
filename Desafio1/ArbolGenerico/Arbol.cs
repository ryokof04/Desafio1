using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1.ArbolGenerico
{
    public class Arbol
    {
        private Nodo nodoRaiz;
        private Nodo descendiente;

        // Constructor vacio
        public Arbol()
        {
            nodoRaiz = new Nodo();
        }

        // Método para insertar nodo
        public Nodo Insertar(string datoNodo, Nodo nodoOperacion)
        {

            // Si el nodo a operar es nulo
            if (nodoOperacion == null)
            {
                nodoRaiz = new Nodo();
                nodoRaiz.dato = datoNodo;

                // El nodo raiz no tiene hijo
                nodoRaiz.NodoHijo = null;

                // El nodo raiz no tiene hermano
                nodoRaiz.NodoHermano = null;

                return nodoRaiz;

            }
            // Evaluamos si el nodo que estamos operando tiene hijos
            else if (nodoOperacion.NodoHijo == null)
            {
                Nodo nuevoNodo = new Nodo();
                nodoOperacion.NodoHijo = nuevoNodo;
                nuevoNodo.dato = datoNodo;

                return nuevoNodo;
            }
            // Ya tiene hijo entonces lo agregamos como hermano
            else {
                descendiente = nodoOperacion.NodoHijo;

                // Recorremos todos los hermanos para agregar el nodo al final como hermano
                while (descendiente.NodoHermano != null) {
                    descendiente = descendiente.NodoHermano;
                }

                // Se crea el nodo nuevo que se agregará como último hermano
                Nodo nuevoNodo = new Nodo();

                nuevoNodo.dato = datoNodo;
                descendiente.NodoHermano = nuevoNodo;

                return nuevoNodo;
            }
        }

        // Transversa preorder 
        public void TransversaPreorden(Nodo nodoOperacion) {

            var i = 0;

            if (nodoOperacion == null) {
                return;
            }

            // Procesamos primero el nodo padre 
            for (int n = 0; n < i; n++) {
                Console.Write(" ");
            }

            Console.WriteLine(nodoOperacion.dato);

            // Ya terminado de procesar el padre, procesamos al hijo
            if (nodoOperacion.NodoHijo != null) {
                i++;
                TransversaPreorden(nodoOperacion.NodoHijo);
                i--;
            }

            // Procesamos los hermanos luego de procesar al hijo
            if (nodoOperacion.NodoHermano != null) {
                TransversaPreorden(nodoOperacion.NodoHermano);
            }
        }
    }
}
